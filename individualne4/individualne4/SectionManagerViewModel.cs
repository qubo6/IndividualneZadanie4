using Data.Model;
using Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace individualne4
{
    public class SectionManagerViewModel
    {
        private OrganizationLogic _logic = new OrganizationLogic();

        public List<ModelSection> GetCompanies()
        {
            return _logic.GetCompanies();
        }
        public List<ModelSection> GetSections(int parentId)
        {
            return _logic.GetSectionsByParentId(parentId);
        }
        public bool SetSectionDirector(ModelSection modelSection)
        {
            return _logic.UpdateDirectorIdOfSection(modelSection);
        }
        public bool UpdateEmployee(ModelEmployee modelEmployee)
        {
            return _logic.UpdateEmployee(modelEmployee);
        }
        public List<ModelEmployee> GetEmployeesByDepartmet(int departmentId)
        {
            return _logic.GetEmployeesByDepartmet(departmentId);
        }
        public string SelectDirectorBySection(int departmentId)
        {
            return _logic.SelectDirectorBySection(departmentId);
        }
        public ModelEmployee SelectEmployeeById(int employeeId)
        {
            return _logic.SelectEmployeeById(employeeId);
        }
    }
}
