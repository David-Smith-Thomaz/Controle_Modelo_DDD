using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.Domain.Entities
{
    public abstract class SchoolBase
    {
        public SchoolBase() 
        {

        }

        public SchoolBase(int SchoolId, string Name, string Tell,  string Address) 
        {
            this.SchoolId = SchoolId;
            this.Name = Name;
            this.Tell = Tell;
            this.Address = Address;
        }

        public virtual int SchoolId { get; set; }
        public virtual string Name { get; set; }
        public virtual string Tell { get; set; }
        public virtual string Address { get; set; }
    }
}