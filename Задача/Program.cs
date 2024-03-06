using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building("Санкт-Петербург, 3-я ул. Строителей, д. 25", 300, 200, 50);
            Console.WriteLine(building.Print());
            
            MultiBuilding multiBuilding = new MultiBuilding("Москва, 3-я ул. Строителей, д. 25", 300, 200, 50, 13);
            Console.WriteLine(multiBuilding.Print());
            Console.ReadLine();
        }
    }
}
