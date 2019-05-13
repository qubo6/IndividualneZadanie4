using Data.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class EmployeeRepository : ConnectionManger
    {
        public int InsertDirector(ModelEmployee modelEmployee)
        {
            int ret = -1;
            Execute((command) =>
            {
                command.CommandText = @"Insert into employee ([Title], [FirstName], [LastName], [Phone], [Email])
                                    OUTPUT INSERTED.Id
                                    Values(@Title, @First, @Last, @Phone, @Email)";
                command.Parameters.Add("@Title", SqlDbType.VarChar).Value = modelEmployee.Title;
                command.Parameters.Add("@First", SqlDbType.VarChar).Value = modelEmployee.FirstName;
                command.Parameters.Add("@Last", SqlDbType.VarChar).Value = modelEmployee.LastName;
                command.Parameters.Add("@Phone", SqlDbType.VarChar).Value = modelEmployee.Phone;
                command.Parameters.Add("@Email", SqlDbType.VarChar).Value = modelEmployee.Email;
                ret = (int)command.ExecuteScalar();
            });
            return ret;
        }

        public int InsertEmployee(ModelEmployee modelEmployee)
        {
            int ret = -1;
            Execute((command) =>
            {
                command.CommandText = @"Insert into employee ([Title], [FirstName], [LastName], [Phone], [Email], [WorkAtID])
                                    OUTPUT INSERTED.Id
                                    Values(@Title, @First, @Last, @Phone, @Email, @WorkAt)";
                command.Parameters.Add("@Title", SqlDbType.VarChar).Value = modelEmployee.Title;
                command.Parameters.Add("@First", SqlDbType.VarChar).Value = modelEmployee.FirstName;
                command.Parameters.Add("@Last", SqlDbType.VarChar).Value = modelEmployee.LastName;
                command.Parameters.Add("@Phone", SqlDbType.VarChar).Value = modelEmployee.Phone;
                command.Parameters.Add("@Email", SqlDbType.VarChar).Value = modelEmployee.Email;
                command.Parameters.Add("@WorkAt", SqlDbType.Int).Value = modelEmployee.WorkAtSectionId;
                ret = (int)command.ExecuteScalar();
            });
            return ret;
        }

        public List<ModelEmployee> GetAllEmployees()
        {
            List<ModelEmployee> employeeList = new List<ModelEmployee>();
            Execute((command) =>
                {
                command.CommandText = "select * from employee";
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                        {
                            int personId = reader.GetInt32(0);
                            string title = reader.GetString(1);
                            string first = reader.GetString(2);
                            string last = reader.GetString(3);
                            string phone = reader.GetString(4);
                            string email = reader.GetString(5);
                            int? workAt = reader.IsDBNull(6) ? null : (int?)reader.GetInt32(6);
                            employeeList.Add(new ModelEmployee(personId, title, first, last, phone, email, workAt));
                        }
                    }
                });
            return employeeList;
        }

        public bool DeleteEmployee(int idEmployee)
        {
            bool succes = false;
            Execute((command) =>
            {
                command.CommandText = "delete from employee where id=@idEmp";
                command.Parameters.Add("@idEmp", SqlDbType.Int).Value = idEmployee;
                if (command.ExecuteNonQuery()>0)
                {
                    succes = true;
                }
            });
            return succes;
        }
    }
}
