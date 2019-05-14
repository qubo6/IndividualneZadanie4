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
        public bool InsertEmployee(ModelEmployee modelEmployee)
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
        public bool UpdateDirectorIdOfSection(ModelSection modelSection)
        {
            return RepositoryManager.SectionRepository.UpdateDirectorIdOfSection(modelSection);
        }
        public bool UpdateEmployeeWorkAt(ModelEmployee modelEmployee)
        {
            return RepositoryManager.EmployeeRepository.UpdateEmployeeWorkAt(modelEmployee);
        }
        public List<ModelEmployee> GetEmployeesByDepartmet(int departmentId)
        {
            return RepositoryManager.EmployeeRepository.GetEmployeesByDepartmet(departmentId);
        }
        public string SelectDirectorBySection(int departmentId)
        {
            return RepositoryManager.EmployeeRepository.SelectDirectorBySection(departmentId);
        }
        public bool UpdateSection(ModelSection modelSection)
        {
            return RepositoryManager.SectionRepository.UpdateSection(modelSection);
        }
        public ModelSection SelectSectionById(int sectionId)
        {
            return RepositoryManager.SectionRepository.SelectSectionById(sectionId);
        }
        public bool UpdateEmployee(ModelEmployee modelEmployee)
        {
            return RepositoryManager.EmployeeRepository.UpdateEmployee(modelEmployee);
        }
        public ModelEmployee SelectEmployeeById(int employeeId)
        {
            return RepositoryManager.EmployeeRepository.SelectEmployeeById(employeeId);
        }
    }
}
