using System;
using System.Collections.Generic;

namespace THP2_Cau2
{
    public class Table :ITable
    {
        public int TableId {get;set;}
        public DateTime StartTime {get;set;}
        public DateTime EndTime {get;set;}
        public long SumTotal {get;set;}

        List<OrderDetail> List = new List<OrderDetail>();

        public void Pay()
        {
            
        }

        public void ShowInfo()
        {
            Console.WriteLine("TableId: "+TableId);
            Console.WriteLine("StartTime: "+StartTime);
            Console.WriteLine("EndTime: "+EndTime);
            Console.WriteLine("SumTotal: "+SumTotal);
        }
    }
}