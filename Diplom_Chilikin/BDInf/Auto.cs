using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom_Chilikin.BDInf
{
   public class Auto
   {
        public Auto(string stamp, string equipment, string engine, string color, string drive, string box, double cost, string body, string image)
        {
            Stamp = stamp;
            Equipment = equipment;
            Engine = engine;
            Color = color;
            Drive = drive;
            Box = box;
            Cost = cost;
            Body = body;
            Image = image;
        }

        [Key]
        public int IdAuto { get; set; }
        public string Stamp { get; set; }   
        public string Equipment { get; set; }
        public string Engine { get; set; }
        public string Color { get; set; }
        public string Drive { get; set; }
        public string Box { get; set; }
        public double Cost { get; set; }
        public string Body { get; set; }
        public string Image { get; set; }

   }
}
