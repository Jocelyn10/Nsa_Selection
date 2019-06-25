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
    public partial class FormModifCandidat : Form
    {
        WCFSqlAccessSVC.WCFSqlAccessClient cl = new WCFSqlAccessSVC.WCFSqlAccessClient();
        public int _selectedID;
        int _selectedRowIndex;
        public string _selectedText;
        string _connectionStr;

        public FormModifCandidat()
        {
            _connectionStr = "server=LENOVO;database=Nsa_DB;trusted_connection=yes";
            InitializeComponent();
        }

        void loadCandidat()
        {
           
            DataSet ds = cl.getDataSet(_connectionStr, "select * from Candidats_Inscrits order by nom");

            try
            {
                dataGridView_ModifCand.DataSource = ds.Tables[0];

                dataGridView_ModifCand.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormModifCandidat_Load(object sender, EventArgs e)
        {
            loadCandidat();
        }

        private void dataGridView_ModifCand_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int colIndex = e.ColumnIndex;

            string newcellvalue = dataGridView_ModifCand.Rows[rowIndex].Cells[colIndex].Value.ToString();

            string colName = dataGridView_ModifCand.Columns[colIndex].Name;

            int id = 0;

            try
            {
                id = Convert.ToInt32(dataGridView_ModifCand.Rows[rowIndex].Cells[0].Value);
            }
            catch (Exception ex)
            {

            }

            if (id > 0)
            {
                textBox_Msg.Text = cl.executeNonQuery(_connectionStr, "update Candidats_Inscrits set " + colName + " = '" + newcellvalue + "' where id = " + id.ToString());

            }

            loadCandidat();
        }

        private void dataGridView_ModifCand_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void dataGridView_ModifCand_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _selectedRowIndex = e.RowIndex;

            try
            {
                _selectedID = Convert.ToInt32(dataGridView_ModifCand.Rows[_selectedRowIndex].Cells[0].Value);
            }
            catch
            {

                _selectedID = 0;
            }
        }
    }
}
