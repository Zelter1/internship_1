namespace Mail_Detector
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonSendManyFiles = new System.Windows.Forms.Button();
            this.checkBoxTop = new System.Windows.Forms.CheckBox();
            this.checkBoxAutoSend = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mailToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.personnalisationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSendManyFiles
            // 
            this.buttonSendManyFiles.BackColor = System.Drawing.Color.White;
            this.buttonSendManyFiles.Location = new System.Drawing.Point(22, 65);
            this.buttonSendManyFiles.Name = "buttonSendManyFiles";
            this.buttonSendManyFiles.Size = new System.Drawing.Size(210, 41);
            this.buttonSendManyFiles.TabIndex = 1;
            this.buttonSendManyFiles.Text = "Envoi d\'une ou plusieurs factures";
            this.buttonSendManyFiles.UseVisualStyleBackColor = false;
            this.buttonSendManyFiles.Click += new System.EventHandler(this.buttonSendManyFiles_Click);
            // 
            // checkBoxTop
            // 
            this.checkBoxTop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxTop.AutoSize = true;
            this.checkBoxTop.Location = new System.Drawing.Point(330, 133);
            this.checkBoxTop.Name = "checkBoxTop";
            this.checkBoxTop.Size = new System.Drawing.Size(45, 17);
            this.checkBoxTop.TabIndex = 0;
            this.checkBoxTop.Text = "Top";
            this.checkBoxTop.UseVisualStyleBackColor = true;
            this.checkBoxTop.CheckedChanged += new System.EventHandler(this.checkBoxTop_CheckedChanged);
            // 
            // checkBoxAutoSend
            // 
            this.checkBoxAutoSend.AutoSize = true;
            this.checkBoxAutoSend.Location = new System.Drawing.Point(238, 78);
            this.checkBoxAutoSend.Name = "checkBoxAutoSend";
            this.checkBoxAutoSend.Size = new System.Drawing.Size(114, 17);
            this.checkBoxAutoSend.TabIndex = 2;
            this.checkBoxAutoSend.Text = "Envoi automatique";
            this.checkBoxAutoSend.UseVisualStyleBackColor = true;
            this.checkBoxAutoSend.CheckedChanged += new System.EventHandler(this.checkBoxAutoSend_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mailToolStripMenuItem1,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(375, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mailToolStripMenuItem1
            // 
            this.mailToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personnalisationToolStripMenuItem});
            this.mailToolStripMenuItem1.Name = "mailToolStripMenuItem1";
            this.mailToolStripMenuItem1.Size = new System.Drawing.Size(42, 20);
            this.mailToolStripMenuItem1.Text = "Mail";
            // 
            // personnalisationToolStripMenuItem
            // 
            this.personnalisationToolStripMenuItem.Name = "personnalisationToolStripMenuItem";
            this.personnalisationToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.personnalisationToolStripMenuItem.Text = "Personnalisation";
            this.personnalisationToolStripMenuItem.Click += new System.EventHandler(this.personnalisationToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurationToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.configurationToolStripMenuItem.Text = "Configuration";
            this.configurationToolStripMenuItem.Click += new System.EventHandler(this.configurationToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(375, 155);
            this.Controls.Add(this.checkBoxAutoSend);
            this.Controls.Add(this.checkBoxTop);
            this.Controls.Add(this.buttonSendManyFiles);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mail Detector";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSendManyFiles;
        private System.Windows.Forms.CheckBox checkBoxTop;
        private System.Windows.Forms.CheckBox checkBoxAutoSend;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        protected internal System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mailToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem personnalisationToolStripMenuItem;
    }
}