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
    public partial class INSERTTAXE : Form
    {
        public INSERTTAXE()
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
        private void label3_Click(object sender, EventArgs e)
        {
            new TABLES().Show();
            this.Hide();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTaxeID_Enter(object sender, EventArgs e)
        {
            if(txtTaxeID.Text == "*Taxe ID")
            {
                txtTaxeID.Text = "";
            }
        }

        private void txtTaxeID_Leave(object sender, EventArgs e)
        {
            if (txtTaxeID.Text == "")
            {
                txtTaxeID.Text = "*Taxe ID";
            }
        }

        private void txtVehiculID_Enter(object sender, EventArgs e)
        {
            if (txtVehiculID.Text == "*Vehicul ID")
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

        private void txtNrInm_Enter(object sender, EventArgs e)
        {
            if (txtNrInm.Text == "*Număr Înmatriculare")
            {
                txtNrInm.Text = "";
            }
        }

        private void txtNrInm_Leave(object sender, EventArgs e)
        {

            if (txtNrInm.Text == "")
            {
                txtNrInm.Text = "*Număr Înmatriculare";
            }
        }

        private void txtImpozit_Enter(object sender, EventArgs e)
        {
            if (txtImpozit.Text == "*Impozit")
            {
                txtImpozit.Text = "";
            }
        }

        private void txtImpozit_Leave(object sender, EventArgs e)
        {
            if (txtImpozit.Text == "")
            {
                txtImpozit.Text = "*Impozit";
            }
        }

        private void txtAsigurare_Enter(object sender, EventArgs e)
        {
            if (txtAsigurare.Text == "*Asigurare")
            {
                txtAsigurare.Text = "";
            }
        }

        private void txtAsigurare_Leave(object sender, EventArgs e)
        {
            if (txtAsigurare.Text == "")
            {
                txtAsigurare.Text = "*Asigurare";
            }
        }

        private void txtRovinieta_Enter(object sender, EventArgs e)
        {
            if (txtRovinieta.Text == "Rovinietă")
            {
                txtRovinieta.Text = "";
            }
        }

        private void txtRovinieta_Leave(object sender, EventArgs e)
        {
            if (txtRovinieta.Text == "")
            {
                txtRovinieta.Text = "Rovinietă";
            }
        }

        private void txtCasco_Enter(object sender, EventArgs e)
        {
            if (txtCasco.Text == "Casco")
            {
                txtCasco.Text = "";
            }
        }

        private void txtCasco_Leave(object sender, EventArgs e)
        {
            if (txtCasco.Text == "")
            {
                txtCasco.Text = "Casco";
            }
        }

        private void txtNumarPref_Enter(object sender, EventArgs e)
        {
            if (txtNumarPref.Text == "*Număr Preferențial")
            {
                txtNumarPref.Text = "";
            }
        }

        private void txtNumarPref_Leave(object sender, EventArgs e)
        {
            if (txtNumarPref.Text == "")
            {
                txtNumarPref.Text = "*Număr Preferențial";
            }
        }

        private void txtRural_Enter(object sender, EventArgs e)
        {
            if (txtRural.Text == "Rural")
            {
                txtRural.Text = "";
            }
        }

        private void txtRural_Leave(object sender, EventArgs e)
        {
            if (txtRural.Text == "")
            {
                txtRural.Text = "Rural";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtTaxeID.Text == "*Taxe ID" ||
               txtVehiculID.Text == "*Vehicul ID" ||
               txtNrInm.Text == "*Număr Înmatriculare" ||
               txtImpozit.Text == "*Impozit" ||
               txtAsigurare.Text == "*Asigurare" ||
               txtNumarPref.Text == "Număr Preferențial")
            {
                MessageBox.Show("Nu ați completat câmpurile obligatorii!");
            }
            else
            {
                if(txtRovinieta.Text == "Rovinietă")
                {
                    txtRovinieta.Text = "0";
                }

                if(txtCasco.Text == "Casco")
                {
                    txtCasco.Text = "0";
                }

                if( txtRural.Text == "Rural")
                {
                    txtRural.Text = "\0";
                }

                string connectionString = @"Data Source = DESKTOP-D97BUTD; Initial Catalog = Evidenta masinilor inmatriculate la nivel de judet; Integrated Security = True;";
                string parameters = " (Taxe_ID, Vehicul_ID, Numar_Inmatriculare, Impozit, Asigurare, Rovinieta, Casco, Numar_Preferential, Rural) ";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO " + TABLES.table + parameters + "VALUES ('" + txtTaxeID.Text + "', '" + txtVehiculID.Text + "', '" + txtNrInm.Text + "', " + txtImpozit.Text + ", " + txtAsigurare.Text + ", " + txtRovinieta.Text + ", " + txtCasco.Text + ", '" + txtNumarPref.Text + "', '" + txtRural.Text + "');", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost introduse cu succes!");
                    con.Close();
                    new INSERTTAXE().Show();
                    this.Hide();
                }
            }
        }
    }
}
