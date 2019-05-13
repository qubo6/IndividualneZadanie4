using Data.Model;
using Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace individualne4
{   
    public class InsertDirectorViewModel
    {
        private OrganizationLogic _logic = new OrganizationLogic();
        //private ModelEmployee _employee = new ModelEmployee();

        public int InsertDirector(ModelEmployee modelEmployee)
        {
            return _logic.InsertDirector(modelEmployee);
        }
    }
}
