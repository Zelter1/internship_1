using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mail_Detector
{
    public partial class FormMail : Form
    {
        public FormMail()
        {
            InitializeComponent();
        }

        private void FormMail_Load(object sender, EventArgs e)
        {
            richTextBoxSubject.Text = Properties.Settings.Default.Subject;
            richTextBoxCC.Text = Properties.Settings.Default.CC;
            richTextBoxBCC.Text = Properties.Settings.Default.BCC;
            richTextBoxBody.Text = Properties.Settings.Default.Body;

        }



        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Ces paramètres seront appliqués pour l'envoi des mails automatiques, êtes-vous sûr de vouloir valider ?", "Attention", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                Properties.Settings.Default.Subject = richTextBoxSubject.Text;
                Properties.Settings.Default.CC = richTextBoxCC.Text;
                Properties.Settings.Default.BCC = richTextBoxBCC.Text;
                Properties.Settings.Default.Body = richTextBoxBody.Text;
                Properties.Settings.Default.Save();
                Close();
            }
        }
    }
}
