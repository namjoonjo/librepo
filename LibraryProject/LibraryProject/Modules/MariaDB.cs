using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Modules
{
    class MariaDB
    {

        private MySqlConnection conn = null;


        public MariaDB() 
        {
            string dbConnectionStr = ConfigurationManager.AppSettings["libdb"].ToString();

            getConnection(dbConnectionStr);
        }

        private void getConnection(string conStr)
        {
            try
            {
                conn = new MySqlConnection(conStr);
            }
            catch (Exception ex) 
            {

            }
        }
    }
}
