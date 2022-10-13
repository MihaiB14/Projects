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
    public partial class INSERTCOMP : Form
    {
        public INSERTCOMP()
        {
            InitializeComponent();
            afisare();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            new TABLES().Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCompanieID_Enter(object sender, EventArgs e)
        {
            if(txtCompanieID.Text == "*Companie ID")
            {
                txtCompanieID.Text = "";
            }
        }

        private void txtCompanieID_Leave(object sender, EventArgs e)
        {
            if (txtCompanieID.Text == "")
            {
                txtCompanieID.Text = "*Companie ID";
            }
        }

        private void txtNume_Enter(object sender, EventArgs e)
        {
            if(txtNume.Text == "*Nume")
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

        private void txtCodFiscal_Enter(object sender, EventArgs e)
        {
            if(txtCodFiscal.Text == "*Cod Fiscal")
            {
                txtCodFiscal.Text = "";
            }
        }

        private void txtCodFiscal_Leave(object sender, EventArgs e)
        {
            if (txtCodFiscal.Text == "")
            {
                txtCodFiscal.Text = "*Cod Fiscal";
            }
        }

        private void txtNumarInreg_Enter(object sender, EventArgs e)
        {
            if(txtNumarInreg.Text == "*Număr Înregistrare")
            {
                txtNumarInreg.Text = "";
            }
        }

        private void txtNumarInreg_Leave(object sender, EventArgs e)
        {
            if (txtNumarInreg.Text == "")
            {
                txtNumarInreg.Text = "*Număr Înregistrare";
            }
        }

        private void txtDataInfiint_Enter(object sender, EventArgs e)
        {
            if(txtDataInfiint.Text == "*Data Înființării")
            {
                txtDataInfiint.Text = "";
            }
        }

        private void txtDataInfiint_Leave(object sender, EventArgs e)
        {
            if (txtDataInfiint.Text == "")
            {
                txtDataInfiint.Text = "*Data Înființării";
            }
        }

        private void txtStrada_Enter(object sender, EventArgs e)
        {
            if(txtStrada.Text == "*Strada")
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
            if(txtNumar.Text == "*Număr")
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
            if(txtOras.Text == "*Oraș")
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

        private void txtJudetSector_Enter(object sender, EventArgs e)
        {
            if(txtJudetSector.Text == "Județ / Sector")
            {
                txtJudetSector.Text = "";
            }
        }

        private void txtJudetSector_Leave(object sender, EventArgs e)
        {
            if (txtJudetSector.Text == "")
            {
                txtJudetSector.Text = "Județ / Sector";
            }
        }

        private void txtDirector_Enter(object sender, EventArgs e)
        {
            if(txtDirector.Text == "*Director")
            {
                txtDirector.Text = "";
            }
        }

        private void txtDirector_Leave(object sender, EventArgs e)
        {
            if (txtDirector.Text == "")
            {
                txtDirector.Text = "*Director";
            }
        }

        private void txtContact_Enter(object sender, EventArgs e)
        {
            if(txtContact.Text == "Contact")
            {
                txtContact.Text = "";
            }
        }

        private void txtContact_Leave(object sender, EventArgs e)
        {
            if (txtContact.Text == "")
            {
                txtContact.Text = "Contact";
            }
        }
        private void afisare()
        {
            string connectionString = @"Data Source = DESKTOP-D97BUTD; Initial Catalog = Evidenta masinilor inmatriculate la nivel de judet; Integrated Security = True;";
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM " + TABLES.table , sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dataGridView1.DataSource = dtbl;
                sqlCon.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtNumarInreg.Text == "*Număr Înregistrare" ||
                txtNume.Text == "*Nume" ||
                txtNumar.Text == "*Numar" ||
                txtCodFiscal.Text == "*Cod Fical" ||
                txtCompanieID.Text == "*Companie ID" ||
                txtStrada.Text == "*Strada" ||
                txtOras.Text == "*Oraș" ||
                txtDirector.Text == "*Director" ||
                txtDataInfiint.Text == "*Data Înființării")
            {
                MessageBox.Show("Nu ați completat câmpurile obligatorii!");
            }
            else
            {
                if(txtJudetSector.Text == "Județ / Sector")
                {
                    txtJudetSector.Text = "\0";
                }

                if(txtContact.Text == "Contact")
                {
                    txtContact.Text = "\0";
                }

                string connectionString = @"Data Source = DESKTOP-D97BUTD; Initial Catalog = Evidenta masinilor inmatriculate la nivel de judet; Integrated Security = True;";
                string parameters = " (Companie_ID, Nume, Cod_Fiscal, Numar_Inregistrare, Data_infiintarii, Strada, Numar, Oras, Judet_Sector, Director, Contact) ";
                using (SqlConnection con = new SqlConnection(connectionString))
                { 
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO " + TABLES.table + parameters + "VALUES ('" + txtCompanieID.Text + "', '" + txtNume.Text + "', '" + txtCodFiscal.Text + "', '" + txtNumarInreg.Text + "', '" + txtDataInfiint.Text + "', '" + txtStrada.Text + "', '" + txtNumar.Text + "', '" + txtOras.Text + "', '" + txtJudetSector.Text + "', '" + txtDirector.Text + "', '" + txtContact.Text + "');", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost introduse cu succes!");
                    con.Close();
                    new INSERTCOMP().Show();
                    this.Hide();
                }
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtCompanieID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
