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
    public partial class FormSelection : Form
    {
        WCFSqlAccessSVC.WCFSqlAccessClient cl = new WCFSqlAccessSVC.WCFSqlAccessClient();
        SqlDataReader dr;
        SqlConnection con;
        SqlCommand cmd;
        string n, p, _connectionStr;
        int _idCand, CMa,CFr;
        DataSet _ds;

        public FormSelection()
        {
            _connectionStr = "server=LENOVO;database=Nsa_DB;trusted_connection=yes";
            InitializeComponent();
        }

        private void impressionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void testConnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cl.checkConnection(_connectionStr));
        }

        private void FormSelection_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void aProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAide fa = new FormAide();
            fa.ShowDialog();
        }

        private void aideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo("C:\\Users\\LENOVO PC\\Documents\\Documents\\Cours_thermo_1er_semestre.pdf", "");
            System.Diagnostics.Process.Start(psi);
        }

        private void provinceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProvince fp = new FormProvince();
            fp.ShowDialog();
        }

        private void ajoutCandidatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAjoutCandidat fac = new FormAjoutCandidat();
            fac.ShowDialog();
        }

        private void modifierCandidatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormModifCandidat fmc = new FormModifCandidat();
            fmc.ShowDialog();
        }

        private void supprimerCandidatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSupCandidat fsc = new FormSupCandidat();
            fsc.ShowDialog();
        }

        void LoadCombo()
        {
            _ds = cl.getDataSet(_connectionStr, "select * from Candidats_Inscrits order by nom");

            comboBox_Candidat.DataSource = _ds.Tables[0];
            comboBox_Candidat.ValueMember = "nom";
            comboBox_Candidat.Text = "";

        }

        private void FormSelection_Load(object sender, EventArgs e)
        {
            LoadCombo();
        }

        private void comboBox_Candidat_SelectedIndexChanged(object sender, EventArgs e)
        {
            _idCand = 0;

            int index = comboBox_Candidat.SelectedIndex;

            try
            {
                _idCand = (int)_ds.Tables[0].Rows[index]["id"];
                textBox_IDCand.Text = _idCand.ToString();
            }
            catch
            {
                MessageBox.Show(_idCand.ToString());
            }
        }

        private void button_Inserer_Click(object sender, EventArgs e)
        {
           // int IDDB = cl.getIntFromDataBase(_connectionStr, "select IDCandidat from Test where IDCandidat = '" + _idCand + "'", "IDCandidat", 0);

            CFr = Convert.ToInt32(textBox_CotFra.Text);
            CMa = Convert.ToInt32(textBox_CotMat.Text);

            if (textBox_CotFra.Text != "" && textBox_CotMat.Text != "" && CFr <= 20 && CMa <= 20)
            {
                try
                {
                    DataSet ds = cl.getDataSet(_connectionStr, "INSERT INTO Test(IDCandidat,CoteFrancais,CoteMath) VALUES ('" + _idCand + "','" + CFr + "','"+ CMa +"')");

                    MessageBox.Show("Test réalisé!");

                    textBox_CotFra.Text = "";
                    textBox_CotMat.Text = "";
                    textBox_IDCand.Text = "";
                    comboBox_Candidat.Text = "";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Le test s'est déjà passé! ou les données sont mal entrées");

                textBox_CotFra.Text = "";
                textBox_CotMat.Text = "";
                textBox_IDCand.Text = "";
                comboBox_Candidat.Text = "";
            }
        }

        private void button_Afficher_Click(object sender, EventArgs e)
        {
            loadActu();
        }

        private void button_Actualiser_Click(object sender, EventArgs e)
        {
            LoadCombo();
            loadActu();
        }

        void loadActu()
        {
            //DataSet dslA = cl.getDataSet(_connectionStr, "SELECT TOP (100) PERCENT dbo.Candidats_Inscrits.Nom AS NOM, dbo.Candidats_Inscrits.Postnom AS POSTNOM, dbo.Test.CoteFrancais AS FRANCAIS, dbo.Test.CoteMath AS MATHEMATIQUES FROM dbo.Candidats_Inscrits INNER JOIN dbo.Test ON dbo.Candidats_Inscrits.ID = dbo.Test.IDCandidat WHERE (dbo.Test.CoteFrancais >= 10) AND (dbo.Test.CoteMath >= 6) ORDER BY dbo.Candidats_Inscrits.Nom");
            DataSet dslA = cl.getDataSet(_connectionStr, "  SELECT TOP (100) PERCENT dbo.Candidats_Inscrits.Nom AS NOM, dbo.Candidats_Inscrits.Postnom AS POSTNOM, dbo.Test.CoteFrancais AS FRANCAIS, dbo.Test.CoteMath AS MATH FROM dbo.Candidats_Inscrits INNER JOIN dbo.Test ON dbo.Candidats_Inscrits.ID = dbo.Test.ID WHERE (dbo.Test.CoteFrancais >= 10) AND (dbo.Test.CoteMath >= 6) ORDER BY NOM");
            try
            {
                dataGridView_CandAd.DataSource = dslA.Tables[0];
            }
            catch (Exception ex)
            {
                dataGridView_CandAd.DataSource = null;

                textBox_Msg.Text = ex.Message;///"Erreur à la DB";
               
            }
        }

        
    }
}
