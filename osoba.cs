using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace eDnevnikproj
{
    public partial class osoba : Form
    {
        public osoba()
        {
            InitializeComponent();
        }

        private void textBoxime_TextChanged(object sender, EventArgs e)
        {

        }
        int brsloga = 0;
        DataTable tabela;
        private void loaddata()
        {
            SqlConnection veza = Konekcija.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from osoba", veza);
            tabela = new DataTable();
            adapter.Fill(tabela);
        }

        private void textload()
        {
            if (tabela.Rows.Count ==  0)
                {

                textBoxid.Text = "";
                textBoxime.Text = "";
                textBoxprezime.Text = "";
                textBoxadresa.Text = "";
                textBoxjmbg.Text = "";
                textBoxemail.Text = "";
                textBoxpass.Text = "";
                textBoxuloga.Text = "";
                buttonobrisi.Enabled = false;
            }
            else
            {
                textBoxid.Text = tabela.Rows[brsloga]["id"].ToString();
                textBoxime.Text = tabela.Rows[brsloga]["ime"].ToString();
                textBoxprezime.Text = tabela.Rows[brsloga]["prezime"].ToString();
                textBoxadresa.Text = tabela.Rows[brsloga]["adresa"].ToString();
                textBoxjmbg.Text = tabela.Rows[brsloga]["jmbg"].ToString();
                textBoxemail.Text = tabela.Rows[brsloga]["email"].ToString();
                textBoxpass.Text = tabela.Rows[brsloga]["pass"].ToString();
                textBoxuloga.Text = tabela.Rows[brsloga]["uloga"].ToString();
                buttonobrisi.Enabled = true;
            }
            if (brsloga == 0)
            {
                buttonprvi.Enabled = false;
                buttonprethodni.Enabled = false;
            }
            else
            {
                buttonprvi.Enabled = true;
                buttonprethodni.Enabled = true;
            }
            if (brsloga == tabela.Rows.Count - 1)
            {
                buttonposlednji.Enabled = false;
                buttonsledeci.Enabled = false;
            }
            else
            {
                buttonposlednji.Enabled = true;
                buttonsledeci.Enabled = true;
            }
        }
        private void osoba_Load(object sender, EventArgs e)
        {
            loaddata();
            textload();
        }

        private void buttonprvi_Click(object sender, EventArgs e)
        {
            brsloga = 0;
            textload();

        }

        private void buttonprethodni_Click(object sender, EventArgs e)
        {
            brsloga = brsloga - 1;
            textload();
        }

        private void buttonsledeci_Click(object sender, EventArgs e)
        {
            brsloga += 1;
            textload();
        }

        private void buttonposlednji_Click(object sender, EventArgs e)
        {
            brsloga = tabela.Rows.Count-1;
            textload();
        }

        private void buttondodaj_Click(object sender, EventArgs e)
        {
            //INSTERT INTO osoba(ime,  prezime, adresa, jmbg, email, pass, uloga) VALUES ("Luka","Malesic",  "Ad21", "12345663", "123", "1")
            StringBuilder naredba = new StringBuilder("INSERT INTO osoba(ime, prezime, adresa, jmbg, email, pass, uloga) VALUES('");
            naredba.Append(textBoxime.Text + " ', '");
            naredba.Append(textBoxprezime.Text + " ', '");
            naredba.Append(textBoxadresa.Text + " ', '");
            naredba.Append(textBoxjmbg.Text + " ', '");
            naredba.Append(textBoxemail.Text + " ', '");
            naredba.Append(textBoxpass.Text + " ', '");
            naredba.Append(textBoxuloga.Text + " ')");
            SqlConnection veza = Konekcija.Connect();
            SqlCommand comanda = new SqlCommand(naredba.ToString(), veza);
            try
            {
                veza.Open();

                comanda.ExecuteNonQuery();
                veza.Close();

            }
            catch(Exception Greska )
            {
                MessageBox.Show(Greska.Message);

            }
            loaddata();
            brsloga = tabela.Rows.Count - 1;
            textload();


        }

        private void buttonizmeni_Click(object sender, EventArgs e)
        {
            StringBuilder naredba = new StringBuilder("UPDATE osoba SET ");

            naredba.Append("ime = '" + textBoxime.Text + "', ");
            naredba.Append("prezime = '" + textBoxprezime.Text + "', ");
            naredba.Append("adresa = '" + textBoxadresa.Text + "', ");
            naredba.Append("jmbg = '" + textBoxjmbg.Text + "', ");
            naredba.Append("email = '" + textBoxemail.Text + "', ");
            naredba.Append("pass = '" + textBoxpass.Text + "', ");
            naredba.Append("uloga = '" + textBoxuloga.Text + "' ");
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
            textload();
        }

        private void buttonobrisi_Click(object sender, EventArgs e)
        {
            string naredba = "DELETE FROM osoba WHERE id=" + textBoxid.Text;
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
            if (brsloga > 0)  brsloga --;
            textload();

        }

        private void labeluloga_Click(object sender, EventArgs e)
        {

        }
    }
}
