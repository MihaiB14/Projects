namespace Proiect
{
    public partial class LOGIN : Form
    {
        public static string k = "user";
        public LOGIN()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text == "user" && txtPassword.Text == "1234")
            {
                new USER().Show();
                this.Hide();
            }
            else
            {
                if (txtUserName.Text == "admin" && txtPassword.Text == "admin")
                {
                    k = "admin";
                    new ADMIN().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Numele de utilizator sau parolă incorectă, încercați din nou.");
                    txtUserName.Clear();
                    txtPassword.Clear();
                    txtUserName.Focus();
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPassword.Clear();
            txtUserName.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                txtShowText.BringToFront();
                txtPassword.PasswordChar = '*';
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(txtPassword.PasswordChar == '*')
            {
                txtHideText.BringToFront();
                txtPassword.PasswordChar = '\0';
            }
        }

        private void txtUserName_Enter_TextChanged(object sender, EventArgs e)
        {
            if(txtUserName.Text == "User Name")
            {
                txtUserName.Text = "";
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
                txtPassword.PasswordChar = '*';
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password";
                txtPassword.PasswordChar = '\0';
            }
        }

        private void txtUserName_Enter(object sender, EventArgs e)
        {
            if(txtUserName.Text == "User Name")
            {
                txtUserName.Text = "";
            }
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                txtUserName.Text = "User Name";
            }
        }
    }
}