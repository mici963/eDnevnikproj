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

namespace eDnevnikproj
{
    public partial class Sifarnik : Form
    {
        DataTable tabela;
        SqlDataAdapter adapter;
        string imetabele;
        public Sifarnik(string tabela)
        {
            imetabele = tabela;
            InitializeComponent();
        }
        private void Sifarnik_Load(object sender, EventArgs e)
        {

            adapter = new SqlDataAdapter("SELECT * FROM " + imetabele, Konekcija.Connect());
            tabela = new DataTable();
            adapter.Fill (tabela);
            dataGridView1.DataSource = tabela;
            dataGridView1.Columns["id"].ReadOnly = true;

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dugmeok_Click(object sender, EventArgs e)
        {
            DataTable menjano = tabela.GetChanges();
            adapter.UpdateCommand = new SqlCommandBuilder(adapter).GetUpdateCommand();
            if (menjano != null)
            {
                adapter.Update(menjano);
                this.Close(); 
            }

        }
    }
}
