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
    public partial class INQUIRYDISPLAY : Form
    {
        public INQUIRYDISPLAY()
        {
            InitializeComponent();
            afisare();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (INQUIRY.ceva == 0)
                new SIMPLE().Show();
            else
                new COMPLEX().Show();
            this.Hide();
        }

        private void afisare()
        {
            string operatie = "";
            if (INQUIRY.ceva == 0)
            {
                operatie = SIMPLE.operation;
                txtenunt.Text = SIMPLE.enunt;
            }
            else
            {
                operatie = COMPLEX.operation;
                txtenunt.Text = COMPLEX.enunt;
            }

            string connectionString = @"Data Source = DESKTOP-D97BUTD; Initial Catalog = Evidenta masinilor inmatriculate la nivel de judet; Integrated Security = True;";
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter(operatie , sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dataGridView1.DataSource = dtbl;
                sqlCon.Close();
            }
        }
        
    }
}
