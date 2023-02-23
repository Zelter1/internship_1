using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Mail_Detector
{
    public partial class FormFolder : Form
    {
        public FormFolder()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = Properties.Settings.Default.Folderpath;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //Création
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            //Personnalisation
            fbd.Description = "Selectionnez le dossier où sont enregistrés vos fichier.pdf";

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = fbd.SelectedPath;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string FolderPath = textBox1.Text;
            if (Directory.Exists(FolderPath))
            {
                //Sauvegarde du chemin du dossier
                Properties.Settings.Default.Folderpath = FolderPath;
                Properties.Settings.Default.Save();

                this.Close();
            }

            else
            {
                MessageBox.Show("Dossier introuvable ou inexistant. Vérifiez que le nom est correct.", "Nom de dossier incorrect", default, MessageBoxIcon.Error);
            }
        }
    }
}
