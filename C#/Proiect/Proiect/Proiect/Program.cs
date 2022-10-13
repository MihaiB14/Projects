using System;
using System.Data.SqlClient;

namespace Proiect
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        
        [STAThread]
        static void Main()
        {

            //string connectionString = "Data Source = DESKTOP - D97BUTD; Initial Catalog = Evidenta masinilor inmatriculate la nivel de judet; Integrated Security = True";
            //SqlConnection con = new SqlConnection(connectionString);
            // con.Open();
           
            ApplicationConfiguration.Initialize();
            LOGIN f1 = new LOGIN();
            Application.Run(f1);
        }
    }
}