using Data.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model
{
    public class ModelSection
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int? DirectorId { get; set; }
        public HierarchyLevel HierarchyLevel{ get; set; }
        public int? ParentSectionId { get; set; }

        public ModelSection(int id, string name, string code, int? directorId, HierarchyLevel hierarchyLevel, int? parentSectionId)
        {
            Id = id;
            Name = name;
            Code = code;
            DirectorId = directorId;
            HierarchyLevel = hierarchyLevel;
            ParentSectionId = parentSectionId;
        }

        public ModelSection()
        {
        }
    }
}
