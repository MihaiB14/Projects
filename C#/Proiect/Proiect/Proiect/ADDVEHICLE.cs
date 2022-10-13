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
    public partial class INSERTVEH : Form
    {
        public INSERTVEH()
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            new TABLES().Show();
            this.Hide();
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

        private void txtCompanieID_Enter(object sender, EventArgs e)
        {
            if (txtCompanieID.Text == "Companie ID")
            {
                txtCompanieID.Text = "";
            }
        }

        private void txtCompanieID_Leave(object sender, EventArgs e)
        {
            if (txtCompanieID.Text == "")
            {
                txtCompanieID.Text = "Companie ID";
            }
        }

        private void txtPersoanaID_Enter(object sender, EventArgs e)
        {
            if (txtPersoanaID.Text == "Persoana ID")
            {
                txtPersoanaID.Text = "";
            }
        }

        private void txtPersoanaID_Leave(object sender, EventArgs e)
        {
            if (txtPersoanaID.Text == "")
            {
                txtPersoanaID.Text = "Persoana ID";
            }
        }

        private void txtTipVeh_Enter(object sender, EventArgs e)
        {
            if (txtTipVeh.Text == "*Tip Vehicul")
            {
                txtTipVeh.Text = "";
            }
        }

        private void txtTipVeh_Leave(object sender, EventArgs e)
        {
            if (txtTipVeh.Text == "")
            {
                txtTipVeh.Text = "*Tip Vehicul";
            }
        }

        private void txtSerieSas_Enter(object sender, EventArgs e)
        {
            if (txtSerieSas.Text == "*Serie Șasiu")
            {
                txtSerieSas.Text = "";
            }
        }

        private void txtSerieSas_Leave(object sender, EventArgs e)
        {
            if (txtSerieSas.Text == "")
            {
                txtSerieSas.Text = "*Serie Șasiu";
            }
        }

        private void txtMarca_Enter(object sender, EventArgs e)
        {
            if (txtMarca.Text == "*Marca")
            {
                txtMarca.Text = "";
            }
        }

        private void txtMarca_Leave(object sender, EventArgs e)
        {
            if (txtMarca.Text == "")
            {
                txtMarca.Text = "*Marca";
            }
        }

        private void txtModel_Enter(object sender, EventArgs e)
        {
            if (txtModel.Text == "*Model")
            {
                txtModel.Text = "";
            }
        }

        private void txtModel_Leave(object sender, EventArgs e)
        {
            if (txtModel.Text == "")
            {
                txtModel.Text = "*Model";
            }
        }

        private void txtCombustibil_Enter(object sender, EventArgs e)
        {
            if (txtCombustibil.Text == "*Combustibil")
            {
                txtCombustibil.Text = "";
            }
        }

        private void txtCombustibil_Leave(object sender, EventArgs e)
        {
            if (txtCombustibil.Text == "")
            {
                txtCombustibil.Text = "*Combustibil";
            }
        }

        private void txtCapacCil_Enter(object sender, EventArgs e)
        {
            if (txtCapacCil.Text == "*Capacitate Cilindrică")
            {
                txtCapacCil.Text = "";
            }
        }

        private void txtCapacCil_Leave(object sender, EventArgs e)
        {
            if (txtCapacCil.Text == "")
            {
                txtCapacCil.Text = "*Capacitate Cilindrică";
            }
        }

        private void txtPutere_Enter(object sender, EventArgs e)
        {
            if (txtPutere.Text == "*Putere")
            {
                txtPutere.Text = "";
            }
        }

        private void txtPutere_Leave(object sender, EventArgs e)
        {
            if (txtPutere.Text == "")
            {
                txtPutere.Text = "*Putere";
            }
        }

        private void txtAn_Enter(object sender, EventArgs e)
        {
            if (txtAn.Text == "*An Fabricație")
            {
                txtAn.Text = "";
            }
        }

        private void txtAn_Leave(object sender, EventArgs e)
        {
            if (txtAn.Text == "")
            {
                txtAn.Text = "*An Fabricație";
            }
        }

        private void txtMasa_Enter(object sender, EventArgs e)
        {
            if (txtMasa.Text == "*Masă Totală")
            {
                txtMasa.Text = "";
            }
        }

        private void txtMasa_Leave(object sender, EventArgs e)
        {
            if (txtMasa.Text == "")
            {
                txtMasa.Text = "*Masă Totală";
            }
        }

        private void txtNoxe_Enter(object sender, EventArgs e)
        {
            if (txtNoxe.Text == "*Noxe")
            {
                txtNoxe.Text = "";
            }
        }

        private void txtNoxe_Leave(object sender, EventArgs e)
        {
            if (txtNoxe.Text == "")
            {
                txtNoxe.Text = "*Noxe";
            }
        }

        private void txtNumarLoc_Enter(object sender, EventArgs e)
        {
            if (txtNumarLoc.Text == "*Număr Locuri")
            {
                txtNumarLoc.Text = "";
            }
        }

        private void txtNumarLoc_Leave(object sender, EventArgs e)
        {
            if (txtNumarLoc.Text == "")
            {
                txtNumarLoc.Text = "*Număr Locuri";
            }
        }

        private void txtCuloare_Enter(object sender, EventArgs e)
        {
            if (txtCuloare.Text == "Culoare")
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
            if (txtVehiculID.Text == "*Vehicul ID" ||
                txtTipVeh.Text == "*Tip Vehicul" ||
                txtSerieSas.Text == "*Serie Șasiu" ||
                txtMarca.Text == "*Marca" ||
                txtModel.Text == "*Model" ||
                txtCombustibil.Text == "*Combustibil" ||
                txtCapacCil.Text == "Capcitate Cilindrică" ||
                txtPutere.Text == "*Putere" ||
                txtAn.Text =="*An Fabricație" ||
                txtMasa.Text == "*Masă Totală" ||
                txtNoxe.Text == "*Noxe" ||
                txtNumarLoc.Text == "Număr Locuri")
            {
                MessageBox.Show("Nu ați completat câmpurile obligatorii!");
            }
            else
            {
                if(txtCompanieID.Text == "Companie ID" && txtPersoanaID.Text == "Persoana ID")
                {
                    MessageBox.Show("Nu ați completat unul din câmpurile Vehicul ID sau Companie ID!");
                }
                else
                {
                        if(txtCompanieID.Text == "Companie ID")
                        {
                            txtCompanieID.Text = "null";
                        }

                        if(txtPersoanaID.Text == "Persoana ID")
                        {
                            txtPersoanaID.Text = "null";
                        }

                        if(txtCuloare.Text == "Culoare")
                        {
                            txtCuloare.Text = "\0";
                        }

                        string connectionString = @"Data Source = DESKTOP-D97BUTD; Initial Catalog = Evidenta masinilor inmatriculate la nivel de judet; Integrated Security = True;";
                        string parameters = " (Vehicul_ID, Companie_ID, Persoana_ID, Tip_Vehicul, Serie_Sasiu, Marca, Model, Combustibil, Capacitate_Cilindrica, Putere, An_Fabricatie, Masa_Totala, Noxe, Numar_Locuri, Culoare) ";
                        using (SqlConnection con = new SqlConnection(connectionString))
                        {
                            con.Open();
                            SqlCommand cmd = new SqlCommand("INSERT INTO " + TABLES.table + parameters + "VALUES ('" + txtVehiculID.Text + "', " + txtCompanieID.Text + ", " + txtPersoanaID.Text + ", '" + txtTipVeh.Text + "', '" + txtSerieSas.Text + "', '" + txtMarca.Text + "', '" + txtModel.Text + "', '" + txtCombustibil.Text + "', '" + txtCapacCil.Text + "', '" + txtPutere.Text + "', '" + txtAn.Text + "', '" + txtMasa.Text + "', '" + txtNoxe.Text + "', '" + txtNumarLoc.Text + "', '" + txtCuloare.Text + "');", con);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Datele au fost introduse cu succes!");
                            con.Close();
                            new INSERTVEH().Show();
                            this.Hide();
                        }

                    
                }
            }    
        }
    }
}
