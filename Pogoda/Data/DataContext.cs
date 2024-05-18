using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pogoda.Data
{
    public static class DataContext
    {
        public static List<Week> Weeks = new List<Week>()
        {
            new Week("Monday"),
            new Week("Tuesday"),
            new Week("Wednesday")
        };




        public static List<Temp> Temps = new List<Temp>()
        {
            new Temp(new DateTime(2022,6,11), Week[0], 3),
            new Temp(new DateTime(2022,6,12), Week[1], 5),
            new Temp(new DateTime(2022,6,13), Week[2], -5),
            new Temp(new DateTime(2022,5,14), Week[2], -3),
            new Temp(new DateTime(2022,7,15), Week[0], 0),
            new Temp(new DateTime(2022,7,16), Week[2], 15),
            new Temp(new DateTime(2022,5,17), Week[0], 5)
        };
    }
}
