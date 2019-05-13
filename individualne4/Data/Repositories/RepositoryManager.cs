using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class RepositoryManager : ConnectionManger
    {
        public static EmployeeRepository EmployeeRepository = new EmployeeRepository();
        public static SectionRepository SectionRepository = new SectionRepository();
    }
}
