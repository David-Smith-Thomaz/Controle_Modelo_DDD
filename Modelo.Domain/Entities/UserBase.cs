using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.Domain.Entities
{
    public abstract class UserBase
    {
        public UserBase() 
        {

        }

        public UserBase(int userId, string completeName, string documentNumber) 
        {
            this.UserId = userId;
            this.CompleteName = completeName;
            this.DocumentNumber = this.DocumentNumber;
        }

        public virtual int UserId { get; set; }
        public virtual string CompleteName { get; set; }
        public virtual string DocumentNumber { get; set; }
    }
}