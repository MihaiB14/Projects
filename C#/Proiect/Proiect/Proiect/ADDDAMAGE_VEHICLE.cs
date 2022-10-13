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
    public partial class INSERTVEHDAUN : Form
    {
        public INSERTVEHDAUN()
        {
            InitializeComponent();
            afisare();
        }

        private void txtVehiculID_Enter(object sender, EventArgs e)
        {
            if(txtVehiculID.Text == "*Vehicul ID")
            {
                txtVehiculID.Text = "";
            }
        }

        private void txtVehiculID_Leave(object sender, EventArgs e)
        {
            if (txtVehiculID.Text == "")
            {
                txtVehiculID.Text = "*Vehicul ID";
            }
        }

        private void txtDauneID_Enter(object sender, EventArgs e)
        {
            if (txtDauneID.Text == "*Daune ID")
            {
                txtDauneID.Text = "";
            }
        }

        private void txtDauneID_Leave(object sender, EventArgs e)
        {
            if (txtDauneID.Text == "")
            {
                txtDauneID.Text = "*Daune ID";
            }
        }

        private void txtData_Enter(object sender, EventArgs e)
        {
            if (txtData.Text == "*Data")
            {
                txtData.Text = "";
            }
        }

        private void txtData_Leave(object sender, EventArgs e)
        {
            if (txtData.Text == "")
            {
                txtData.Text = "*Data";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            new TABLES().Show();
            this.Hide();
        }

        private void afisare()
        {
            string connectionString = @"Data Source = DESKTOP-D97BUTD; Initial Catalog = Evidenta masinilor inmatriculate la nivel de judet; Integrated Security = True;";
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM " + TABLES.table, sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dataGridView1.DataSource = dtbl;
                sqlCon.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtVehiculID.Text == "*Vehicul ID" || 
                txtDauneID.Text == "*Daune ID" ||
                txtData.Text == "*Data")
            {
                MessageBox.Show("Nu ați completat câmpurile obligatorii!");
            }
            else
            {
                string connectionString = @"Data Source = DESKTOP-D97BUTD; Initial Catalog = Evidenta masinilor inmatriculate la nivel de judet; Integrated Security = True;";
                string parameters = " (Vehicul_ID, Daune_ID, Data) ";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO " + TABLES.table + parameters + "VALUES ('" + txtVehiculID.Text + "', '" + txtDauneID.Text + "', '" + txtData.Text + "');", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost introduse cu succes!");
                    con.Close();
                    new INSERTVEHDAUN().Show();
                    this.Hide();
                }
            }
        }
    }
}
