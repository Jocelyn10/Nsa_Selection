namespace Nsa_Selection
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.button_Ouvrir = new System.Windows.Forms.Button();
            this.button_Quitter = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(463, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "BIENVENUE DANS GES_SELECTION  v1.0";
            // 
            // button_Ouvrir
            // 
            this.button_Ouvrir.BackColor = System.Drawing.Color.CadetBlue;
            this.button_Ouvrir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Ouvrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Ouvrir.Location = new System.Drawing.Point(198, 210);
            this.button_Ouvrir.Name = "button_Ouvrir";
            this.button_Ouvrir.Size = new System.Drawing.Size(95, 26);
            this.button_Ouvrir.TabIndex = 3;
            this.button_Ouvrir.Text = "OUVRIR";
            this.button_Ouvrir.UseVisualStyleBackColor = false;
            this.button_Ouvrir.Click += new System.EventHandler(this.button_Ouvrir_Click);
            // 
            // button_Quitter
            // 
            this.button_Quitter.BackColor = System.Drawing.Color.CadetBlue;
            this.button_Quitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Quitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Quitter.Location = new System.Drawing.Point(431, 256);
            this.button_Quitter.Name = "button_Quitter";
            this.button_Quitter.Size = new System.Drawing.Size(95, 26);
            this.button_Quitter.TabIndex = 4;
            this.button_Quitter.Text = "QUITTER";
            this.button_Quitter.UseVisualStyleBackColor = false;
            this.button_Quitter.Click += new System.EventHandler(this.button_Quitter_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(161, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 138);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(158, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(214, 30);
            this.label8.TabIndex = 22;
            this.label8.Text = "© Aout 2016 tous droits reservés\r\n\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(538, 319);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_Quitter);
            this.Controls.Add(this.button_Ouvrir);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ACCUEIL";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Ouvrir;
        private System.Windows.Forms.Button button_Quitter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
    }
}

