using System;

namespace Practic7
{
    class Program
    {
        static void Main(string[] args)
        {
            Drug drug = new Drug();
            drug.count = 2;
            drug.Id = 0;
            drug.Name = "Griphot";
            drug.ToString();


            Aptek aptek = new Aptek();
            aptek.ToString();
            aptek.AddDrug(drug);
            aptek.DrugList();
            
        }
    }
}
