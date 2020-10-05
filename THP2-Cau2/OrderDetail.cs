using System;

namespace THP2_Cau2
{
    public class OrderDetail
    {
        public string Name {get;set;}
        public long Price {get;set;}
        public int Count {get;set;}
        public long Total {get;set;}

        public void CalculatorTotal(){
            Total = Price * Count;
        }
        public void Show(){
            Console.WriteLine("Name: "+Name);
            Console.WriteLine("Price: "+Price);
            Console.WriteLine("Count: "+Count);
            Console.WriteLine("Total: "+Total);
        }
    }
}