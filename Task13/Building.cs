using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13
{
    class Building
    {
        public string address { get; set; }
        int length { get; set; }
        int width { get; set; }
        int height { get; set; }


        public Building(string address, int length, int width, int height)
        {
            this.address = address;
            this.length = length;
            this.width = width;
            this.height = height;
        }
        public string Print()
        {
            return $" Здание раcположено по адресу: {address}. Размеры здания: {length}x{width}x{height}. ";
        }
    }
}
