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
    public partial class INSERTPERS : Form
    {
        public INSERTPERS()
        {
            InitializeComponent();
            afisare();
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

        private void txtPersoanaID_Enter(object sender, EventArgs e)
        {
            if (txtPersoanaID.Text == "*Persoană ID")
            {
                txtPersoanaID.Text = "";
            }
        }

        private void txtPersoanaID_Leave(object sender, EventArgs e)
        {
            if (txtPersoanaID.Text == "")
            {
                txtPersoanaID.Text = "*Persoană ID";
            }
        }

        private void txtNume_Enter(object sender, EventArgs e)
        {
            if (txtNume.Text == "*Nume")
            {
                txtNume.Text = "";
            }
        }

        private void txtNume_Leave(object sender, EventArgs e)
        {
            if (txtNume.Text == "")
            {
                txtNume.Text = "*Nume";
            }
        }

        private void textPrenume_Enter(object sender, EventArgs e)
        {
            if (txtPrenume.Text == "*Prenume")
            {
                txtPrenume.Text = "";
            }
        }

        private void txtPrenume_Leave(object sender, EventArgs e)
        {
            if (txtPrenume.Text == "")
            {
                txtPrenume.Text = "*Prenume";
            }
        }

        private void txtCNP_Enter(object sender, EventArgs e)
        {
            if (txtCNP.Text == "*CNP")
            {
                txtCNP.Text = "";
            }
        }

        private void txtCNP_Leave(object sender, EventArgs e)
        {
            if (txtCNP.Text == "")
            {
                txtCNP.Text = "*CNP";
            }
        }

        private void txtStrada_Enter(object sender, EventArgs e)
        {
            if (txtStrada.Text == "*Strada")
            {
                txtStrada.Text = "";
            }
        }

        private void txtStrada_Leave(object sender, EventArgs e)
        {
            if (txtStrada.Text == "")
            {
                txtStrada.Text = "*Strada";
            }

        }

        private void txtNumar_Enter(object sender, EventArgs e)
        {
            if (txtNumar.Text == "*Număr")
            {
                txtNumar.Text = "";
            }
        }

        private void txtNumar_Leave(object sender, EventArgs e)
        {
            if (txtNumar.Text == "")
            {
                txtNumar.Text = "*Număr";
            }
        }

        private void txtOras_Enter(object sender, EventArgs e)
        {
            if (txtOras.Text == "*Oraș")
            {
                txtOras.Text = "";
            }
        }

        private void txtOras_Leave(object sender, EventArgs e)
        {
            if (txtOras.Text == "")
            {
                txtOras.Text = "*Oraș";
            }
        }

        private void textBox7_Enter(object sender, EventArgs e)
        {
            if (txtJudetSec.Text == "Județ / Sector")
            {
                txtJudetSec.Text = "";
            }
        }

        private void txtJudetSec_Leave(object sender, EventArgs e)
        {
            if (txtJudetSec.Text == "")
            {
                txtJudetSec.Text = "Județ / Sector";
            }
        }

        private void txtSex_Enter(object sender, EventArgs e)
        {
            if (txtSex.Text == "*Sex")
            {
                txtSex.Text = "";
            }
        }

        private void txtSex_Leave(object sender, EventArgs e)
        {
            if (txtSex.Text == "")
            {
                txtSex.Text = "*Sex";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPersoanaID.Text == "*Persoană ID" ||
                txtNume.Text == "*Nume" ||
                txtPrenume.Text == "*Prenume" ||
                txtCNP.Text == "*CNP" ||
                txtStrada.Text == "*Strada" ||
                txtNumar.Text == "*Număr" ||
                txtOras.Text == "*Oraș" ||
                txtSex.Text == "*Sex")
            {
                MessageBox.Show("Nu ați completat câmpurile obligatorii!");
            }
            else
            {
                if (txtJudetSec.Text == "Județ / Sector")
                {
                    txtJudetSec.Text = "\0";
                }

                string connectionString = @"Data Source = DESKTOP-D97BUTD; Initial Catalog = Evidenta masinilor inmatriculate la nivel de judet; Integrated Security = True;";
                string parameters = " (Persoana_ID, Nume, Prenume, CNP, Strada, Numar, Oras, Judet_Sector, Sex) ";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO " + TABLES.table + parameters + "VALUES ('" + txtPersoanaID.Text + "', '" + txtNume.Text + "', '" + txtPrenume.Text + "', '" + txtCNP.Text + "', '" + txtStrada.Text + "', '" + txtNumar.Text + "', '" + txtOras.Text + "', '" + txtJudetSec.Text + "', '" + txtSex.Text + "');", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost introduse cu succes!");
                    con.Close();
                    new INSERTPERS().Show();
                    this.Hide();
                }
            }
                
        }
    }
}
