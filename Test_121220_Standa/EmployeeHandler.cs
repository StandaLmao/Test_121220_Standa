using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Common;
using System.Windows.Forms;

namespace Test_121220_Standa
{
    internal class EmployeeHandler
    {
        private static readonly string CONNECTION_STRING = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SheeshDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        private static readonly SqlConnection connection = new SqlConnection(CONNECTION_STRING);

        public static void Insert(Employee employee)
        {
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            setCommandParams(command, employee);
            command.CommandText = "INSERT INTO Employees Values (@firstName,@lastName,@phoneNum,@email,@birthDate)";
            command.ExecuteNonQuery();
            connection.Close();
        }

        public static void Update(int id, Employee employee)
        {
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.Parameters.AddWithValue("id", id);
            setCommandParams(command, employee);
            command.CommandText = "UPDATE Employees SET firstName=@firstName, lastName=@lastName, phoneNum=@phoneNum, email=@email, birthDate=@birthDate WHERE id=@id";
            command.ExecuteNonQuery();
            connection.Close();
        }

        public static void Delete(int id)
        {
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.Parameters.AddWithValue("id", id);
            command.CommandText = "DELETE FROM Employees WHERE id=@id";
            command.ExecuteNonQuery();
            connection.Close();
        }

        public static List<Employee> ReadTable()
        {
            List<Employee> employees = new List<Employee>();
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM Employees";
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                employees.Add(new Employee((int)reader[0],reader[1].ToString(), reader[2].ToString(),reader[3].ToString(), reader[4].ToString(), reader[5].ToString()));
            }
            connection.Close();
            return employees;
            
        }

        public static Employee ReadOne(int id)
        {
            Employee employee = new Employee(-1,"","","","","");
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.Parameters.AddWithValue("id", id);
            command.CommandText = "SELECT * FROM Employees WHERE id=@id";
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                employee = new Employee((int)reader[0], reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString());
            }
            connection.Close();
            return employee;
        }

        public static void setCommandParams(SqlCommand command, Employee employee)
        {
            command.Parameters.AddWithValue("firstName", employee.firstName);
            command.Parameters.AddWithValue("lastName", employee.lastName);
            command.Parameters.AddWithValue("phoneNum", employee.phoneNum);
            command.Parameters.AddWithValue("email", employee.email);
            command.Parameters.AddWithValue("birthDate", employee.birthDate);
        }

        public static List<int> getIdsList()
        {
            List<int> ids = new List<int>();
            List<Employee> employees = ReadTable();
            employees.ForEach((e) => { ids.Add(e.id); });
            return ids;
        }
    }
}
