using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Xml.Linq;

namespace Practice
{
    internal class Notebook:Product
    {
        public Notebook(string name, double price) : base(name, price)
        {

        }
        public int RAM;
        public int Storage;

        public override void ShowInfo()
        {
            Console.WriteLine($"Name: {Name} - Price: {Price} - RAM: {RAM} - Storage: {Storage}");
        }
    }
}
