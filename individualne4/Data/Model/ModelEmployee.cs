using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model
{
    public class ModelEmployee
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int? WorkAtSectionId { get; set; }

        public ModelEmployee(int id, string title, string firstName, string lastName, string phone, string email, int? workAtSectionId)
        {
            Id = id;
            Title = title;
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
            Email = email;
            WorkAtSectionId = workAtSectionId;
        }

        public ModelEmployee()
        {
        }
    }
}
