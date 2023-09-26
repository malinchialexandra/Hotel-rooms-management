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
    public partial class PublicareAnunt : Form
    {
        public PublicareAnunt()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Documente\anunturidb.mdf;Integrated Security=True;Connect Timeout=30");
        private void PublicareAnunt_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void b_adauga_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "insert into AnunturiTbl values(" + id.Text + ",'" + numeHotel.Text + "','" + totalCamere.Text + "','" + pret.Text + "','" + oras.Text + "','" + categorie.SelectedIndex.ToString() + "','" + tip.SelectedIndex.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Anunt adaugat cu succes!");
                Con.Close();
                populate();
                id.Text = "";
                numeHotel.Text = "";
                totalCamere.Text = "";
                pret.Text = "";
                oras.Text = "";

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void populate()
        {
            Con.Open();
            string query = "select * from AnunturiTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            numeHotel.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            totalCamere.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            pret.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            oras.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            categorie.SelectedValue = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            tip.SelectedValue = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void b_sterge_Click(object sender, EventArgs e)
        {
            try
            {
                if (id.Text == "")
                {
                    MessageBox.Show("Alegeti ce doriti sa stergeti");
                }
                else
                {
                    Con.Open();
                    string query = "delete from AnunturiTbl where Id=" + id.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Anunt sters cu succes!");
                    Con.Close();
                    populate();
                    id.Text = "";
                    numeHotel.Text = "";
                    totalCamere.Text = "";
                    pret.Text = "";
                    oras.Text = "";

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void b_modifica_Click(object sender, EventArgs e)
        {
            try
            {
                if (id.Text == "" || numeHotel.Text == "" || totalCamere.Text == "" || pret.Text == "" || oras.Text == ""||categorie.SelectedIndex.ToString()==""||tip.SelectedIndex.ToString()=="")
                {
                    MessageBox.Show("Lipsesc informatii!");
                }
                else
                {
                    Con.Open();
                    string query = "update AnunturiTbl set NumeHotel='" + numeHotel.Text + "',NrCamere=" + totalCamere.Text + ",Pret='" + pret.Text + ",Oras='" + oras.Text + "' where Id=" + id.Text + ";'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Anunt modificat cu succes!");
                    Con.Close();
                    populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            id.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            numeHotel.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            totalCamere.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            pret.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            oras.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            categorie.SelectedValue = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            tip.SelectedValue = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }
    }
}
