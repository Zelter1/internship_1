using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Mail_Detector
{
    public partial class FormServer : Form
    {
        public FormServer()
        {
            InitializeComponent();
        }

        private void FormServer_Load(object sender, EventArgs e)
        {
            textBox1.Text = Properties.Settings.Default.Servername;
        }

        //Connexion au Serveur SQL
        private void button1_Click(object sender, EventArgs e)
        {
            string servername = textBox1.Text;
            string connstring = "Data source =" + servername + ";Initial Catalog = campus;Integrated Security = SSPI";

            try
            {
                //Création
                SqlConnection con = new SqlConnection(connstring);

                //Test de connexion
                con.Open();
                con.Close();

                //Sauvegarde du nom du serveur
                Properties.Settings.Default.Servername = textBox1.Text;
                Properties.Settings.Default.Save();

                //Etape suivante
                FormFolder form2 = new FormFolder();
                this.Hide();
                form2.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
