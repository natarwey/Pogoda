using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Pogoda.Data
{
    public class Temp
    {
        public Temp(DateTime data, Week week, int temperatura)
        {
            Data = data;
            Week = week; 
            Temperatura = temperatura;
        }


        public DateTime Data { get; set; }
        public Week? Week { get; set; }
        public int Temperatura { get; set; }
    }
}
