using Data.Model;
using Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace individualne4
{
    public class EmployeeViewModel
    {
        private OrganizationLogic _logic = new OrganizationLogic();

        public List<ModelEmployee> GetAllEmployees()
        {
            return _logic.GetAllEmployees();
        }
        public bool DeleteEmployee(int idEmployee)
        {
            return _logic.RegularDeleteEmployee(idEmployee);
        }
    }
}
