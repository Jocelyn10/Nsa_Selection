namespace Nsa_Selection
{
    partial class FormSupCandidat
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView_SupCand = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_Prenom = new System.Windows.Forms.TextBox();
            this.textBox_Nom = new System.Windows.Forms.TextBox();
            this.button_Supprimer = new System.Windows.Forms.Button();
            this.comboBox_SupAb = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SupCand)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "NOM :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView_SupCand);
            this.groupBox2.Location = new System.Drawing.Point(15, 141);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(743, 274);
            this.groupBox2.TabIndex = 55;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LISTE";
            // 
            // dataGridView_SupCand
            // 
            this.dataGridView_SupCand.AllowUserToAddRows = false;
            this.dataGridView_SupCand.AllowUserToDeleteRows = false;
            this.dataGridView_SupCand.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_SupCand.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_SupCand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_SupCand.Location = new System.Drawing.Point(20, 19);
            this.dataGridView_SupCand.Name = "dataGridView_SupCand";
            this.dataGridView_SupCand.Size = new System.Drawing.Size(694, 235);
            this.dataGridView_SupCand.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "PRENOM :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_Prenom);
            this.groupBox1.Controls.Add(this.textBox_Nom);
            this.groupBox1.Controls.Add(this.button_Supprimer);
            this.groupBox1.Controls.Add(this.comboBox_SupAb);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(742, 105);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SUPPRESSION";
            // 
            // textBox_Prenom
            // 
            this.textBox_Prenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Prenom.Location = new System.Drawing.Point(340, 64);
            this.textBox_Prenom.Name = "textBox_Prenom";
            this.textBox_Prenom.ReadOnly = true;
            this.textBox_Prenom.Size = new System.Drawing.Size(185, 24);
            this.textBox_Prenom.TabIndex = 3;
            // 
            // textBox_Nom
            // 
            this.textBox_Nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Nom.Location = new System.Drawing.Point(60, 63);
            this.textBox_Nom.Name = "textBox_Nom";
            this.textBox_Nom.ReadOnly = true;
            this.textBox_Nom.Size = new System.Drawing.Size(189, 24);
            this.textBox_Nom.TabIndex = 2;
            // 
            // button_Supprimer
            // 
            this.button_Supprimer.BackColor = System.Drawing.Color.CadetBlue;
            this.button_Supprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Supprimer.Location = new System.Drawing.Point(582, 36);
            this.button_Supprimer.Name = "button_Supprimer";
            this.button_Supprimer.Size = new System.Drawing.Size(95, 26);
            this.button_Supprimer.TabIndex = 1;
            this.button_Supprimer.Text = "SUPPRIMER";
            this.button_Supprimer.UseVisualStyleBackColor = false;
            this.button_Supprimer.Click += new System.EventHandler(this.button_Supprimer_Click);
            // 
            // comboBox_SupAb
            // 
            this.comboBox_SupAb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_SupAb.FormattingEnabled = true;
            this.comboBox_SupAb.Location = new System.Drawing.Point(19, 20);
            this.comboBox_SupAb.Name = "comboBox_SupAb";
            this.comboBox_SupAb.Size = new System.Drawing.Size(506, 26);
            this.comboBox_SupAb.TabIndex = 0;
            this.comboBox_SupAb.SelectedIndexChanged += new System.EventHandler(this.comboBox_SupAb_SelectedIndexChanged);
            // 
            // FormSupCandidat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 430);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormSupCandidat";
            this.Text = "SUPPRESSION";
            this.Load += new System.EventHandler(this.FormSupCandidat_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SupCand)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView_SupCand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_Prenom;
        private System.Windows.Forms.TextBox textBox_Nom;
        private System.Windows.Forms.Button button_Supprimer;
        private System.Windows.Forms.ComboBox comboBox_SupAb;
    }
}