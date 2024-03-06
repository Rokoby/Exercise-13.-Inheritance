using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача
{
    internal class Building
    {
        string Adress {  get; set; }
        int Length { get; set; }
        int Width { get; set; }
        int Height { get; set; }

        public Building(string adress, int length, int width, int height)
        {
            Adress = adress;
            Length = length;
            Width = width;
            Height = height;
        }

        public string Print()
        {
            return $"Адрес - {Adress}, длина - {Length}, ширина - {Width}, высота - {Height}";
        }
    }
}
