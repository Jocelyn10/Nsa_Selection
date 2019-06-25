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
    public partial class FormProvince : Form
    {
        WCFSqlAccessSVC.WCFSqlAccessClient cl = new WCFSqlAccessSVC.WCFSqlAccessClient();
        DataSet _dsProvince;
        bool etatList;
        string _connectionStr;

        public FormProvince()
        {
            _connectionStr = "server=LENOVO;database=Nsa_DB;trusted_connection=yes";
            InitializeComponent();
        }

        private void button_Ajouter_Click(object sender, EventArgs e)
        {
            string Prov = textBox_Ajout.Text.Trim().ToUpper();

            try
            {

                if (Prov.Length > 0)
                {
                    string fcatg = cl.getTextFromDataBase(_connectionStr, "select * from Province where designation = '" + Prov + "'", "designation", "");

                    if (fcatg.Length == 0)
                    {
                        cl.executeNonQuery(_connectionStr, "insert into Province (designation) values ('" + Prov + "')");

                        if (etatList == true)
                        {
                            actualiserListe();
                        }

                        MessageBox.Show("Provincee ajoutée !");
                        loadProvince();
                        textBox_Ajout.Text = "";
                    }
                    else
                    {
                        Console.Beep();
                        Console.Beep();
                    }
                }
            }
            catch
            {
                textBox_Msg.Text = " Données mal saisies!!! ";
            }
        
        }

        private void FormProvince_Load(object sender, EventArgs e)
        {
           // loadProvince();
        }

        private void button_Supprimer_Click(object sender, EventArgs e)
        {
            string Prov = comboBox_Province.Text.Trim().ToUpper();

            string foundProv = cl.getTextFromDataBase(_connectionStr, "select * from Province where designation = '" + Prov + "'", "designation", "");

            if (Prov.Length > 0 && foundProv == Prov)
            {
                string res = cl.executeNonQuery(_connectionStr, "delete Province where designation = '" + Prov + "'");

                MessageBox.Show("Province supprimée !");

                if (res != "ok")
                    MessageBox.Show(res);
            }

            loadProvince();

            if (etatList == true)
            {
                actualiserListe();
            }
        }

        private void loadProvince()
        {

            _dsProvince = cl.getDataSet(_connectionStr, "select * from Province order by designation");

            comboBox_Province.DataSource = _dsProvince.Tables[0];
            comboBox_Province.ValueMember = "designation";
            comboBox_Province.Text = "";
        }

        private void button_Modifier_Click(object sender, EventArgs e)
        {
            string nouvelleDesignation = textBox_Modifier.Text.Trim().ToUpper();
            try
            {
                if (textBox_Modifier.Text != "")
                {

                    cl.executeNonQuery(_connectionStr, "update Province set Designation = '" + nouvelleDesignation + "' where Designation = '" + comboBox_Province.Text + "'");

                    if (etatList == true)
                    {
                        actualiserListe();
                    }

                    MessageBox.Show("Modification effectuée !");
                    loadProvince();
                    textBox_Modifier.Text = "";
                }
                else
                {
                    MessageBox.Show(" Ecrivez une nouvelle désignation, svp !");
                }
            }
            catch
            {
                MessageBox.Show("Une erreur s'est produite", "Alerte", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void actualiserListe()
        {
            DataSet ds = cl.getDataSet(_connectionStr, "select * from Province");

            try
            {
                dataGridView_Province.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                dataGridView_Province.DataSource = null;

                textBox_Msg.Text = ex.Message;///"Erreur à la DB";
            }
        }

        private void button_Lister_Click(object sender, EventArgs e)
        {
            actualiserListe();
            etatList = true;
        }

    }
}
