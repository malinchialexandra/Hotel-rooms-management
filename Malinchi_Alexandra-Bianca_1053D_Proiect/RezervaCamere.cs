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

namespace Malinchi_Alexandra_Bianca_1053D_Proiect
{
    public partial class RezervaCamere : Form
    {
        public RezervaCamere()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Documente\anunturidb.mdf;Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            Con.Open();
            string query = "select NumeHotel, Pret from AnunturiTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dgv_rezervare.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void populateFacturi()
        {
            Con.Open();
            string query = "select * from FacturiTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            factura_dgv.DataSource = ds.Tables[0];
            Con.Close();
        }
        int grdtotal = 0;
        private void adaugare_Click(object sender, EventArgs e)
        {
           
            if (numeHotel.Text == "" || pret.Text == "")
            {
                MessageBox.Show("Adaugati datele!");
            }
            else
            {
                int n = 0, total = Convert.ToInt32(pret.Text) * Convert.ToInt32(totalCamere.Text);
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dataGridView1);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = numeHotel.Text;
                newRow.Cells[2].Value = totalCamere.Text;
                newRow.Cells[3].Value = pret.Text;
                newRow.Cells[4].Value = Convert.ToInt32(pret.Text) * Convert.ToInt32(totalCamere.Text);
                dataGridView1.Rows.Add(newRow);
                n++;
                grdtotal = grdtotal + total;
                totallbl.Text = "" + grdtotal;
            }
        }

        private void dgv_rezervare_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            numeHotel.Text = dgv_rezervare.SelectedRows[0].Cells[0].Value.ToString();
            pret.Text = dgv_rezervare.SelectedRows[0].Cells[1].Value.ToString();
           
           

        }

        private void RezervaCamere_Load(object sender, EventArgs e)
        {
            populate();
            populateFacturi();
        }

        private void b_checkout_Click(object sender, EventArgs e)
        {
            if (idFactura.Text == "")
            {
                MessageBox.Show("Lipseste id-ul!");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into FacturiTbl values(" + idFactura.Text + ",'" + totallbl.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Rezervarea dumneavoastra a fost inregistrata!");
                    Con.Close();
                    populateFacturi();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            numeHotel.Text = dgv_rezervare.SelectedRows[0].Cells[0].Value.ToString();
            pret.Text = dgv_rezervare.SelectedRows[0].Cells[1].Value.ToString();
            totalCamere.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        }
    }
}
