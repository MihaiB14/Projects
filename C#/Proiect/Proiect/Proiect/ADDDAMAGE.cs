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
    public partial class INSERTDAUN : Form
    {
        public INSERTDAUN()
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
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM " + TABLES.table, sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dataGridView1.DataSource = dtbl;
                sqlCon.Close();
            }
        }

        private void txtDauneID_Enter(object sender, EventArgs e)
        {
            if(txtDauneID.Text == "*Daune ID")
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

        private void txtFrontal_Enter(object sender, EventArgs e)
        {
            if (txtFrontal.Text == "Frontal")
            {
                txtFrontal.Text = "";
            }
        }

        private void txtFrontal_Leave(object sender, EventArgs e)
        {
            if (txtFrontal.Text == "")
            {
                txtFrontal.Text = "Frontal";
            }
        }

        private void txtLateralDr_Enter(object sender, EventArgs e)
        {
            if (txtLateralDr.Text == "Lateral Dreapta")
            {
                txtLateralDr.Text = "";
            }
        }

        private void txtLateralDr_Leave(object sender, EventArgs e)
        {
            if (txtLateralDr.Text == "")
            {
                txtLateralDr.Text = "Lateral Dreapta";
            }
        }

        private void txtLateralSt_Enter(object sender, EventArgs e)
        {
            if (txtLateralSt.Text == "Lateral Stânga")
            {
                txtLateralSt.Text = "";
            }
        }

        private void txtLateralSt_Leave(object sender, EventArgs e)
        {
            if (txtLateralSt.Text == "")
            {
                txtLateralSt.Text = "Lateral Stânga";
            }
        }

        private void txtPosterior_Enter(object sender, EventArgs e)
        {
            if (txtPosterior.Text == "Posterior")
            {
                txtPosterior.Text = "";
            }
        }

        private void txtPosterior_Leave(object sender, EventArgs e)
        {
            if (txtPosterior.Text == "")
            {
                txtPosterior.Text = "Posterior";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            new TABLES().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtDauneID.Text == "*Daune ID")  
            {
                MessageBox.Show("Nu ați completat câmpurile obligatorii!");
            }
            else
            {
                if (txtFrontal.Text == "Frontal" &&
                    txtLateralDr.Text == "Lateral Dreapta" &&
                    txtLateralSt.Text == "Lateral Stânga" &&
                    txtPosterior.Text == "Posterior")
                {
                    MessageBox.Show("Nu ați introdus nicio dauna!");
                }
                else
                {
                    if (txtFrontal.Text == "Frontal")
                    {
                        txtFrontal.Text = "0";
                    }

                    if (txtLateralDr.Text == "Lateral Dreapta")
                    {
                        txtLateralDr.Text = "0";
                    }

                    if (txtLateralSt.Text == "Lateral Stânga")
                    {
                        txtLateralSt.Text = "0";
                    }

                    if(txtPosterior.Text == "Posterior")
                    {
                        txtPosterior.Text = "0";
                    }

                    string connectionString = @"Data Source = DESKTOP-D97BUTD; Initial Catalog = Evidenta masinilor inmatriculate la nivel de judet; Integrated Security = True;";
                    string parameters = " (Daune_ID, Frontal, Lateral_Dreapta, Lateral_Stanga, Posterior) ";
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("INSERT INTO " + TABLES.table + parameters + "VALUES ('" + txtDauneID.Text + "', " + txtFrontal.Text + ", " + txtLateralDr.Text + ", " + txtLateralSt.Text + ", " + txtPosterior.Text + ");", con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Datele au fost introduse cu succes!");
                        con.Close();
                        new INSERTDAUN().Show();
                        this.Hide();
                    }
                }
            }
            
        }
    }
}
