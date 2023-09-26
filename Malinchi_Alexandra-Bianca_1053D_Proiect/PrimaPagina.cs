using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Malinchi_Alexandra_Bianca_1053D_Proiect
{
    public partial class PrimaPagina : Form
    {
        public PrimaPagina()
        {
            InitializeComponent();
        }

        private void categorie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void b_start_Click(object sender, EventArgs e)
        {
            if (actiune.SelectedIndex > -1)
            {
                if (actiune.SelectedItem.ToString() == "Public anunt")
                {
                    PublicareAnunt publicare = new PublicareAnunt();
                    publicare.Show();
                    this.Hide();
                }
                else if (actiune.SelectedItem.ToString() == "Rezerv camere")
                {
                    RezervaCamere rezerva = new RezervaCamere();
                    rezerva.Show();
                    this.Hide();
                }
            }else
            {
                MessageBox.Show("Alegeti o optiune!");
            }
        }

        private void PrimaPagina_Load(object sender, EventArgs e)
        {

        }
    }
}
