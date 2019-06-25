using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nsa_Selection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Ouvrir_Click(object sender, EventArgs e)
        {
            FormSelection fs = new FormSelection();
            fs.ShowDialog();
            this.Hide();
        }

        private void button_Quitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
