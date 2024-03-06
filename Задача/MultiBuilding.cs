using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача
{
    sealed class MultiBuilding : Building
    {
        int Floors { get; set; }

        public MultiBuilding(string adress, int length, int width, int height, int floors)
            : base(adress, length, width, height)
        {
            Floors = floors;
        }

        new public string Print()
        {
            return base.Print() + $", этажей - {Floors}";
        }

    }
}
