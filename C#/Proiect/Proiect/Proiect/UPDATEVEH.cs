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
    public partial class UPDATEVEH : Form
    {
        public UPDATEVEH()
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
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Vehicul", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dataGridView1.DataSource = dtbl;
                sqlCon.Close();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            new TABELES2UPDATE().Show();
            this.Hide();
        }

        private void txtTipVeh_Enter(object sender, EventArgs e)
        {
            if(txtTipVeh.Text == "Tip Vehicul")
            {
                txtTipVeh.Text = "";
            }
        }

        private void txtTipVeh_Leave_1(object sender, EventArgs e)
        {
            if (txtTipVeh.Text == "")
            {
                txtTipVeh.Text = "Tip Vehicul";
            }
        }

        private void txtComb_Enter(object sender, EventArgs e)
        {
            if (txtComb.Text == "Combustibil")
            {
                txtComb.Text = "";
            }
        }

        private void txtComb_Leave(object sender, EventArgs e)
        {
            if (txtComb.Text == "")
            {
                txtComb.Text = "Combustibil";
            }
        }

        private void txtNrLoc_Enter(object sender, EventArgs e)
        {
            if(txtNrLoc.Text == "Număr Locuri")
            {
                txtNrLoc.Text = "";
            }
        }

        private void txtNrLoc_Leave(object sender, EventArgs e)
        {
            if (txtNrLoc.Text == "")
            {
                txtNrLoc.Text = "Număr Locuri";
            }
        }

        private void txt_Enter(object sender, EventArgs e)
        {
            if(txtCuloare.Text == "Culoare")
            {
                txtCuloare.Text = "";
            }
        }

        private void txtCuloare_Leave(object sender, EventArgs e)
        {
            if (txtCuloare.Text == "")
            {
                txtCuloare.Text = "Culoare";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtTipVeh.Text == "Tip Vehicul" &&
                txtComb.Text == "Combustibil" &&
                txtNrLoc.Text == "Număr Locuri" &&
                txtCuloare.Text == "Culoare")
            {
                MessageBox.Show("Nu ați completat niciun câmp!");
            }
            else
            {
                if (txtss.Text == "*Serie Șasiu")
                {
                    MessageBox.Show("Nu ați completat câmpul obligatoriu!");
                }
                else
                {
                    string tipveh, comb, nl, cul;
                    if (txtTipVeh.Text == "Tip Vehicul")
                    {
                        tipveh = "Tip_Vehicul";
                    }
                    else
                    {
                        tipveh = "'" + txtTipVeh.Text + "'";
                    }

                    if (txtComb.Text == "Combustibil")
                    {
                        comb = "Combustibil";
                    }
                    else
                    {
                        comb = "'" + txtComb.Text + "'";
                    }

                    if (txtNrLoc.Text == "Număr Locuri")
                    {
                        nl = "Numar_Locuri";
                    }
                    else
                    {
                        nl = "'" + txtNrLoc.Text + "'";
                    }

                    if (txtCuloare.Text == "Culoare")
                    {
                        cul = "Culoare";
                    }
                    else
                    {
                        cul = "'" + txtCuloare.Text + "'";
                    }

                    string connectionString = @"Data Source = DESKTOP-D97BUTD; Initial Catalog = Evidenta masinilor inmatriculate la nivel de judet; Integrated Security = True;";
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("UPDATE Vehicul SET Tip_Vehicul = " + tipveh + ", Combustibil = " + comb + ", Numar_Locuri = " + nl + ", Culoare = " + cul + " WHERE Serie_Sasiu = '" + txtss.Text + "';", con);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Datele au fost updatate cu succes!");
                        con.Close();
                        new UPDATEVEH().Show();
                        this.Hide();
                    }
                }

            }
        }


        private void txtss_Leave(object sender, EventArgs e)
        {
            if (txtss.Text == "")
            {
                txtss.Text = "*Serie Șasiu";
            }
        }

        private void txtss_Enter_1(object sender, EventArgs e)
        {
            if(txtss.Text == "*Serie Șasiu")
            {
                txtss.Text = "";
            }
        }
    }
}
