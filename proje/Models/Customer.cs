using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace proje.Models
{
    public class Customer : IdentityUser
    {
        
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
        public DateTime BirthDay { get; set; }
        public Gender Gender { get; set; }
        public string City { get; set; }
        [NotMapped]
        public string NameSurname
        {
            get
            {
                return Name+" "+ Surname;
            }
        }




    }
    public enum Gender
    {
        kadin,
        erkek
    }
}
