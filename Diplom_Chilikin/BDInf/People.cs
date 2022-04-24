using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom_Chilikin.BDInf
{
    public class People
    {
        public People(int idAccess, string log, string mail, string phone, string password, int age)
        {
            IdAccess = idAccess;
            Log = log;
            Mail = mail;
            Phone = phone;
            Password = password;
            Age = age;
        }

        [Key]
        public int IdPeople { get; set; }
        [Required]
        public int IdAccess { get; set; }
        public string Log { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
    }
}
