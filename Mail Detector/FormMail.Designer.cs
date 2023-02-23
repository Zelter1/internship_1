namespace Mail_Detector
{
    partial class FormMail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMail));
            this.richTextBoxBody = new System.Windows.Forms.RichTextBox();
            this.labelSubject = new System.Windows.Forms.Label();
            this.labelBody = new System.Windows.Forms.Label();
            this.richTextBoxSubject = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelCc = new System.Windows.Forms.Label();
            this.richTextBoxCC = new System.Windows.Forms.RichTextBox();
            this.labelCci = new System.Windows.Forms.Label();
            this.richTextBoxBCC = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBoxBody
            // 
            this.richTextBoxBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxBody.Location = new System.Drawing.Point(12, 139);
            this.richTextBoxBody.Name = "richTextBoxBody";
            this.richTextBoxBody.Size = new System.Drawing.Size(727, 344);
            this.richTextBoxBody.TabIndex = 2;
            this.richTextBoxBody.Text = "";
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubject.Location = new System.Drawing.Point(12, 9);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(37, 13);
            this.labelSubject.TabIndex = 4;
            this.labelSubject.Text = "Objet";
            // 
            // labelBody
            // 
            this.labelBody.AutoSize = true;
            this.labelBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBody.Location = new System.Drawing.Point(12, 123);
            this.labelBody.Name = "labelBody";
            this.labelBody.Size = new System.Drawing.Size(98, 13);
            this.labelBody.TabIndex = 6;
            this.labelBody.Text = "Contenu du mail";
            // 
            // richTextBoxSubject
            // 
            this.richTextBoxSubject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxSubject.Location = new System.Drawing.Point(12, 25);
            this.richTextBoxSubject.Multiline = false;
            this.richTextBoxSubject.Name = "richTextBoxSubject";
            this.richTextBoxSubject.Size = new System.Drawing.Size(727, 19);
            this.richTextBoxSubject.TabIndex = 0;
            this.richTextBoxSubject.Text = "";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(572, 489);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Valider";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelCc
            // 
            this.labelCc.AutoSize = true;
            this.labelCc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCc.Location = new System.Drawing.Point(12, 47);
            this.labelCc.Name = "labelCc";
            this.labelCc.Size = new System.Drawing.Size(22, 13);
            this.labelCc.TabIndex = 5;
            this.labelCc.Text = "Cc";
            // 
            // richTextBoxCC
            // 
            this.richTextBoxCC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxCC.Location = new System.Drawing.Point(12, 63);
            this.richTextBoxCC.Multiline = false;
            this.richTextBoxCC.Name = "richTextBoxCC";
            this.richTextBoxCC.Size = new System.Drawing.Size(727, 19);
            this.richTextBoxCC.TabIndex = 1;
            this.richTextBoxCC.Text = "";
            // 
            // labelCci
            // 
            this.labelCci.AutoSize = true;
            this.labelCci.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCci.Location = new System.Drawing.Point(12, 85);
            this.labelCci.Name = "labelCci";
            this.labelCci.Size = new System.Drawing.Size(25, 13);
            this.labelCci.TabIndex = 7;
            this.labelCci.Text = "Cci";
            // 
            // richTextBoxBCC
            // 
            this.richTextBoxBCC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxBCC.Location = new System.Drawing.Point(12, 101);
            this.richTextBoxBCC.Multiline = false;
            this.richTextBoxBCC.Name = "richTextBoxBCC";
            this.richTextBoxBCC.Size = new System.Drawing.Size(727, 19);
            this.richTextBoxBCC.TabIndex = 8;
            this.richTextBoxBCC.Text = "";
            // 
            // FormMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(751, 536);
            this.Controls.Add(this.richTextBoxBCC);
            this.Controls.Add(this.labelCci);
            this.Controls.Add(this.richTextBoxCC);
            this.Controls.Add(this.labelCc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBoxSubject);
            this.Controls.Add(this.labelBody);
            this.Controls.Add(this.labelSubject);
            this.Controls.Add(this.richTextBoxBody);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Personnalisation du mail";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormMail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxBody;
        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.Label labelBody;
        private System.Windows.Forms.RichTextBox richTextBoxSubject;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelCc;
        private System.Windows.Forms.RichTextBox richTextBoxCC;
        private System.Windows.Forms.Label labelCci;
        private System.Windows.Forms.RichTextBox richTextBoxBCC;
    }
}