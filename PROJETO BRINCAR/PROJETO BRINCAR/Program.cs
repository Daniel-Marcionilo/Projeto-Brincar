using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;



namespace PROJETO_BRINCAR
{
    static class Program
    {

        public static MySqlConnection conexao = new MySqlConnection();
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            conexao.ConnectionString = "database=projeto_brincar; server=localhost; uid=root; pwd=1234; SSLmode=none";
            //conexao.Open();
            
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmBrincar());

        }
        
        
        


 
    }
}
