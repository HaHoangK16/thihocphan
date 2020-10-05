using System;
using System.Collections.Generic;

namespace THP2_Cau2
{
    class Coffee
    {
        Dictionary<int,Table> tableList = new Dictionary<int, Table>();

        static void Main(string[] args)
        {
            Coffee c = new Coffee();
            int choice;
            do{
                Console.WriteLine("1. New Order");
                Console.WriteLine("2. Update Order");
                Console.WriteLine("3. Cancel Order");
                Console.WriteLine("4. Search");
                Console.WriteLine("5. Pay");
                Console.WriteLine("6. Show");
                Console.WriteLine("7. Exit");

                Console.WriteLine("\nPlease select an item: ");
                int.TryParse(Console.ReadLine(), out choice);
                switch(choice)
                {
                    case 1: c.NewOrder();
                    break;

                    case 2: c.UpdateOrder();
                    break;

                    case 3: c.CancelOrder();
                    break;

                    case 4: c.Search();
                    break;

                    case 5: c.Pay();
                    break;

                    case 6: c.Show();
                    break;

                    case 7: return;

                }
            } while(choice!=7);
        }

        public void NewOrder(){
            Table table = new Table();
            OrderDetail orderDetail = new OrderDetail();

            Console.WriteLine("Table");
            Console.WriteLine("Nhap TableId: ");
            table.TableId = Int32.Parse(Console.ReadLine());
            Console.WriteLine("StartTime: ");
            table.StartTime = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("EndTime: ");
            table.EndTime = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Sumtotal: ");
            table.SumTotal = long.Parse(Console.ReadLine());

            Console.WriteLine("-------------------");
            Console.WriteLine("OrderDetail");
            Console.WriteLine("Nhap Name: ");
            orderDetail.Name = Console.ReadLine();
            Console.WriteLine("Price: ");
            orderDetail.Price = long.Parse(Console.ReadLine());
            Console.WriteLine("Count: ");
            orderDetail.Count = int.Parse(Console.ReadLine());

            tableList.Add(orderDetail);


        }

        public void UpdateOrder(){
            bool search = false;
            Console.WriteLine("Nhap TableId can Update:");
            int id =int.Parse(Console.ReadLine());
            foreach(Table item in tableList.Values)
            {
                if(id.Equals(item.TableId))
                {
                    search = true;
                    Table t = new Table();
                    OrderDetail order = new OrderDetail();
                    t.TableId = id;
                    Console.WriteLine("Name: ");
                    order.Name = Console.ReadLine();
                    Console.WriteLine("Price: ");
                    order.Price = long.Parse(Console.ReadLine());
                    Console.WriteLine("Count: ");
                    order.Count = int.Parse(Console.ReadLine());
                    order.CalculatorTotal();
                    tableList.Remove(id);
                    //tableList.Add(id,order);
                    break;
                }
            }
            if(search == true)
            {
                Console.WriteLine("Update Successful");
            }
            else{
                Console.WriteLine("Not Found");
            }
        }

        public void CancelOrder()
        {
            bool search = false;
            Console.WriteLine("Nhap TableId can Cancel: ");
            int id = int.Parse(Console.ReadLine());
            foreach(Table item in tableList.Values)
            {
                if(id.Equals(item.TableId))
                {
                    search = true;
                    tableList.Remove(id);
                    break;
                }
            }
            if(search == true)
            {
                Console.WriteLine("Cancel Successful");
            }
            else
            {
                Console.WriteLine("Not Found");
            }
        }

        public void Search(){
            if(tableList.Count > 0){
                foreach(Table item in tableList.Values){
                    item.ShowInfo();
                }
            } 
            else{
                Console.WriteLine("Not found");
                Console.WriteLine("----------------");
            }
        }

        public void Pay(){
            bool search = false;
            Console.WriteLine("Nhap TableId: ");
            int id = int.Parse(Console.ReadLine());
            foreach(Table item in tableList.Values)
            {
                if(id.Equals(item.TableId))
                {
                    search = true;
                }
            }
        }

        public void Show(){
            foreach(var item in tableList.Values){
                item.ShowInfo();
            }
        }
    }
}
