using Data.Model;
using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class OrganizationLogic
    {
        public int InsertDirector(ModelEmployee modelEmployee)
        {
            return RepositoryManager.EmployeeRepository.InsertDirector(modelEmployee);
        }
        public int InsertEmployee(ModelEmployee modelEmployee)
        {
            return RepositoryManager.EmployeeRepository.InsertEmployee(modelEmployee);
        }
        public bool InsertSection(ModelSection modelSection)
        {
            return RepositoryManager.SectionRepository.InsertSection(modelSection);
        }
        public List<ModelEmployee> GetAllEmployees()
        {
            return RepositoryManager.EmployeeRepository.GetAllEmployees();
        }
        public bool DeleteEmployee(int idEmployee)
        {
            return RepositoryManager.EmployeeRepository.DeleteEmployee(idEmployee);
        }
        public List<ModelSection> GetCompanies()
        {
            return RepositoryManager.SectionRepository.GetAllCompanies();
        }
        public List<ModelSection> GetSections(int parentId)
        {
            return RepositoryManager.SectionRepository.GetAllSections(parentId);
        }

    }
}
