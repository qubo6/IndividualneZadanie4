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
            return _logic.GetSections(parentId);
        }
    }
}
