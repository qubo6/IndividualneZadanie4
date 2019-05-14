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
        public bool InsertEmployee(ModelEmployee modelEmployee)
        {
            bool success = false;
            Execute((command) =>
            {
                command.CommandText = @"Insert into employee ([Title], [FirstName], [LastName], [Phone], [Email])
                                    Values(@Title, @First, @Last, @Phone, @Email)";
                command.Parameters.Add("@Title", SqlDbType.VarChar).Value = modelEmployee.Title;
                command.Parameters.Add("@First", SqlDbType.VarChar).Value = modelEmployee.FirstName;
                command.Parameters.Add("@Last", SqlDbType.VarChar).Value = modelEmployee.LastName;
                command.Parameters.Add("@Phone", SqlDbType.VarChar).Value = modelEmployee.Phone;
                command.Parameters.Add("@Email", SqlDbType.VarChar).Value = modelEmployee.Email;
                if (command.ExecuteNonQuery()>0)
                {
                    success = true;
                }
            });
            return success;
        }

        public bool UpdateEmployeeWorkAt(ModelEmployee modelEmployee)
        {
            bool success = false;
            Execute((command) =>
            {
                command.CommandText = "update employee set WorkAtID= @WorkAt where id=@idEmployee";
                command.Parameters.Add("@WorkAt", SqlDbType.Int).Value = modelEmployee.WorkAtDepartmentId;
                command.Parameters.Add("@idEmployee", SqlDbType.Int).Value = modelEmployee.Id;
                if (command.ExecuteNonQuery() > 0)
                {
                    success = true;
                }
            });
            return success;
        }

        public string SelectDirectorBySection(int departmentId)
        {
            string name = "";
            Execute((command) =>
            {
                command.CommandText = "select (FirstName + ' '+LastName) as name from Employee " +
                                "left join Section on Employee.Id=Section.DirectorID where Section.Id = @idDept";
                command.Parameters.Add("@idDept", SqlDbType.Int).Value = departmentId;
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        name = reader.GetString(0);
                    }
                }
            });
            return name;
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

        public List<ModelEmployee> GetEmployeesByDepartmet(int departmentId)
        {
            List<ModelEmployee> employeeList = new List<ModelEmployee>();
            Execute((command) =>
            {
                command.CommandText = "select * from employee where [WorkAtID]=@workAt";
                command.Parameters.Add("@workAt", SqlDbType.Int).Value = departmentId;
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

        public bool UpdateEmployee(ModelEmployee modelEmployee)
        {
            bool success = false;
            Execute((command) =>
            {
                command.CommandText = @"Update employee set [Title] = @Title, [FirstName] = @FirstName, [LastName] = @LastName, 
                                             [Phone] = @Phone, [Email] = @Email where id=@id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = modelEmployee.Id;
                command.Parameters.Add("@Title", SqlDbType.VarChar).Value = modelEmployee.Title;
                command.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = modelEmployee.FirstName;
                command.Parameters.Add("@LastName", SqlDbType.VarChar).Value = modelEmployee.LastName;
                command.Parameters.Add("@Phone", SqlDbType.VarChar).Value = modelEmployee.Phone;
                command.Parameters.Add("@Email", SqlDbType.VarChar).Value = modelEmployee.Email;
                if (command.ExecuteNonQuery() > 0)
                {
                    success = true;
                }
            });
            return success;
        }
        public ModelEmployee SelectEmployeeById(int employeeId)
        {
            ModelEmployee modelEmployee = new ModelEmployee();
            Execute((command) =>
            {
                command.CommandText = "select [Title], [FirstName], [LastName], [Phone], [Email] " +
                " from employee where id=@employeeId";
                command.Parameters.Add("@employeeId", SqlDbType.Int).Value = modelEmployee.Id;
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        modelEmployee.Title = reader.GetString(0);
                        modelEmployee.FirstName = reader.GetString(1);
                        modelEmployee.LastName = reader.GetString(2);
                        modelEmployee.Phone = reader.GetString(3);
                        modelEmployee.Email = reader.GetString(4);
                    }
                }
            });
            return modelEmployee;
        }
    }
}
