using System;

namespace Cau2
{
    public class Post : IPost
    {
        public int Id {get;set;}
        public string Title {get;set;}
        public string Content {get;set;}
        public string Author {get;set;}
        public float AverageRate {get;}

        public void Display()
        {
            Console.WriteLine("Id: "+Id);
            Console.WriteLine("Title: "+Title);
            Console.WriteLine("Content: "+Content);
            Console.WriteLine("Author: "+Author);
            Console.WriteLine("AverageRate: "+AverageRate);
            Console.WriteLine("---------------");
        }

        int[] RateList = new int[3];
        private float averagerate;

        public int this[int index]
        {
            get{
                return RateList[index];
            }
            set{
                RateList[index] = value;
            }
        }
        public void CalculatoRate()
        {
            averagerate = (float)(RateList[0] + RateList[1] + RateList[2])/3;
        }

    }
}