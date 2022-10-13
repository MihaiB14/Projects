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
    public partial class UPDATETAX : Form
    {
        public UPDATETAX()
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
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Taxe", sqlCon);
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

        private void txtss_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtni_Enter(object sender, EventArgs e)
        {
            if(txtni.Text == "*Număr Înmatriculare")
            {
                txtni.Text = "";
            }
        }

        private void txtni_Leave(object sender, EventArgs e)
        {
            if (txtni.Text == "")
            {
                txtni.Text = "*Număr Înmatriculare";
            }
        }

        private void txtnni_Enter(object sender, EventArgs e)
        {
            if(txtnni.Text == "Noul Număr de Înmatriculare")
            {
                txtnni.Text = "";
            }
        }

        private void txtnni_Leave(object sender, EventArgs e)
        {
            if (txtnni.Text == "")
            {
                txtnni.Text = "Noul Număr de Înmatriculare";
            }
        }

        private void txtImp_Enter(object sender, EventArgs e)
        {
            if (txtImp.Text == "Impozit")
            {
                txtImp.Text = "";
            }
        }

        private void txtImp_Leave(object sender, EventArgs e)
        {
            if (txtImp.Text == "")
            {
                txtImp.Text = "Impozit";
            }
        }

        private void txtAsig_Enter(object sender, EventArgs e)
        {
            if (txtAsig.Text == "Asigurare")
            {
                txtAsig.Text = "";
            }
        }

        private void txtAsig_Leave(object sender, EventArgs e)
        {
            if (txtAsig.Text == "")
            {
                txtAsig.Text = "Asigurare";
            }
        }

        private void txtrov_Enter(object sender, EventArgs e)
        {
            if (txtrov.Text == "Rovinietă")
            {
                txtrov.Text = "";
            }
        }

        private void txtrov_Leave(object sender, EventArgs e)
        {
            if (txtrov.Text == "")
            {
                txtrov.Text = "Rovinietă";
            }
        }

        private void txtCas_Enter(object sender, EventArgs e)
        {
            if (txtCas.Text == "Casco")
            {
                txtCas.Text = "";
            }
        }

        private void txtCas_Leave(object sender, EventArgs e)
        {
            if (txtCas.Text == "")
            {
                txtCas.Text = "Casco";
            }
        }

        private void txtnp_Enter(object sender, EventArgs e)
        {
            if(txtnp.Text == "Număr Preferențial")
            {
                txtnp.Text = "";
            }
        }

        private void txtnp_Leave(object sender, EventArgs e)
        {
            if (txtnp.Text == "")
            {
                txtnp.Text = "Număr Preferențial";
            }
        }

        private void txtr_Enter(object sender, EventArgs e)
        {
            if(txtr.Text == "Rural")
            {
                txtr.Text = "";
            }
        }

        private void txtr_Leave(object sender, EventArgs e)
        {
            if (txtr.Text == "")
            {
                txtr.Text = "Rural";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtnni.Text == "Noul Număr de Înmatriculare" &&
                txtImp.Text == "Impozit" &&
                txtAsig.Text == "Asigurare" &&
                txtrov.Text == "Rovinietă" &&
                txtCas.Text == "Casco" &&
                txtnp.Text == "Număr Preferențial" &&
                txtr.Text == "Rural")
            {
                MessageBox.Show("Nu ați completat niciun câmp!");
            }
            else
            {
                if (txtni.Text == "*Număr Înmatriculare")
                {
                    MessageBox.Show("Nu ați completat câmpul obligatoriu!");
                }
                else
                {
                    string ni, imp, asig, rov, cas, np, r;
                    if (txtnni.Text == "Noul Număr de Înmatriculare")
                    {
                       ni = "'" + txtni.Text + "'";
                    }
                    else
                    {
                       ni = "'" + txtnni.Text + "'";
                    }
        

                    if (txtImp.Text == "Impozit")
                    {
                        imp = "Impozit";
                    }
                    else
                    {
                        imp = txtImp.Text;
                    }

                    if (txtAsig.Text == "Asigurare")
                    {
                        asig = "Asigurare";
                    }
                    else
                    {
                        asig = txtAsig.Text;
                    }

                    if (txtrov.Text == "Rovinietă")
                    {
                        rov = "Rovinieta";
                    }
                    else
                    {
                        rov = txtrov.Text;
                    }

                    if(txtCas.Text == "Casco")
                    {
                        cas = "Casco";
                    }
                    else
                    {
                        cas = txtCas.Text;
                    }

                    if(txtnp.Text == "Număr Preferențial")
                    {
                        np = "Numar_Preferential";
                    }
                    else
                    {
                        np = "'" + txtnp.Text + "'";
                    }

                    if(txtr.Text == "Rural")
                    {
                        r = "Rural";
                    }
                    else
                    {
                        r = "'" + txtr.Text + "'";
                    }

                    string connectionString = @"Data Source = DESKTOP-D97BUTD; Initial Catalog = Evidenta masinilor inmatriculate la nivel de judet; Integrated Security = True;";
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("UPDATE Taxe SET Numar_Inmatriculare = " + ni + ", Impozit = " + imp + ", Asigurare = " + asig + ", Rovinieta = " + rov + ", Casco = " + cas + ", Numar_Preferential = " + np + ", Rural = " + r + " WHERE Numar_Inmatriculare = '" + txtni.Text + "'", con);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Datele au fost updatate cu succes!");
                        con.Close();
                        new UPDATETAX().Show();
                        this.Hide();
                    }
                }

            }

        }
    }
}
