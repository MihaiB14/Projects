using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    public partial class TABLES2DELETE : Form
    {
        public static string table = "Companie";
        public TABLES2DELETE()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            new ADMIN().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new DELETECOMP().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            table = "Persoana";
            new DELETEPERSON().Show();
            this.Hide();
        }
    }
}
