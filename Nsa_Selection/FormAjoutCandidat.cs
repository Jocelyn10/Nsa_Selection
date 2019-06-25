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
    public partial class FormAjoutCandidat : Form
    {
        WCFSqlAccessSVC.WCFSqlAccessClient cl = new WCFSqlAccessSVC.WCFSqlAccessClient();
        string sexe = "";
        string _connectionStr;
        bool etatList;
        int _idProv;
        DataSet dsP, dsL;

        public FormAjoutCandidat()
        {
            _connectionStr = "server=LENOVO;database=Nsa_DB;trusted_connection=yes";
            InitializeComponent();
        }

        private void button_Inserer_Click(object sender, EventArgs e)
        {
            if (radioButton_Femme.Checked)
            {
                sexe = "F";
            }
            else
            {
                sexe = "H";
            }

            string NomCandidat = textBox_Nom.Text.Trim().ToUpper();
            string PrenomCandidat = textBox_Prenom.Text.Trim().ToUpper();
            string foundNC = cl.getTextFromDataBase(_connectionStr, "select * from Candidats_Inscrits where Nom = '" + NomCandidat + "'", "Nom", "");
            string foundPC = cl.getTextFromDataBase(_connectionStr, "select * from Candidats_Inscrits where Prenom = '" + PrenomCandidat + "'", "Prenom", "");

            try
            {
                if (NomCandidat.Length > 0 && PrenomCandidat.Length > 0 && foundNC != NomCandidat && foundPC != PrenomCandidat && sexe != "" && textBox_IDProv.Text != "" && textBox_DateDeNaissance.Text != "" && textBox_VilleDeNaissance.Text != "" && textBox_Ecole.Text != "")
                {
                    DataSet ds = cl.getDataSet(_connectionStr, "INSERT INTO Candidats_Inscrits(NOM,POSTNOM,PRENOM,SEXE,DateDeNaissance,VilleDeNaissance,IDProvince,EcoleDorigine) VALUES('" + textBox_Nom.Text.ToUpper() + "','" + textBox_PostNom.Text.ToUpper() + "','" + textBox_Prenom.Text.ToUpper() + "','" + sexe + "','" + textBox_DateDeNaissance.Text + "','" + textBox_VilleDeNaissance.Text + "','" + _idProv + "','" + textBox_Ecole.Text.ToUpper() + "')");

                    if (etatList == true)
                    {
                        AfficheDateGried();
                    }

                    MessageBox.Show("Candidat inscrit !");
                    textBox_Nom.Text = "";
                    textBox_PostNom.Text = "";
                    textBox_Prenom.Text = "";
                    sexe = "";
                    textBox_IDProv.Text = "";
                    textBox_DateDeNaissance.Text = "";
                    textBox_VilleDeNaissance.Text = "";
                    textBox_Ecole.Text = "";
                    comboBox_Province.Text = "";
                }
                else
                {
                    MessageBox.Show("Remplissez les champs obligatoires ou le candidat est déjà inscrit");
                }
            }
            catch
            {
                MessageBox.Show(" Données mal saisies!!! ");
            }
        }

        private void comboBox_Province_SelectedIndexChanged(object sender, EventArgs e)
        {
            dsP = cl.getDataSet(_connectionStr, "select * from Province");
            _idProv = 0;

            int index = comboBox_Province.SelectedIndex;

            try
            {
                _idProv = (int)dsP.Tables[0].Rows[index]["id"];
                textBox_IDProv.Text = _idProv.ToString();
            }
            catch
            {
                MessageBox.Show("Error");
            }     
        }

        private void loadCombo()
        {
            dsL = cl.getDataSet(_connectionStr, "select * from Province");
            try
            {
                comboBox_Province.DataSource = dsL.Tables[0];
                comboBox_Province.ValueMember = "Designation";
            }
            catch
            {
                MessageBox.Show("Erreur !");
            }
        }

        private void FormAjoutCandidat_Load(object sender, EventArgs e)
        {
            loadCombo();
            if (etatList == true)
            {
                AfficheDateGried();
            }
        }

        void AfficheDateGried()
        {
           
            DataSet dsA = cl.getDataSet(_connectionStr, "SELECT * FROM Candidats_Inscrits");

            try
            {
                dataGridView_InsererCand.DataSource = dsA.Tables[0];
            }
            catch (Exception ex)
            {
                dataGridView_InsererCand.DataSource = null;

                MessageBox.Show(ex.Message); //"Erreur à la DB"
            }

        }

        private void button_Etat_Click(object sender, EventArgs e)
        {   
            AfficheDateGried();
            etatList = true;
        }
    }
}
