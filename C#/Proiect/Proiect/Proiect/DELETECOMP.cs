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

namespace Proiect
{
    public partial class DELETECOMP : Form
    {
        public DELETECOMP()
        {
            InitializeComponent();
            afisare();
        }

        private void afisare()
        {
            string connectionString = @"Data Source = DESKTOP-D97BUTD; Initial Catalog = Evidenta masinilor inmatriculate la nivel de judet; Integrated Security = True;";
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM " + TABLES2DELETE.table, sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dataGridView1.DataSource = dtbl;
                sqlCon.Close();
            }
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            new TABLES2DELETE().Show();
            this.Hide();
        }

        private void txtID_Enter(object sender, EventArgs e)
        {
            if (txtCF.Text == "*Cod Fiscal")
            {
                txtCF.Text = "";
            }
        }

        private void txtCF_Leave(object sender, EventArgs e)
        {
            if (txtCF.Text == "")
            {
                txtCF.Text = "*Cod Fiscal";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtCF.Text == "*Cod Fiscal")
            {
                MessageBox.Show("Nu ați completat câmpurile obligatorii!");
            }
            else
            {
                string connectionString = @"Data Source = DESKTOP-D97BUTD; Initial Catalog = Evidenta masinilor inmatriculate la nivel de judet; Integrated Security = True;";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd3 = new SqlCommand("DELETE " + TABLES2DELETE.table + " WHERE Cod_Fiscal = " + txtCF.Text + ";", con);
                    cmd3.ExecuteNonQuery();

                    MessageBox.Show("Datele au fost șterse cu succes!");
                    con.Close();
                    new DELETECOMP().Show();
                    this.Hide();
                }
            }
        }
    }
}
