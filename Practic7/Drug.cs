using System;
using System.Collections.Generic;
using System.Text;

namespace Practic7
{
    class Drug
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Id;
        public TypeDrug Type;
        public int count;
        public static int num2 = 1;



        public override string ToString()
        {
            return $"Name : {Name}, Id : {Id}";
        }
    }
}
