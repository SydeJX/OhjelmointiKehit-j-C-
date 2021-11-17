using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Forum_Mysql
{
    class Students
    {

        Connect connect = new Connect();

        public bool AddStudents(int Old, string Fname, string Lname, string email, string phone, int StudentNumber)
        {
            MySqlCommand Command = new MySqlCommand();
            string AddQuestion = "INSERT INTO information " +
                "(Old, FirstName, LastName, Email, StudentNumber) " +
                "VALUES (@old, @enm, @snm, @eml, @puh, @ono); ";

            Command.CommandText = AddQuestion;
            Command.Connection = connect.Inject();

            Command.Parameters.Add("@old", MySqlDbType.VarChar).Value = Old;
            Command.Parameters.Add("@enm", MySqlDbType.VarChar).Value = Fname;
            Command.Parameters.Add("@snm", MySqlDbType.VarChar).Value = Lname;
            Command.Parameters.Add("@eml", MySqlDbType.VarChar).Value = email;
            Command.Parameters.Add("@puh", MySqlDbType.VarChar).Value = phone;
            Command.Parameters.Add("@ono", MySqlDbType.VarChar).Value = StudentNumber;






            return false;
        }




    }
}
