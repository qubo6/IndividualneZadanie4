using Data.Model;
using Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace individualne4
{   
    public class AddEmployeeViewModel
    {
        private OrganizationLogic _logic = new OrganizationLogic();

        public bool InsertEmployee(ModelEmployee modelEmployee)
        {
            return _logic.InsertEmployee(modelEmployee);
        }
        public bool UpdateEmployeeBy(ModelEmployee modelEmployee)
        {
            return _logic.UpdateEmployee(modelEmployee);
        }
    }
}
