using Data.Model;
using Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace individualne4
{
    public class AddSectionViewModel
    {
        private OrganizationLogic _logic = new OrganizationLogic();

        public bool AddSection(ModelSection modelSection)
        {
            return _logic.InsertSection(modelSection);
        }
        public bool UpdateSection(ModelSection modelSection)
        {
            return _logic.UpdateSection(modelSection);
        }
    }
}
