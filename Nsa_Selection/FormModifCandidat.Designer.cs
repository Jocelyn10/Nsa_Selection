namespace Nsa_Selection
{
    partial class FormModifCandidat
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
            this.textBox_Msg = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView_ModifCand = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ModifCand)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_Msg
            // 
            this.textBox_Msg.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_Msg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Msg.Location = new System.Drawing.Point(12, 313);
            this.textBox_Msg.Multiline = true;
            this.textBox_Msg.Name = "textBox_Msg";
            this.textBox_Msg.Size = new System.Drawing.Size(814, 26);
            this.textBox_Msg.TabIndex = 53;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView_ModifCand);
            this.groupBox2.Location = new System.Drawing.Point(12, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(814, 274);
            this.groupBox2.TabIndex = 52;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "MODIFICATION";
            // 
            // dataGridView_ModifCand
            // 
            this.dataGridView_ModifCand.AllowUserToAddRows = false;
            this.dataGridView_ModifCand.AllowUserToDeleteRows = false;
            this.dataGridView_ModifCand.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_ModifCand.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_ModifCand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ModifCand.Location = new System.Drawing.Point(20, 19);
            this.dataGridView_ModifCand.Name = "dataGridView_ModifCand";
            this.dataGridView_ModifCand.Size = new System.Drawing.Size(775, 235);
            this.dataGridView_ModifCand.TabIndex = 25;
            this.dataGridView_ModifCand.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_ModifCand_CellValueChanged);
            this.dataGridView_ModifCand.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_ModifCand_RowHeaderMouseClick);
            this.dataGridView_ModifCand.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView_ModifCand_MouseClick);
            // 
            // FormModifCandidat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 362);
            this.Controls.Add(this.textBox_Msg);
            this.Controls.Add(this.groupBox2);
            this.Name = "FormModifCandidat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MODIFICATION";
            this.Load += new System.EventHandler(this.FormModifCandidat_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ModifCand)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Msg;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView_ModifCand;
    }
}