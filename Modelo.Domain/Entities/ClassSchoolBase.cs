using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.Domain.Entities
{
    public abstract class ClassSchoolBase
    {
        public ClassSchoolBase()
        {

        }

        public ClassSchoolBase(int ClassSchoolId, int SchoolId, string Name, string Email)
        {
            this.ClassSchoolId = ClassSchoolId;
            this.SchoolId = SchoolId;
            this.Name = Name;
            this.Email = Email;
        }

        public int ClassSchoolId { get; set; }
        public int SchoolId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}