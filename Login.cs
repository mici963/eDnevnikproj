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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void butlogin_Click(object sender, EventArgs e)
        {
            if (textname.Text == "" || textpass.Text == "")
            {
                MessageBox.Show("Unesi email i lozinku.");
                return;
            }
            else
            {
                try
                {
                    SqlConnection veza = Konekcija.Connect();
                    SqlCommand comanda = new SqlCommand("SELECT * FROM osoba WHERE email=@username", veza);
                    comanda.Parameters.AddWithValue("@username", textname.Text);
                    SqlDataAdapter adapter = new SqlDataAdapter(comanda);
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);
                    int br = tabela.Rows.Count;
                    if (br == 1)
                    {
                        if (String.Compare(tabela.Rows[0]["pass"].ToString(),textpass.Text)==0)
                        {
                            MessageBox.Show("Uspeli ste da se ulogujete");
                            Program.userime = tabela.Rows[0]["ime"].ToString();
                            Program.userprezime = tabela.Rows[0]["prezime"].ToString();
                            Program.useruloga = Convert.ToInt32(tabela.Rows[0]["uloga"]);
                            this.Hide();
                            Glavna2 frmglavna2 = new Glavna2();
                            frmglavna2.Show();
                           

                        }
                        else
                        {
                            MessageBox.Show("Pokusaj ponovo. Nije dobra lozinka");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Email ne postpoji.");

                    }
                }
                catch (Exception greska)
                {
                    MessageBox.Show(greska.Message);
                }
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
