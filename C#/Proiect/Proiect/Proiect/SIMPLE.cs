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
    
    public partial class SIMPLE : Form
    {
        public static string operation = "";
        public static string enunt = "";
        public SIMPLE()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            operation = "SELECT P.Nume, P.Prenume, P.CNP FROM Persoana P inner JOIN Vehicul V ON V.Persoana_ID = P.Persoana_ID WHERE V.Combustibil = 'B';";
            enunt = "Date despre persoanele care dețin Vehicule pe benzină";
            new INQUIRYDISPLAY().Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            new INQUIRY().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            operation = "SELECT C.Nume, C.Cod_Fiscal FROM Companie C inner JOIN Vehicul V ON V.Companie_ID = C.Companie_ID WHERE V.Combustibil = 'M'; ";
            enunt = "Date despre companiile ce dețin vehicule pe motorină";
            new INQUIRYDISPLAY().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            operation = "SELECT DISTINCT V.An_Fabricatie, V.Marca, V.Model, VD.Data FROM Vehicul V inner JOIN Vehicul_Daune VD ON V.Vehicul_ID = VD.Vehicul_ID WHERE YEAR(VD.Data) >= 2018;";
            enunt = "Date despre vehiculele care au avut daune înregistrate dupa anul 2018, inclusiv";
            new INQUIRYDISPLAY().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            operation = "SELECT C.Nume, C.Cod_Fiscal, COUNT(V.Vehicul_ID) Numar_Vehicule FROM Companie C inner JOIN Vehicul V ON C.Companie_ID = V.Companie_ID GROUP BY C.Companie_ID, C.Nume, C.Cod_Fiscal HAVING COUNT(V.Vehicul_ID) > 2;";
            enunt = "Date despre companiile care dețin mai mult de 2 vehicule";
            new INQUIRYDISPLAY().Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            operation = "SELECT V.Serie_Sasiu, V.Marca, V.Model, T.Casco FROM Vehicul V inner JOIN Taxe T ON V.Vehicul_ID = T.Vehicul_ID WHERE T.Casco <> 0; ";
            enunt = "Date despre vehiculele ce au casco";
            new INQUIRYDISPLAY().Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            operation = "SELECT P.Nume, P.CNP, V.An_Fabricatie FROM Vehicul V inner JOIN Persoana P ON V.Persoana_ID = P.Persoana_ID WHERE V.An_Fabricatie >= 2009; ";
            enunt = "Date despre persoanele ce dețin mașini mai noi de anul 2009, inclusiv";
            new INQUIRYDISPLAY().Show();
            this.Hide();
        }
    }
}
