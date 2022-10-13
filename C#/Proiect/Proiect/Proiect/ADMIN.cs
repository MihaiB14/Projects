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
    public partial class ADMIN : Form
    {
        public static string mod = "";
        public ADMIN()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mod = "insert";
            new TABLES().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LOGIN.k = "user";
            new LOGIN().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mod = "display";
            new TABLES().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new TABLES2DELETE().Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new TABELES2UPDATE().Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new INQUIRY().Show();
            this.Hide();
            
            this.Hide();
        }
    }
}
