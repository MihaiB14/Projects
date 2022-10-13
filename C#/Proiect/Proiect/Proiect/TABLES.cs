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
    public partial class TABLES : Form
    {
        public static string table = "";
        public TABLES()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            table = "Taxe";
            if (LOGIN.k == "user")
            {
                new DISPLAY().Show();
            }
            else
            {
                switch (ADMIN.mod)
                {
                    case "display":
                        new DISPLAY().Show();
                        break;

                    case "insert":
                        new INSERTTAXE().Show();
                        break;

                    case "update":

                        break;
                }
            }
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if(LOGIN.k == "user")
            {
                new USER().Show();
            }
            else
            {
                new ADMIN().Show();
            }
            this.Hide();
        }

        private void TABLES_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            table = "Companie";
            if(LOGIN.k == "user")
            {
                new DISPLAY().Show();
            }
            else
            {
                switch(ADMIN.mod)
                {
                    case "display":
                        new DISPLAY().Show();
                        break;

                    case "insert":
                        new INSERTCOMP().Show();
                        break;

                    case "update":

                        break;
                }
            }
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            table = "Persoana";
            if (LOGIN.k == "user")
            {
                new DISPLAY().Show();
            }
            else
            {
                switch (ADMIN.mod)
                {
                    case "display":
                        new DISPLAY().Show();
                        break;

                    case "insert":
                        new INSERTPERS().Show();
                        break;

                    case "update":

                        break;
                }
            }
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            table = "Vehicul";
            if (LOGIN.k == "user")
            {
                new DISPLAY().Show();  
            }
            else
            {
                switch (ADMIN.mod)
                {
                    case "display":
                        new DISPLAY().Show();
                        break;

                    case "insert":
                        new INSERTVEH().Show();
                        break;

                    case "update":

                        break;
                }
            }
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            table = "Vehicul_Daune";
            if (LOGIN.k == "user")
            {
                new DISPLAY().Show();
            }
            else
            {
                switch (ADMIN.mod)
                {
                    case "display":
                        new DISPLAY().Show();
                        break;

                    case "insert":
                        new INSERTVEHDAUN().Show();
                        break;

                    case "update":

                        break;
                }
            }
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            table = "Daune";
            if (LOGIN.k == "user")
            {
                new DISPLAY().Show();
            }
            else
            {
                switch (ADMIN.mod)
                {
                    case "display":
                        new DISPLAY().Show();
                        break;

                    case "insert":
                        new INSERTDAUN().Show();
                        break;

                    case "update":

                        break;
                }
            }
            this.Hide();
        }
    }
}