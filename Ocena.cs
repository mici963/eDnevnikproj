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
using System.Diagnostics;
using System.Linq.Expressions;

namespace eDnevnikproj
{
    public partial class Ocena : Form
    {
        public Ocena()
        {
            InitializeComponent();
        }
        DataTable dtocena;
        private void Ocena_Load(object sender, EventArgs e)
        {
            godinapop();
            comboBoxpredmet.Enabled = false;
            comboBoxodeljenje.Enabled = false;
            comboBoxucenik.Enabled = false;
            comboBoxocena.Enabled = false;
            comboBoxocena.SelectedIndex = -1;

            ocenapop();
            profesorpop();
            
        }
        private void ocenapop()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ocena");

            dt.Rows.Add(1);
            dt.Rows.Add(2);
            dt.Rows.Add(3);
            dt.Rows.Add(4);
            dt.Rows.Add(5);

            comboBoxocena.DataSource = dt;
            comboBoxocena.ValueMember = "ocena";
            comboBoxocena.DisplayMember = "ocena";
            comboBoxocena.Enabled = false;
            comboBoxocena.SelectedIndex = -1;
        }
        private void godinapop()
        {
            SqlConnection veza = Konekcija.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM skolska_godina", veza);
            DataTable dtgodina = new DataTable();
            adapter.Fill(dtgodina);
            comboBoxgodina.DataSource = dtgodina;
            comboBoxgodina.ValueMember = "id";
            comboBoxgodina.DisplayMember = "naziv";
        }
        private void comboBoxgodina_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBoxgodina.IsHandleCreated && comboBoxgodina.Focused)
            {
                profesorpop();
                comboBoxpredmet.Enabled = false;
                comboBoxodeljenje.Enabled = false;
                comboBoxucenik.Enabled = false;
                comboBoxocena.Enabled = false;
                comboBoxocena.SelectedIndex = -1;
                comboBoxpredmet.SelectedIndex = -1;
                comboBoxucenik.SelectedIndex = -1;
                comboBoxodeljenje.SelectedIndex = -1;
                textBoxid.Text = "";
                dtocena = new DataTable();
                

                gridocena.DataSource = dtocena;
            }
        }
        private void profesorpop()
        {

            StringBuilder naredba = new StringBuilder("SELECT DISTINCT osoba.id AS id,ime + ' ' + prezime AS naziv FROM osoba ");
            naredba.Append(" JOIN raspodela ON osoba.id = nastavnik_id");
            naredba.Append(" WHERE godina_id = " + comboBoxgodina.SelectedValue.ToString());
            DataTable dtgodina = new DataTable();
            SqlConnection veza = Konekcija.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter(naredba.ToString(), veza);
            DataTable dtprofesor = new DataTable();
            adapter.Fill(dtprofesor);
            comboBoxprofesor.DataSource = dtprofesor;
            comboBoxprofesor.ValueMember = "id";
            comboBoxprofesor.DisplayMember = "naziv";
            comboBoxprofesor.SelectedIndex = -1;

        }

        private void comboBoxprofesor_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBoxprofesor.IsHandleCreated && comboBoxprofesor.Focused)
            {

                predmetpop();
                comboBoxpredmet.Enabled = true;
                comboBoxodeljenje.Enabled = false;
                comboBoxucenik.Enabled = false;

                comboBoxucenik.SelectedIndex = -1;
                comboBoxodeljenje.SelectedIndex = -1;
                textBoxid.Text = "";
                dtocena = new DataTable();
                 comboBoxocena.Enabled = false;
                comboBoxocena.SelectedIndex = -1;

                gridocena.DataSource = dtocena;
            }

        }
        private void predmetpop()
        {

            StringBuilder naredba = new StringBuilder("SELECT DISTINCT predmet.id AS id,naziv FROM predmet ");
            naredba.Append(" JOIN raspodela ON predmet.id = predmet_id");
            naredba.Append(" WHERE godina_id = " + comboBoxgodina.SelectedValue.ToString());
            naredba.Append(" AND nastavnik_id = " + comboBoxprofesor.SelectedValue.ToString());
            SqlConnection veza = Konekcija.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter(naredba.ToString(), veza);
            DataTable dtpredmet = new DataTable();
            adapter.Fill(dtpredmet);
            comboBoxpredmet.DataSource = dtpredmet;
            comboBoxpredmet.ValueMember = "id";
            comboBoxpredmet.DisplayMember = "naziv";
            comboBoxpredmet.SelectedIndex = -1;

            //textBox1.Text = naredba.ToString();
        }

        private void comboBoxpredmet_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBoxpredmet.IsHandleCreated && comboBoxpredmet.Focused)
            {

                odeljenjepop();
                comboBoxodeljenje.Enabled = true;
                comboBoxucenik.SelectedIndex = -1;
                comboBoxucenik.Enabled = false;
                textBoxid.Text = "";

                dtocena = new DataTable();
                comboBoxocena.Enabled = false;
                comboBoxocena.SelectedIndex = -1;
                gridocena.DataSource = dtocena;

            }
        }
        private void odeljenjepop()
        {
            StringBuilder naredba = new StringBuilder("SELECT DISTINCT odeljenje.id AS id,naziv FROM odeljenje ");
            naredba.Append(" JOIN raspodela ON odeljenje.id = odeljenje_id");
            naredba.Append(" WHERE raspodela.godina_id = " + comboBoxgodina.SelectedValue.ToString());
            naredba.Append(" AND nastavnik_id = " + comboBoxprofesor.SelectedValue.ToString());
            naredba.Append(" AND predmet_id = " + comboBoxpredmet.SelectedValue.ToString());

            SqlConnection veza = Konekcija.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter(naredba.ToString(), veza);

            DataTable dtodeljenje = new DataTable();
            adapter.Fill(dtodeljenje);

            comboBoxodeljenje.DataSource = dtodeljenje;
            comboBoxodeljenje.ValueMember = "id";
            comboBoxodeljenje.DisplayMember = "naziv";
        }

        private void comboBoxodeljenje_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBoxodeljenje.IsHandleCreated && comboBoxodeljenje.Focused)
            {
                comboBoxucenik.Enabled = true;
                comboBoxocena.Enabled = true;
               
                ucenikpop();
                gridpop();
                popuni(0);
            }
        }

        private void ucenikpop()
        {
            if (comboBoxodeljenje.SelectedValue == null)
                return;

            // zaštita od DataRowView bug-a
            if (comboBoxodeljenje.SelectedValue is DataRowView)
                return;

            int odeljenjeId = Convert.ToInt32(comboBoxodeljenje.SelectedValue);

            StringBuilder naredba = new StringBuilder(
                "SELECT osoba.id AS id, ime + ' ' + prezime AS naziv FROM osoba ");

            naredba.Append(" JOIN upisnica ON osoba.id = upisnica.osoba_id ");
            naredba.Append(" WHERE upisnica.odeljenje_id = " + odeljenjeId);

            SqlConnection veza = Konekcija.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter(naredba.ToString(), veza);

            DataTable dtucenik = new DataTable();
            adapter.Fill(dtucenik);

            comboBoxucenik.DataSource = dtucenik;
            comboBoxucenik.ValueMember = "id";
            comboBoxucenik.DisplayMember = "naziv";
        }
        private void gridpop()
        {
            StringBuilder naredba = new StringBuilder(
                "SELECT ocena.id AS id, ime + ' ' + prezime AS naziv, ocena, ucenik_id, datum FROM osoba ");

            naredba.Append(" JOIN ocena ON osoba.id = ocena.ucenik_id");
            naredba.Append(" JOIN raspodela ON ocena.raspodela_id = raspodela.id");
            naredba.Append(" WHERE raspodela.id = (SELECT id FROM raspodela");

            naredba.Append(" WHERE godina_id = " + comboBoxgodina.SelectedValue);
            naredba.Append(" AND nastavnik_id = " + comboBoxprofesor.SelectedValue);
            naredba.Append(" AND predmet_id = " + comboBoxpredmet.SelectedValue);
            naredba.Append(" AND odeljenje_id = " + comboBoxodeljenje.SelectedValue + ")");

            SqlConnection veza = Konekcija.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter(naredba.ToString(), veza);

            dtocena = new DataTable();
            adapter.Fill(dtocena);

            gridocena.DataSource = dtocena;
            gridocena.AllowUserToAddRows = false;
            gridocena.Columns["ucenik_id"].Visible = false;
        }

        private void gridocena_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                popuni(e.RowIndex);
            }
        }

        private void popuni(int brsloga)
        {
            comboBoxucenik.SelectedValue = Convert.ToInt32(dtocena.Rows[brsloga]["ucenik_id"]);
            comboBoxocena.SelectedValue = Convert.ToInt32(dtocena.Rows[brsloga]["ocena"]);
            textBoxid.Text = dtocena.Rows[brsloga]["id"].ToString();
        }


        private void buttondodaj_Click(object sender, EventArgs e)
        {
            if (comboBoxgodina.SelectedValue == null ||
                comboBoxprofesor.SelectedValue == null ||
                comboBoxpredmet.SelectedValue == null ||
                comboBoxodeljenje.SelectedValue == null ||
                comboBoxucenik.SelectedValue == null ||
                comboBoxocena.SelectedValue == null)
            {
                MessageBox.Show("Izaberi sve podatke!");
                return;
            }

            SqlConnection veza = Konekcija.Connect();

            try
            {
                // 1. uzmi raspodela id
                StringBuilder naredba = new StringBuilder();
                naredba.Append("SELECT id FROM raspodela ");
                naredba.Append("WHERE godina_id = " + comboBoxgodina.SelectedValue);
                naredba.Append(" AND nastavnik_id = " + comboBoxprofesor.SelectedValue);
                naredba.Append(" AND predmet_id = " + comboBoxpredmet.SelectedValue);
                naredba.Append(" AND odeljenje_id = " + comboBoxodeljenje.SelectedValue);

                SqlCommand komanda = new SqlCommand(naredba.ToString(), veza);

                veza.Open();
                object result = komanda.ExecuteScalar();
                veza.Close();

                if (result == null)
                {
                    MessageBox.Show("Raspodela ne postoji!");
                    return;
                }

                int id_raspodela = Convert.ToInt32(result);

                // 2. INSERT OCENA
                DateTime datum1 = datum.Value;

                StringBuilder insert = new StringBuilder();
                insert.Append("INSERT INTO ocena (datum, raspodela_id, ucenik_id, ocena) VALUES (");
                insert.Append("'" + datum1.ToString("yyyy-MM-dd") + "', ");
                insert.Append(id_raspodela + ", ");
                insert.Append(comboBoxucenik.SelectedValue + ", ");
                insert.Append(comboBoxocena.SelectedValue + ")");

                SqlCommand insertKomanda = new SqlCommand(insert.ToString(), veza);

                veza.Open();
                insertKomanda.ExecuteNonQuery();
                veza.Close();

                MessageBox.Show("Ocena uspešno dodata");

                gridpop();
            }
            catch (Exception g)
            {
                MessageBox.Show(g.Message);
                if (veza.State == ConnectionState.Open)
                    veza.Close();
            }
        }

        private void buttonobrisi_Click(object sender, EventArgs e)
        {
            if (textBoxid.Text == "")
            {
                MessageBox.Show("Izaberi ocenu za brisanje.");
                return;
            }

            int id_ocena = Convert.ToInt32(textBoxid.Text);

            SqlConnection veza = Konekcija.Connect();

            try
            {
                StringBuilder naredba = new StringBuilder();
                naredba.Append("DELETE FROM ocena WHERE id = " + id_ocena);

                SqlCommand komanda = new SqlCommand(naredba.ToString(), veza);

                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();

                MessageBox.Show("Ocena obrisana.");
                gridpop();
            }
            catch (Exception g)
            {
                MessageBox.Show(g.Message);
                if (veza.State == ConnectionState.Open)
                    veza.Close();
            }
        }

        private void buttonizmeni_Click(object sender, EventArgs e)
        {
            if (textBoxid.Text == "")
            {
                MessageBox.Show("Izaberi ocenu za izmenu!");
                return;
            }

            if (comboBoxucenik.SelectedValue == null ||
                comboBoxocena.SelectedValue == null)
            {
                MessageBox.Show("Popuni sve podatke!");
                return;
            }

            int id_ocena = Convert.ToInt32(textBoxid.Text);
            DateTime datum1 = datum.Value;

            SqlConnection veza = Konekcija.Connect();

            try
            {
                StringBuilder naredba = new StringBuilder();
                naredba.Append("UPDATE ocena SET ");
                naredba.Append("datum = '" + datum1.ToString("yyyy-MM-dd") + "', ");
                naredba.Append("ucenik_id = " + comboBoxucenik.SelectedValue + ", ");
                naredba.Append("ocena = " + comboBoxocena.SelectedValue + " ");
                naredba.Append("WHERE id = " + id_ocena);

                SqlCommand komanda = new SqlCommand(naredba.ToString(), veza);

                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();

                MessageBox.Show("Ocena uspešno izmenjena!");

                gridpop();
            }
            catch (Exception g)
            {
                MessageBox.Show(g.Message);
                if (veza.State == ConnectionState.Open)
                    veza.Close();
            }
        }
    }
}