namespace Nsa_Selection
{
    partial class FormProvince
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
            this.label_categ = new System.Windows.Forms.Label();
            this.textBox_Msg = new System.Windows.Forms.TextBox();
            this.dataGridView_Province = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_Modifier = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_Province = new System.Windows.Forms.ComboBox();
            this.button_Modifier = new System.Windows.Forms.Button();
            this.button_Supprimer = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_Ajout = new System.Windows.Forms.TextBox();
            this.button_Ajouter = new System.Windows.Forms.Button();
            this.button_Lister = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Province)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "DESIGNATION :";
            // 
            // label_categ
            // 
            this.label_categ.AutoSize = true;
            this.label_categ.ForeColor = System.Drawing.Color.Red;
            this.label_categ.Location = new System.Drawing.Point(456, 318);
            this.label_categ.Name = "label_categ";
            this.label_categ.Size = new System.Drawing.Size(0, 13);
            this.label_categ.TabIndex = 18;
            // 
            // textBox_Msg
            // 
            this.textBox_Msg.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_Msg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Msg.Location = new System.Drawing.Point(12, 275);
            this.textBox_Msg.Name = "textBox_Msg";
            this.textBox_Msg.ReadOnly = true;
            this.textBox_Msg.Size = new System.Drawing.Size(364, 13);
            this.textBox_Msg.TabIndex = 17;
            // 
            // dataGridView_Province
            // 
            this.dataGridView_Province.AllowUserToAddRows = false;
            this.dataGridView_Province.AllowUserToDeleteRows = false;
            this.dataGridView_Province.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_Province.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_Province.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Province.Location = new System.Drawing.Point(391, 108);
            this.dataGridView_Province.Name = "dataGridView_Province";
            this.dataGridView_Province.ReadOnly = true;
            this.dataGridView_Province.Size = new System.Drawing.Size(292, 187);
            this.dataGridView_Province.TabIndex = 16;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_Modifier);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.comboBox_Province);
            this.groupBox2.Controls.Add(this.button_Modifier);
            this.groupBox2.Controls.Add(this.button_Supprimer);
            this.groupBox2.Location = new System.Drawing.Point(12, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(364, 180);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "MODIFICATION ET SUPPRESSION";
            // 
            // textBox_Modifier
            // 
            this.textBox_Modifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Modifier.Location = new System.Drawing.Point(159, 97);
            this.textBox_Modifier.Name = "textBox_Modifier";
            this.textBox_Modifier.Size = new System.Drawing.Size(186, 24);
            this.textBox_Modifier.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "NOUVELLE DESIGNATION :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "SELECTIONNER :";
            // 
            // comboBox_Province
            // 
            this.comboBox_Province.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Province.FormattingEnabled = true;
            this.comboBox_Province.Location = new System.Drawing.Point(159, 18);
            this.comboBox_Province.Name = "comboBox_Province";
            this.comboBox_Province.Size = new System.Drawing.Size(186, 26);
            this.comboBox_Province.TabIndex = 2;
            // 
            // button_Modifier
            // 
            this.button_Modifier.BackColor = System.Drawing.Color.CadetBlue;
            this.button_Modifier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Modifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Modifier.Location = new System.Drawing.Point(129, 127);
            this.button_Modifier.Name = "button_Modifier";
            this.button_Modifier.Size = new System.Drawing.Size(95, 26);
            this.button_Modifier.TabIndex = 1;
            this.button_Modifier.Text = "MODIFIER";
            this.button_Modifier.UseVisualStyleBackColor = false;
            this.button_Modifier.Click += new System.EventHandler(this.button_Modifier_Click);
            // 
            // button_Supprimer
            // 
            this.button_Supprimer.BackColor = System.Drawing.Color.CadetBlue;
            this.button_Supprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Supprimer.Location = new System.Drawing.Point(129, 50);
            this.button_Supprimer.Name = "button_Supprimer";
            this.button_Supprimer.Size = new System.Drawing.Size(95, 26);
            this.button_Supprimer.TabIndex = 0;
            this.button_Supprimer.Text = "SUPPRIMER";
            this.button_Supprimer.UseVisualStyleBackColor = false;
            this.button_Supprimer.Click += new System.EventHandler(this.button_Supprimer_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_Ajout);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button_Ajouter);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 85);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AJOUT";
            // 
            // textBox_Ajout
            // 
            this.textBox_Ajout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Ajout.Location = new System.Drawing.Point(159, 19);
            this.textBox_Ajout.Name = "textBox_Ajout";
            this.textBox_Ajout.Size = new System.Drawing.Size(186, 24);
            this.textBox_Ajout.TabIndex = 2;
            // 
            // button_Ajouter
            // 
            this.button_Ajouter.BackColor = System.Drawing.Color.CadetBlue;
            this.button_Ajouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Ajouter.Location = new System.Drawing.Point(129, 49);
            this.button_Ajouter.Name = "button_Ajouter";
            this.button_Ajouter.Size = new System.Drawing.Size(95, 26);
            this.button_Ajouter.TabIndex = 0;
            this.button_Ajouter.Text = "AJOUTER";
            this.button_Ajouter.UseVisualStyleBackColor = false;
            this.button_Ajouter.Click += new System.EventHandler(this.button_Ajouter_Click);
            // 
            // button_Lister
            // 
            this.button_Lister.BackColor = System.Drawing.Color.CadetBlue;
            this.button_Lister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Lister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Lister.Location = new System.Drawing.Point(100, 25);
            this.button_Lister.Name = "button_Lister";
            this.button_Lister.Size = new System.Drawing.Size(95, 26);
            this.button_Lister.TabIndex = 9;
            this.button_Lister.Text = "LISTER";
            this.button_Lister.UseVisualStyleBackColor = false;
            this.button_Lister.Click += new System.EventHandler(this.button_Lister_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_Lister);
            this.groupBox3.Location = new System.Drawing.Point(391, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(292, 85);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "AFFICHAGE";
            // 
            // FormProvince
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 329);
            this.Controls.Add(this.label_categ);
            this.Controls.Add(this.textBox_Msg);
            this.Controls.Add(this.dataGridView_Province);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "FormProvince";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PROVINCE";
            this.Load += new System.EventHandler(this.FormProvince_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Province)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_categ;
        private System.Windows.Forms.TextBox textBox_Msg;
        private System.Windows.Forms.DataGridView dataGridView_Province;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_Modifier;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_Province;
        private System.Windows.Forms.Button button_Modifier;
        private System.Windows.Forms.Button button_Supprimer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_Ajout;
        private System.Windows.Forms.Button button_Ajouter;
        private System.Windows.Forms.Button button_Lister;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}