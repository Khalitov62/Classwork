using System;
using System.Collections.Generic;
using System.Text;

namespace Practic7
{
    class Aptek
    {
        public string Name { get; set; }
        public int Id { get;  }
        public Drug[] drugsArr = new Drug[0];
        public static int num3 = 1;


        public override string ToString()
        {
            return $"Name : {Name}, Id : {Id}";
        }

        

        public  void AddDrug(Drug dr)
        {
            Array.Resize(ref drugsArr, drugsArr.Length + 1);
            drugsArr[drugsArr.Length - 1] = dr;
        }

        public static void DrugList(Drug dr)
        {
            foreach (var item in drugsArr)
            {
                Console.WriteLine($"Name : {item.Name}, Count : {item.count}, Id : {item.Id}, Price : {item.Price}, Type : {item.Type}");
            }
        }
        public static void SaleDrug(string name, int count, int price,Drug[] drugsArr)
        {

            foreach (var item in drugsArr)
            {
                if (name == item.Name && count == item.count && price == item.Price && item.count>0)
                {
                    Console.WriteLine(item);
                }
                else
                {
                    Console.WriteLine("Nisye derman verilmir");
                }
            }
        }
    }
}
