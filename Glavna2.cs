using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eDnevnikproj
{
    public partial class Glavna2 : Form
    {
        public Glavna2()
        {
            InitializeComponent();
        }

        private void osobeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            osoba frmosoba = new osoba();
            frmosoba.Show();
        }
        
        private void raspodelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Raspodela frmraspodela = new Raspodela();
            frmraspodela.Show();
        }

        private void ocenaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ocena frmocena= new Ocena();
            frmocena.Show();
        }

        private void smeroviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sifarnik frmsmer = new Sifarnik("smer");
            frmsmer.Show();

        }

        private void skolskeGodineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sifarnik frmskolskagodina = new Sifarnik("skolska_godina");
            frmskolskagodina.Show();
        }

        private void predmetiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sifarnik frmpredmeti = new Sifarnik("predmet");
            frmpredmeti.Show();
        }

        private void upisniceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Upisnica frmupisnica = new Upisnica();
            frmupisnica.Show();
        }

        private void Glavna2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
