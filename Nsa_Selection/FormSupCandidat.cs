using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Nsa_Selection
{
    public partial class FormSupCandidat : Form
    {
        WCFSqlAccessSVC.WCFSqlAccessClient cl = new WCFSqlAccessSVC.WCFSqlAccessClient();
        SqlDataReader dr;
        SqlConnection con;
        SqlCommand cmd;
        string n, p, _connectionStr;

        public FormSupCandidat()
        {
            _connectionStr = "server=LENOVO;database=Nsa_DB;trusted_connection=yes";
            InitializeComponent();
        }

        void LoadCombo()
        {
            con = new SqlConnection("server=LENOVO;database=Nsa_DB;trusted_connection=yes");
            cmd = new SqlCommand("", con);

            con.Open();
            cmd.CommandText = "select nom, prenom from Candidats_Inscrits order by nom";
            dr = cmd.ExecuteReader();
            while (dr.Read())
                comboBox_SupAb.Items.Add(dr[0] + " " + dr[1]);
            con.Close();

        }

        void loadCandidat()
        {
            DataSet dsA = cl.getDataSet(_connectionStr, "select * from Candidats_Inscrits order by nom");

            try
            {
                dataGridView_SupCand.DataSource = dsA.Tables[0];
            }
            catch (Exception ex)
            {
                dataGridView_SupCand.DataSource = null;

                MessageBox.Show(ex.Message); //"Erreur à la DB"
            }

        }

        private void FormSupCandidat_Load(object sender, EventArgs e)
        {
            loadCandidat();
            LoadCombo();
        }

        private void button_Supprimer_Click(object sender, EventArgs e)
        {
            if (textBox_Nom.Text != "" && textBox_Prenom.Text != "")
            {
                try
                {
                    DataSet ds = cl.getDataSet(_connectionStr, "delete from Candidats_Inscrits where nom ='" + n + "' and prenom ='" + p + "'");
                    MessageBox.Show("Candidat Supprimé !");
                    textBox_Nom.Text = "";
                    textBox_Prenom.Text = "";
                    comboBox_SupAb.Text = "";
                    loadCandidat();
                    LoadCombo();
                }
                catch
                {
                    MessageBox.Show("Erreur !");
                }
            }
            else
            {
                MessageBox.Show("Selectionnez un candidat, svp !");
            }
        }

        private void comboBox_SupAb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string r = comboBox_SupAb.SelectedItem.ToString();
            n = r.Substring(0, comboBox_SupAb.Text.IndexOf(" "));
            p = r.Substring(comboBox_SupAb.Text.IndexOf(" ") + 1);
            textBox_Nom.Text = n;
            textBox_Prenom.Text = p;
        }
    }
}
