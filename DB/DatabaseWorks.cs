using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DB
{
    internal class DatabaseWorks
    {
       public SqlConnection connection;

        public DatabaseWorks(string credentials)
        {
            connection = new SqlConnection(credentials);
            connection.Open();
        }

        public DataSet ReturnTable(string Columns, string TablesName, string Arguments)
        {
            SqlDataAdapter sqlData = new SqlDataAdapter($"SELECT {Columns} FROM {TablesName} {Arguments}", connection);
            DataSet dataset = new DataSet();
            sqlData.Fill(dataset);
            return dataset;
        }

        public string Addtypeauto(string name)
        {
            try 
            {
                SqlCommand command = new SqlCommand(
                    $"INSERT INTO DB2.dbo.type_auto (name) values ('{name}');", connection);
                return $"comand complete: {command.ExecuteNonQuery()}";
            }
            catch (Exception e)
            {
                return e.ToString();
            }

        }

        public string Addstatus_load(string name)
        {
            try
            {
                SqlCommand command = new SqlCommand(
                    $"INSERT INTO DB2.dbo.status_load (name) values ('{name}');", connection);
                return $"comand complete: {command.ExecuteNonQuery()}";
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }

        public string Addtype_street(string name)
        {
            try
            {
                SqlCommand command = new SqlCommand(
                    $"INSERT INTO DB2.dbo.type_street (name) values ('{name}');", connection);
                return $"comand complete: {command.ExecuteNonQuery()}";
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }

        public string AddDriver(string name, string surname, string patron)
        {
            try
            {
                SqlCommand command = new SqlCommand(
                    $"INSERT INTO DB2.dbo.driver (name, surname, patronymic) values ('{name}', '{surname}', '{patron}');", connection);
                return $"comand complete: {command.ExecuteNonQuery()}";
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }

        public string AddAuto(string name, string number, string driverId, string autoTypeId)
        {
            try
            {
                SqlCommand command = new SqlCommand(
                    $"INSERT INTO DB2.dbo.auto (name, number, driver_id, type_auto_id) values ('{name}', '{number}', '{driverId}', '{autoTypeId}');", connection);
                return $"comand complete: {command.ExecuteNonQuery()}";
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }
    }
}
