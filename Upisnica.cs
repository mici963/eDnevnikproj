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
    public partial class Upisnica : Form
    {
        DataTable dtupisnica;
            public Upisnica()
        {
            InitializeComponent();
        }
        private void godinacombobox()
        {
            SqlConnection veza = Konekcija.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM skolska_godina ", veza);
            DataTable dtgodina = new DataTable();
            adapter.Fill(dtgodina);
            combogodina.DataSource= dtgodina;
            combogodina.ValueMember = "id";
                combogodina.DisplayMember = "naziv";
          
        }
        private void combogodina_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combogodina.IsHandleCreated && combogodina.Focused)
            {
                odeljenjecombobox();
                comboodeljenje.SelectedIndex = -1;
              
                textBoxupisnica.Text = "";
                while (dataGridupisnica.Rows.Count>0)
                {
                    dataGridupisnica.Rows.Remove(dataGridupisnica.Rows[0]);
                }
                comboucenik.SelectedIndex = -1;

                comboucenik.Enabled = false;
            }

        }
        private void odeljenjecombobox()
        {
            string godina = combogodina.SelectedValue.ToString();
            SqlConnection veza = Konekcija.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM odeljenje WHERE godina_id=" + godina, veza);
            DataTable dtodeljenje = new DataTable();
            adapter.Fill(dtodeljenje);
            comboodeljenje.DataSource = dtodeljenje;
            comboodeljenje.ValueMember = "id";
            comboodeljenje.DisplayMember = "naziv";
          
        }
        private void comboodeljenje_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboodeljenje.IsHandleCreated && comboodeljenje.Focused)
            {
                
                comboucenik.Enabled = true;
                grid();
            }

        }
        private void ucenikcombobox()
        {
            SqlConnection veza = Konekcija.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT id,ime + prezime AS naziv FROM osoba WHERE uloga=1",veza);
            DataTable dtucenik = new DataTable();
            adapter.Fill(dtucenik);
            comboucenik.DataSource = dtucenik;
            comboucenik.ValueMember = "id";
            comboucenik.DisplayMember = "naziv";
        }
        private void grid ()
        {
            SqlConnection veza = Konekcija.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT upisnica.id AS id, ime + prezime AS naziv, osoba.id AS ucenik FROM upisnica JOIN osoba ON osoba_id = osoba.id WHERE odeljenje_id=" + comboodeljenje.SelectedValue.ToString(), veza);
           dtupisnica = new DataTable();
            adapter.Fill(dtupisnica);
            dataGridupisnica.DataSource = dtupisnica;
            dataGridupisnica.AllowUserToAddRows=false;
            dataGridupisnica.Columns["ucenik"].Visible = false;
          

        }
        private void Upisnica_Load(object sender, EventArgs e)
        {
            comboucenik.SelectedIndex = -1;
            godinacombobox();
            odeljenjecombobox();

            comboodeljenje.SelectedIndex = -1;
            
            comboucenik.Enabled = false;
            textBoxupisnica.Enabled = false;
            ucenikcombobox();
        }

        private void dataGridupisnica_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataGridupisnica.CurrentRow != null)
            {
                int brojreda = dataGridupisnica.CurrentRow.Index;
                if (dtupisnica.Rows.Count != 0 && brojreda >= 0)
                {
                    comboucenik.SelectedValue = dataGridupisnica.Rows[brojreda].Cells["ucenik"].Value.ToString();
                    textBoxupisnica.Text = dataGridupisnica.Rows[brojreda].Cells["id"].Value.ToString();
                }
            }
          
        }

        private void buttondodaj_Click(object sender, EventArgs e)
        {
            StringBuilder naredba = new StringBuilder("INSERT INTO upisnica(odeljenje_id,osoba_id) VALUES(");
            naredba.Append(comboodeljenje.SelectedValue);
            naredba.Append(", ");
            naredba.Append(comboucenik.SelectedValue);
            naredba.Append(")");
            SqlConnection veza = Konekcija.Connect();
            SqlCommand komanda = new SqlCommand(naredba.ToString(),veza);
            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();
                grid();
            }
            catch(Exception Greska)
            {
                MessageBox.Show(Greska.Message)  ;
               
            }
          
        }

        private void buttonizzmeni_Click(object sender, EventArgs e)
        {

            StringBuilder naredba = new StringBuilder("UPDATE upisnica SET ");

            naredba.Append("odeljenje_id = ");
            naredba.Append(comboodeljenje.SelectedValue);
            naredba.Append(", ");

            naredba.Append("osoba_id = ");
            naredba.Append(comboucenik.SelectedValue);

            naredba.Append(" WHERE id = ");
            naredba.Append(textBoxupisnica.Text);
            SqlConnection veza = Konekcija.Connect();
            SqlCommand komanda = new SqlCommand(naredba.ToString(), veza);
            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();
                grid();
            }
            catch (Exception Greska)
            {
                MessageBox.Show(Greska.Message);

            }

        }

        private void buttonobrisi_Click(object sender, EventArgs e)
        {

            StringBuilder naredba = new StringBuilder("DELETE FROM upisnica WHERE id = ");
            naredba.Append(textBoxupisnica.Text);

            SqlConnection veza = Konekcija.Connect();
            SqlCommand komanda = new SqlCommand(naredba.ToString(), veza);

            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();
                grid();
            }
            catch (Exception Greska)
            {
                MessageBox.Show(Greska.Message);
            }
        }
    }
    }

