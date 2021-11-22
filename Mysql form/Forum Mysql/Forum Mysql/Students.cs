using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.ComponentModel;
using System.Data;

namespace Forum_Mysql
{
    class Students
    {

        Connect connect = new Connect();

        public bool AddStudents(int Old, string Fname, string Lname, string email, string phone, int StudentNumber)
        {
            MySqlCommand Command = new MySqlCommand();
            string AddQuestion = "INSERT INTO female_students " +
                "(Old, FirstName, LastName, Email, Phone, StudentNumber) " +
                "VALUES (@old, @enm, @snm, @eml, @puh, @ono); ";

            Command.CommandText = AddQuestion;
            Command.Connection = connect.Inject();

            Command.Parameters.Add("@old", MySqlDbType.Int32).Value = Old;
            Command.Parameters.Add("@enm", MySqlDbType.VarChar).Value = Fname;
            Command.Parameters.Add("@snm", MySqlDbType.VarChar).Value = Lname;
            Command.Parameters.Add("@eml", MySqlDbType.VarChar).Value = email;
            Command.Parameters.Add("@puh", MySqlDbType.VarChar).Value = phone;
            Command.Parameters.Add("@ono", MySqlDbType.Int32).Value = StudentNumber;

            connect.StartConnection();
            if (Command.ExecuteNonQuery() == 1)
            {
                connect.CloseConnection();
                return true;
            }
            else
            {
                connect.CloseConnection();
                return false;
            }

        }

        public DataTable GetFemaleStudents()
        {
            MySqlCommand Command = new MySqlCommand("SELECT * FROM female_students", connect.Inject());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = Command;
            try
            {
                adapter.Fill(table);
                return table;
            }
            catch (Exception ex)
            {
                return table;
                
            }
        }

        public DataTable GetMaleStudents()
        {
            MySqlCommand Command = new MySqlCommand("SELECT * FROM male_students", connect.Inject());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = Command;
            try
            {
                adapter.Fill(table);
                
                return table;
            }
            catch (Exception ex)
            {
                return table;

            }
        }


        public bool EditStudents(int Old, string Fname, string Lname, string email, string phone, int StudentNumber)
        {

            MySqlCommand Command = new MySqlCommand();
            string UpdateQuestion = "UPDATE `female_students` SET " + 
                "`Firstname` = @enm, `Lastname` = @snm, `Email` = @eml, `Phone` = @puh, " +
                "`StudentNumber` = @ono WHERE Old = @old";
            //""

            Command.CommandText = UpdateQuestion;
            Command.Connection = connect.Inject();
            Command.Parameters.Add("@old", MySqlDbType.Int32).Value = Old;
            Command.Parameters.Add("@enm", MySqlDbType.VarChar).Value = Fname;
            Command.Parameters.Add("@snm", MySqlDbType.VarChar).Value = Lname;
            Command.Parameters.Add("@eml", MySqlDbType.VarChar).Value = email;
            Command.Parameters.Add("@puh", MySqlDbType.VarChar).Value = phone;
            Command.Parameters.Add("@ono", MySqlDbType.Int32).Value = StudentNumber;

            connect.StartConnection();
            if (Command.ExecuteNonQuery() == 1)
            {
                connect.CloseConnection();
                return true;
            }
            {

                connect.CloseConnection();
                return false;

            }

            
        }

        public bool DeleteStudent(string KnownN)
        {
            MySqlCommand command = new MySqlCommand();
            string deleteQuestion = "DELETE FROM yhteystiedot WHERE Old = @old";
            command.CommandText = deleteQuestion;
            command.Connection = connect.Inject();

            command.Parameters.Add("@old", MySqlDbType.UInt32).Value = KnownN;

            connect.StartConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.CloseConnection();
                return true;
            } else
            {
                connect.CloseConnection();
                return false;
            }


        }




    }
}
