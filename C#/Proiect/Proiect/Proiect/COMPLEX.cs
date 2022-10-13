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
    public partial class COMPLEX : Form
    {
        public static string operation = "";
        public static string enunt = "";
        public COMPLEX()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            new INQUIRY().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            operation = "SELECT C.Nume, C.Cod_Fiscal FROM Companie C inner JOIN Vehicul V ON C.Companie_ID = V.Companie_ID WHERE(SELECT COUNT(VD.Vehicul_ID) FROM Vehicul_Daune VD WHERE V.Vehicul_ID = VD.Vehicul_ID) = 0;";
            enunt = "Companiile care au cel puțin un vehicul fară daune";
            new INQUIRYDISPLAY().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            operation = "SELECT V.Marca, V.Model, V.Serie_Sasiu FROM Vehicul V inner JOIN Vehicul_Daune VD ON V.Vehicul_ID = VD.Vehicul_ID WHERE(SELECT SUM(D.Frontal + D.Lateral_Dreapta + D.Lateral_Stanga + D.Posterior)  FROM Daune D WHERE D.Daune_ID = VD.Daune_ID) > (SELECT AVG(D.Frontal + D.Lateral_Dreapta + D.Lateral_Stanga + D.Posterior) FROM Daune D); ";
            enunt = "Vehiculele care au totalul daunelor mai mare decat media tuturor daunelor inregistrate";
            new INQUIRYDISPLAY().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            operation = "SELECT C.Nume, C.Cod_Fiscal, (SELECT COUNT(*) FROM Vehicul V Where C.Companie_ID = V.Companie_ID AND 'D' = (SELECT T.Numar_Preferential FROM TAXE T WHERE T.Vehicul_ID = V.Vehicul_ID)) Numar_Vehicule FROM Companie C;";
            enunt = "Numărul vehiculelor cu numar preferential pentru fiecare companie";
            new INQUIRYDISPLAY().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            operation = "SELECT P.Nume, P.Prenume, P.CNP, V.Putere FROM Persoana P inner JOIN Vehicul V ON P.Persoana_ID = V.Persoana_ID WHERE V.Vehicul_ID not in (SELECT VD.Vehicul_ID FROM Vehicul_Daune VD WHERE V.Vehicul_ID = VD.Vehicul_ID GROUP BY VD.Vehicul_ID) AND V.Putere >= 100;";
            enunt = "Persoanele care nu au avut nicio daună cu vehicule care au puterea mai mare sau egală cu 100KW";
            new INQUIRYDISPLAY().Show();
            this.Hide();
        }
    }
}
