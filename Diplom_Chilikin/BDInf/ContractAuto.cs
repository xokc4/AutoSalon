using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom_Chilikin.BDInf
{
    public  class ContractAuto
    {
        [Key]
        public int IdContractAuto { get; set; }
        public int IdAuto { get; set; }
        public int IdPeople { get; set; }
        public string Sity { get; set; }
        public string NameWork { get; set; }
        public string Adress { get; set; }
        public string Credit { get; set; }

    }
}
