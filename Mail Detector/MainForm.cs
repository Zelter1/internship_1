using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Outlook = Microsoft.Office.Interop.Outlook;


namespace Mail_Detector
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.AutoSend)
            {
                checkBoxAutoSend.Checked = true;
            }

            if (Properties.Settings.Default.TopMost)
            {
                checkBoxTop.Checked = true;
            }
        }

        private void checkBoxTop_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTop.Checked)
            {
                Properties.Settings.Default.TopMost = true;
                this.TopMost = true;
                Properties.Settings.Default.Save();


            }
            else
            {
                Properties.Settings.Default.TopMost = false;
                this.TopMost = false;
                Properties.Settings.Default.Save();

            }

        }

        private void checkBoxAutoSend_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAutoSend.Checked)
            {
                Properties.Settings.Default.AutoSend = true;
                Properties.Settings.Default.Save();
            }

            else
            {
                Properties.Settings.Default.AutoSend = false;
                Properties.Settings.Default.Save();
            }

        }

        private async void buttonSendManyFiles_Click(object sender, EventArgs e)
        {
            //Création.
            OpenFileDialog ofd = new OpenFileDialog();

            //Personnalisation.
            ofd.Multiselect = true;
            ofd.InitialDirectory = Properties.Settings.Default.Folderpath;
            ofd.Filter = "pdf (*.pdf)|*.pdf|" + "Tous les fichiers (*.*)|*.*";

            string servername = Properties.Settings.Default.Servername;
            string connstring = "Data source =" + servername + ";Initial Catalog = campus;Integrated Security = SSPI";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    SqlConnection con = new SqlConnection(connstring);

                    foreach (string filename in ofd.SafeFileNames)
                    {
                        //Connexion au serveur SQL.
                        con.Open();

                        //Création du chemin d'accès du fichier.
                        string filepath = Properties.Settings.Default.Folderpath + @"\" + filename;

                        //Récupération de l'id depuis le nom du fichier.
                        string[] filenamesplited = filename.Split('_', ' ');
                        var id = filenamesplited[2];

                        //Récupération de l'email et nom du client via l'id dans la base de données.
                        string query = @"SELECT [FICHE_MAIL], [CL_NOM], [FAC_NUMERO]

                                         FROM   [campus].[dbo].[CLIENT] as C
                                               ,[campus].[dbo].[ADRESSE] as A
                                               ,[campus].[dbo].[FICHE_CONTACT] as FC
                                       	       ,[campus].[dbo].[FACTURE] as F

                                         WHERE F.[CL_COMPTE] = C.[CL_COMPTE]
                                         AND   C.[CL_COMPTE] = [ADR_COMPTE]
                                         AND   A.[ADR_ID] = FC.[ADR_ID]                                         
                                         AND   [FICHE_NOM] LIKE 'Fac%'
                                         AND   [FAC_NUMERO] =" + id;

                        SqlCommand cmd = new SqlCommand(query, con);
                        SqlDataReader reader = cmd.ExecuteReader();

                        string mail = "";
                        string nomclient = "";
                        string facturenum = "";

                        while (reader.Read())
                        {
                            mail +=  reader.GetValue(0) + ";";
                            nomclient = "" + reader.GetValue(1);
                            facturenum = "" + reader.GetValue(2);
                        }
                        con.Close();

                        //Création du mail.
                        await Task.Delay(500);
                        Outlook.Application oApp = new Outlook.Application();
                        Outlook._MailItem oMailItem = (Outlook._MailItem)oApp.CreateItem(Outlook.OlItemType.olMailItem);

                        //Injection du contenu.
                        oMailItem.To = mail;
                        oMailItem.Subject = Properties.Settings.Default.Subject.Replace("[nomclient]", nomclient).Replace("[idfacture]", id);
                        oMailItem.CC = Properties.Settings.Default.CC;
                        oMailItem.BCC = Properties.Settings.Default.BCC;
                        oMailItem.Body = Properties.Settings.Default.Body.Replace("[nomclient]", nomclient).Replace("[idfacture]", id);
                        oMailItem.Attachments.Add(filepath);

                        //Configuration de l'envoi automatique.
                        if (checkBoxAutoSend.Checked)
                        {
                            oMailItem.Send();
                            con.Open();
                            File.Delete(filepath);
                            string query2 = "UPDATE campus.dbo.FACTURE SET FAC_REGLE = 1 WHERE FAC_NUMERO =" + facturenum;
                            SqlCommand cmd2 = new SqlCommand(query2, con);
                            cmd2.ExecuteNonQuery();
                            con.Close();
                        }

                        else
                        {
                            //Donne la priorité a Outlook.
                            this.TopMost = false;
                            oMailItem.Display(true);

                            //Information de l'envoi de l'email
                            DialogResult result;
                            result = MessageBox.Show("Avez-vous envoyé votre email ?", "Demande de confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (result == DialogResult.Yes)
                            {
                                con.Open();
                                File.Delete(filepath);
                                string query2 = "UPDATE campus.dbo.FACTURE SET FAC_REGLE = 1 WHERE FAC_NUMERO =" + facturenum;
                                SqlCommand cmd2 = new SqlCommand(query2, con);
                                cmd2.ExecuteNonQuery();
                                con.Close();
                            }

                            if (checkBoxTop.Checked)
                            {
                                this.TopMost = true;
                            }
                        }
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void personnalisationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMail formMail = new FormMail();
            this.Hide();
            formMail.ShowDialog();
            this.Show();
        }

        private void configurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormServer config = new FormServer();

            this.Hide();
            config.ShowDialog();
            this.Show();
        }

    }
}
