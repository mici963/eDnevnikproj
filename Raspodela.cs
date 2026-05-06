using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eDnevnikproj
{
    public partial class Raspodela : Form
    {
        DataTable raspodela;
        int brojsloga;
        public Raspodela()
        {
            InitializeComponent();
        }
        private void loaddata()
        {
            SqlConnection veza = Konekcija.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Raspodela",veza);
            raspodela = new DataTable();
            adapter.Fill(raspodela);
        }
        private void Raspodela_Load(object sender, EventArgs e)
        {
            loaddata();
            Combofill();

        }
        private void Combofill()
        {
           
            SqlConnection veza= Konekcija.Connect();
            SqlDataAdapter adapter;
            DataTable dtgodina, dtnastavnik, dtpredmet, dtodeljenje;
            adapter = new SqlDataAdapter("SELECT * FROM skolska_godina", veza);
            dtgodina = new DataTable();
adapter.Fill(dtgodina);
            dtnastavnik = new DataTable();
            adapter = new SqlDataAdapter("SELECT id,ime + prezime as naziv FROM osoba WHERE uloga = 2", veza);
           
            adapter.Fill(dtnastavnik);
                dtpredmet = new DataTable();
            adapter = new SqlDataAdapter("SELECT id,naziv  FROM predmet", veza);
           adapter.Fill(dtpredmet);

            dtodeljenje = new DataTable();
            adapter = new SqlDataAdapter("SELECT id,naziv  FROM odeljenje", veza);
            adapter.Fill(dtodeljenje);
            cmbgodina.DataSource = dtgodina;
            cmbgodina.ValueMember = "id";
            cmbgodina.DisplayMember = "naziv";
       

            cmbnastavnik.DataSource = dtnastavnik;
            cmbnastavnik.DataSource = dtnastavnik;
            cmbnastavnik.ValueMember = "id";
            cmbnastavnik.DisplayMember = "naziv";
         

            cmbpredmet.DataSource = dtpredmet;
            cmbpredmet.DataSource = dtpredmet;
            cmbpredmet.ValueMember = "id";
            cmbpredmet.DisplayMember = "naziv";
    

            cmbodeljenje.DataSource = dtodeljenje;
            cmbodeljenje.DataSource = dtodeljenje;
            cmbodeljenje.ValueMember = "id";
            cmbodeljenje.DisplayMember = "naziv";
            if (raspodela.Rows.Count==0)

            { cmbodeljenje.SelectedValue = -1;
                cmbpredmet.SelectedValue = -1;
                cmbnastavnik.SelectedValue = -1;
                cmbgodina.SelectedValue = -1;
            }
            else
            {
                cmbodeljenje.SelectedValue = raspodela.Rows[brojsloga]["odeljenje_id"];
                cmbpredmet.SelectedValue = raspodela.Rows[brojsloga]["predmet_id"];
                cmbnastavnik.SelectedValue = raspodela.Rows[brojsloga]["nastavnik_id"];
                cmbgodina.SelectedValue = raspodela.Rows[brojsloga]["godina_id"];
            }
            if (brojsloga == 0)
            {
                buttonprvi.Enabled = false;
                buttonprethodni.Enabled = false;
            }
            else
            {
                buttonprvi.Enabled = true;
                buttonprethodni.Enabled = true;
            }
            if (brojsloga == raspodela.Rows.Count - 1)
            {
                buttonposlednji.Enabled = false;
                buttonsledeci.Enabled = false;
            }
            else
            {
                buttonposlednji.Enabled = true;
                buttonsledeci.Enabled = true;
            }

            textBoxid.Text = raspodela.Rows[brojsloga]["id"].ToString();
        }

        private void buttonprvi_Click(object sender, EventArgs e)
        {
            brojsloga = 0;
            Combofill();
        }

        private void buttonprethodni_Click(object sender, EventArgs e)
        {
            brojsloga = brojsloga - 1;
            Combofill();
        }

        private void buttonsledeci_Click(object sender, EventArgs e)
        {

            brojsloga += 1;
            Combofill();
        }

        private void buttonposlednji_Click(object sender, EventArgs e)
        {
            brojsloga = raspodela.Rows.Count - 1;
            Combofill();
        }

        private void buttonobrisi_Click(object sender, EventArgs e)
        {
            string naredba = "DELETE FROM raspodela WHERE id=" + textBoxid.Text;
            SqlConnection veza = Konekcija.Connect();
            SqlCommand comanda = new SqlCommand(naredba, veza);
            Boolean brisano = false;
            try
            {
                veza.Open();

                comanda.ExecuteNonQuery();
                veza.Close();
                brisano = true;

            }
            catch (Exception Greska)
            {
                MessageBox.Show(Greska.Message);

            }
            if (brisano)
            {
                loaddata();
            }
            if (brojsloga > 0) brojsloga--;
           Combofill();
        }

        private void buttondodaj_Click(object sender, EventArgs e)
        {
            //INSTERT INTO raspodela(godinaijn,  nastavnikid, predmetid, odeljhenjeid)
            StringBuilder naredba = new StringBuilder(
 "INSERT INTO raspodela (godina_id, nastavnik_id, predmet_id, odeljenje_id) VALUES ('");
            naredba.Append(cmbgodina.SelectedValue + "', '");
            naredba.Append(cmbnastavnik.SelectedValue + "', '");
            naredba.Append(cmbpredmet.SelectedValue + "', '");
            naredba.Append(cmbodeljenje.SelectedValue + "')");
            SqlConnection veza = Konekcija.Connect();
            SqlCommand comanda = new SqlCommand(naredba.ToString(), veza);
            try
            {
                veza.Open();

                comanda.ExecuteNonQuery();
                veza.Close();

            }
            catch (Exception Greska)
            {
                MessageBox.Show(Greska.Message);

            }
            loaddata();
            brojsloga = raspodela.Rows.Count - 1;
            Combofill();
        }

        private void buttonizmeni_Click(object sender, EventArgs e)
        {
            StringBuilder naredba = new StringBuilder("UPDATE raspodela SET ");

            naredba.Append("godina_id = '" + cmbgodina.SelectedValue + "', ");
            naredba.Append("nastavnik_id = '" + cmbnastavnik.SelectedValue + "', ");
            naredba.Append("predmet_id = '" + cmbpredmet.SelectedValue + "', ");
            naredba.Append("odeljenje_id = '" + cmbodeljenje.SelectedValue + "' ");
            naredba.Append("WHERE id = " + textBoxid.Text);


            SqlConnection veza = Konekcija.Connect();
            SqlCommand comanda = new SqlCommand(naredba.ToString(), veza);
            try
            {
                veza.Open();

                comanda.ExecuteNonQuery();
                veza.Close();

            }
            catch (Exception Greska)
            {
                MessageBox.Show(Greska.Message);

            }
            loaddata();
            Combofill();
        }
    }
}
