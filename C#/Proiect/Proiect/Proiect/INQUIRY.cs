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
    public partial class INQUIRY : Form
    {
        public static int ceva;
        public INQUIRY()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            new ADMIN().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ceva = 0;
            new SIMPLE().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ceva = 1;
            new COMPLEX().Show();
            this.Hide();
        }
    }
}
