namespace Nsa_Selection
{
    partial class FormSelection
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.impressionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inscriptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajoutCandidatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierCandidatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerCandidatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.provinceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paramètresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_Candidat = new System.Windows.Forms.ComboBox();
            this.textBox_CotFra = new System.Windows.Forms.TextBox();
            this.textBox_CotMat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Actualiser = new System.Windows.Forms.Button();
            this.button_Afficher = new System.Windows.Forms.Button();
            this.dataGridView_CandAd = new System.Windows.Forms.DataGridView();
            this.textBox_IDCand = new System.Windows.Forms.TextBox();
            this.button_Inserer = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_Msg = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CandAd)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.editerToolStripMenuItem,
            this.paramètresToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(962, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.impressionToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // impressionToolStripMenuItem
            // 
            this.impressionToolStripMenuItem.Name = "impressionToolStripMenuItem";
            this.impressionToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.impressionToolStripMenuItem.Text = "Quitter";
            this.impressionToolStripMenuItem.Click += new System.EventHandler(this.impressionToolStripMenuItem_Click);
            // 
            // editerToolStripMenuItem
            // 
            this.editerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inscriptionToolStripMenuItem,
            this.provinceToolStripMenuItem});
            this.editerToolStripMenuItem.Name = "editerToolStripMenuItem";
            this.editerToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.editerToolStripMenuItem.Text = "Editer";
            // 
            // inscriptionToolStripMenuItem
            // 
            this.inscriptionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajoutCandidatToolStripMenuItem,
            this.modifierCandidatToolStripMenuItem,
            this.supprimerCandidatToolStripMenuItem});
            this.inscriptionToolStripMenuItem.Name = "inscriptionToolStripMenuItem";
            this.inscriptionToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.inscriptionToolStripMenuItem.Text = "Inscription";
            // 
            // ajoutCandidatToolStripMenuItem
            // 
            this.ajoutCandidatToolStripMenuItem.Name = "ajoutCandidatToolStripMenuItem";
            this.ajoutCandidatToolStripMenuItem.Size = new System.Drawing.Size(218, 24);
            this.ajoutCandidatToolStripMenuItem.Text = "Ajout Candidat";
            this.ajoutCandidatToolStripMenuItem.Click += new System.EventHandler(this.ajoutCandidatToolStripMenuItem_Click);
            // 
            // modifierCandidatToolStripMenuItem
            // 
            this.modifierCandidatToolStripMenuItem.Name = "modifierCandidatToolStripMenuItem";
            this.modifierCandidatToolStripMenuItem.Size = new System.Drawing.Size(218, 24);
            this.modifierCandidatToolStripMenuItem.Text = "Modifier Candidat";
            this.modifierCandidatToolStripMenuItem.Click += new System.EventHandler(this.modifierCandidatToolStripMenuItem_Click);
            // 
            // supprimerCandidatToolStripMenuItem
            // 
            this.supprimerCandidatToolStripMenuItem.Name = "supprimerCandidatToolStripMenuItem";
            this.supprimerCandidatToolStripMenuItem.Size = new System.Drawing.Size(218, 24);
            this.supprimerCandidatToolStripMenuItem.Text = "Supprimer Candidat";
            this.supprimerCandidatToolStripMenuItem.Click += new System.EventHandler(this.supprimerCandidatToolStripMenuItem_Click);
            // 
            // provinceToolStripMenuItem
            // 
            this.provinceToolStripMenuItem.Name = "provinceToolStripMenuItem";
            this.provinceToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.provinceToolStripMenuItem.Text = "Province";
            this.provinceToolStripMenuItem.Click += new System.EventHandler(this.provinceToolStripMenuItem_Click);
            // 
            // paramètresToolStripMenuItem
            // 
            this.paramètresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testConnectionToolStripMenuItem});
            this.paramètresToolStripMenuItem.Name = "paramètresToolStripMenuItem";
            this.paramètresToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.paramètresToolStripMenuItem.Text = "Paramètres";
            // 
            // testConnectionToolStripMenuItem
            // 
            this.testConnectionToolStripMenuItem.Name = "testConnectionToolStripMenuItem";
            this.testConnectionToolStripMenuItem.Size = new System.Drawing.Size(186, 24);
            this.testConnectionToolStripMenuItem.Text = "Test Connection";
            this.testConnectionToolStripMenuItem.Click += new System.EventHandler(this.testConnectionToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aideToolStripMenuItem,
            this.aProposToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(28, 24);
            this.toolStripMenuItem1.Text = "?";
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.aideToolStripMenuItem.Text = "Aide";
            this.aideToolStripMenuItem.Click += new System.EventHandler(this.aideToolStripMenuItem_Click);
            // 
            // aProposToolStripMenuItem
            // 
            this.aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            this.aProposToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.aProposToolStripMenuItem.Text = "A propos";
            this.aProposToolStripMenuItem.Click += new System.EventHandler(this.aProposToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "SELECTIONNEZ UN CANDIDAT INSCRIT :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(519, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "COTE EN MATHEMATIQUES* :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "COTE EN FRANÇAIS* :";
            // 
            // comboBox_Candidat
            // 
            this.comboBox_Candidat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Candidat.FormattingEnabled = true;
            this.comboBox_Candidat.Location = new System.Drawing.Point(502, 122);
            this.comboBox_Candidat.Name = "comboBox_Candidat";
            this.comboBox_Candidat.Size = new System.Drawing.Size(289, 26);
            this.comboBox_Candidat.TabIndex = 4;
            this.comboBox_Candidat.SelectedIndexChanged += new System.EventHandler(this.comboBox_Candidat_SelectedIndexChanged);
            // 
            // textBox_CotFra
            // 
            this.textBox_CotFra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CotFra.Location = new System.Drawing.Point(385, 156);
            this.textBox_CotFra.Name = "textBox_CotFra";
            this.textBox_CotFra.Size = new System.Drawing.Size(100, 24);
            this.textBox_CotFra.TabIndex = 5;
            // 
            // textBox_CotMat
            // 
            this.textBox_CotMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CotMat.Location = new System.Drawing.Point(691, 156);
            this.textBox_CotMat.Name = "textBox_CotMat";
            this.textBox_CotMat.Size = new System.Drawing.Size(100, 24);
            this.textBox_CotMat.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(252, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "* La cote maximale est 20";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_Actualiser);
            this.groupBox1.Controls.Add(this.button_Afficher);
            this.groupBox1.Controls.Add(this.dataGridView_CandAd);
            this.groupBox1.Location = new System.Drawing.Point(252, 243);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(700, 273);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LISTE DES CANDIDATS ADMIS";
            // 
            // button_Actualiser
            // 
            this.button_Actualiser.BackColor = System.Drawing.Color.CadetBlue;
            this.button_Actualiser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Actualiser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Actualiser.Location = new System.Drawing.Point(184, 19);
            this.button_Actualiser.Name = "button_Actualiser";
            this.button_Actualiser.Size = new System.Drawing.Size(95, 26);
            this.button_Actualiser.TabIndex = 17;
            this.button_Actualiser.Text = "ACTUALISER";
            this.button_Actualiser.UseVisualStyleBackColor = false;
            this.button_Actualiser.Click += new System.EventHandler(this.button_Actualiser_Click);
            // 
            // button_Afficher
            // 
            this.button_Afficher.BackColor = System.Drawing.Color.CadetBlue;
            this.button_Afficher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Afficher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Afficher.Location = new System.Drawing.Point(380, 19);
            this.button_Afficher.Name = "button_Afficher";
            this.button_Afficher.Size = new System.Drawing.Size(95, 26);
            this.button_Afficher.TabIndex = 16;
            this.button_Afficher.Text = "AFFICHER";
            this.button_Afficher.UseVisualStyleBackColor = false;
            this.button_Afficher.Click += new System.EventHandler(this.button_Afficher_Click);
            // 
            // dataGridView_CandAd
            // 
            this.dataGridView_CandAd.AllowUserToAddRows = false;
            this.dataGridView_CandAd.AllowUserToDeleteRows = false;
            this.dataGridView_CandAd.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_CandAd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_CandAd.Location = new System.Drawing.Point(62, 61);
            this.dataGridView_CandAd.Name = "dataGridView_CandAd";
            this.dataGridView_CandAd.ReadOnly = true;
            this.dataGridView_CandAd.Size = new System.Drawing.Size(545, 192);
            this.dataGridView_CandAd.TabIndex = 0;
            // 
            // textBox_IDCand
            // 
            this.textBox_IDCand.Location = new System.Drawing.Point(812, 203);
            this.textBox_IDCand.Name = "textBox_IDCand";
            this.textBox_IDCand.Size = new System.Drawing.Size(60, 20);
            this.textBox_IDCand.TabIndex = 14;
            this.textBox_IDCand.Visible = false;
            // 
            // button_Inserer
            // 
            this.button_Inserer.BackColor = System.Drawing.Color.CadetBlue;
            this.button_Inserer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Inserer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Inserer.Location = new System.Drawing.Point(837, 136);
            this.button_Inserer.Name = "button_Inserer";
            this.button_Inserer.Size = new System.Drawing.Size(95, 26);
            this.button_Inserer.TabIndex = 15;
            this.button_Inserer.Text = "INSERER";
            this.button_Inserer.UseVisualStyleBackColor = false;
            this.button_Inserer.Click += new System.EventHandler(this.button_Inserer_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.richTextBox2.Location = new System.Drawing.Point(0, 94);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(225, 459);
            this.richTextBox2.TabIndex = 16;
            this.richTextBox2.Text = "";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.richTextBox1.Location = new System.Drawing.Point(-60, 28);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(1073, 77);
            this.richTextBox1.TabIndex = 17;
            this.richTextBox1.Text = "";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(752, 40);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(804, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "GES_SELECTION v1.0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label8.Location = new System.Drawing.Point(37, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "en toute simplicité";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label9.Location = new System.Drawing.Point(55, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "érer la sélection des étudiants \r\n";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(24, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 37);
            this.label10.TabIndex = 20;
            this.label10.Text = "G";
            // 
            // textBox_Msg
            // 
            this.textBox_Msg.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_Msg.Location = new System.Drawing.Point(255, 523);
            this.textBox_Msg.Name = "textBox_Msg";
            this.textBox_Msg.Size = new System.Drawing.Size(100, 20);
            this.textBox_Msg.TabIndex = 23;
            // 
            // FormSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 544);
            this.Controls.Add(this.textBox_Msg);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.button_Inserer);
            this.Controls.Add(this.textBox_IDCand);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_CotMat);
            this.Controls.Add(this.textBox_CotFra);
            this.Controls.Add(this.comboBox_Candidat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSelection_FormClosing);
            this.Load += new System.EventHandler(this.FormSelection_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CandAd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem impressionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inscriptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem provinceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paramètresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testConnectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajoutCandidatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierCandidatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerCandidatToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_Candidat;
        private System.Windows.Forms.TextBox textBox_CotFra;
        private System.Windows.Forms.TextBox textBox_CotMat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView_CandAd;
        private System.Windows.Forms.TextBox textBox_IDCand;
        private System.Windows.Forms.Button button_Inserer;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button_Afficher;
        private System.Windows.Forms.TextBox textBox_Msg;
        private System.Windows.Forms.Button button_Actualiser;
    }
}