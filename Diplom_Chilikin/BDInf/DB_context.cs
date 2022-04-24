using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom_Chilikin.BDInf
{
    public class DB_context:DbContext
    {
        public string path = "server=DESKTOP-G4B9IB0;DataBase=AutoSalon;Trusted_Connection = True;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-G4B9IB0;DataBase=AutoSalon;Trusted_Connection = True;");
        }
        public virtual DbSet<Access> Access { get; set; }
        public virtual DbSet<Auto> Autos { get; set; }
        public virtual DbSet<People> Peoples { get; set; }
        public virtual DbSet<ContractAuto> ContractAutos { get; set; }
        
    }
}
