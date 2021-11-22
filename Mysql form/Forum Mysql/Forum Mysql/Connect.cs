using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum_Mysql
{
    class Connect
    {
        
        public string ConnectionCode()
        {
            return "datasource=loccalhost; port=3306;username=root;password=;database:students";
        }

        private MySqlConnection connect = new MySqlConnection("datasource=localhost; port=3306;username=root;password=;database=students");

        public MySqlConnection Inject()
        {
            return connect;
        }

        public void StartConnection()
        {

            if (connect.State == System.Data.ConnectionState.Closed)
            {
                connect.Open();
            }

        }

        public void CloseConnection()
        {
            if (connect.State == System.Data.ConnectionState.Open)
            {
                connect.Close();
            }
        }


    }
}
