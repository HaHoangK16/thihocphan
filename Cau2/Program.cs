using System;
using System.Collections;

namespace Cau2
{
    class Forum
    {
        static void Main(string[] args)
        {
            Forum a = new Forum();
            int choice;
            do{
                Console.WriteLine("1. Create Post");
                Console.WriteLine("2. Update Post");
                Console.WriteLine("3. Remove Post");
                Console.WriteLine("4. Show Post");
                Console.WriteLine("5. Exit");

                Console.WriteLine("\nPlease select an item: ");
                int.TryParse(Console.ReadLine(), out choice);
                switch(choice)
                {
                    case 1: a.CreatePost();
                    break;

                    case 2: a.UpdatePost();
                    break;

                    case 3: a.RemovePost();
                    break;

                    case 4: a.ShowPost();
                    break;

                    case 5: return;
                }
            } while(choice!=5);
        }

        int count = 0;
        SortedList ListPost = new SortedList();
        public void CreatePost()
        {
            Post p = new Post();
            p.Id = count;
            Console.WriteLine("Title: ");
            p.Title = Console.ReadLine();
            Console.WriteLine("Content: ");
            p.Content = Console.ReadLine();
            Console.WriteLine("Author: ");
            p.Author = Console.ReadLine();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Rate"+(i+1)+": ");
                p[i] = int.Parse(Console.ReadLine());
            }
            p.CalculatoRate();
            ListPost.Add(count, p);
            count++;

        }

        public void UpdatePost()
        {
            bool search = false;
            Console.WriteLine("Enter the ID of the Post you want to update: ");
            int Id = int.Parse(Console.ReadLine());
            foreach(Post item in ListPost.Values)
            {
                if (Id.Equals(item.Id))
                {
                    search = true;
                    ListPost.Remove(Id);
                    break;
                }
            }
        }

        public void RemovePost()
        {
           bool search = false;
            Console.Write("Enter the ID of the Post you want to delete : ");
            int id = int.Parse(Console.ReadLine());
            foreach (Post item in ListPost.Values)
            {
                if (id.Equals(item.Id))
                {
                    search = true;
                    ListPost.Remove(id);
                    break;
                }
            }
            if (search == true)
                Console.WriteLine("Remove Sucessful!");
            else
                Console.WriteLine("Not Found!");
        }

        public void ShowPost()
        {
            foreach (Post item in ListPost.Values)
            {
                item.Display();
            }
        }
    }
}
