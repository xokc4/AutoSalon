using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom_Chilikin.BDInf
{
    public class Access
    {
        [Key]
        public int IdAccess { get; set; }
        [Required]
        public string AccessName { get; set; }
    }
}
