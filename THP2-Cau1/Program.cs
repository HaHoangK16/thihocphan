using System;
using System.Text;

namespace THP2_Cau1
{
    class Program
    {
        static void Menu()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("1. Tạo mảng");
            Console.WriteLine("2. Kiểm tra mảng đối xứng");
            Console.WriteLine("3. Sắp xếp mảng");
            Console.WriteLine("4. Tìm kiếm mảng");
            Console.WriteLine("5. Thoát");
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Program program = new Program();
            int choice = 0;
            do
            {
                Menu();
                Console.WriteLine("Chọn: ");
                choice = int.Parse(Console.ReadLine());
                int[] arr = CreateArray();
                switch (choice)
                {
                    case 1:
                        CreateArray(); break;
                    case 2:
                        bool doixung = IsSymmetryArray(arr);
                        if (doixung)
                        {
                            Console.WriteLine("Mảng đối xứng");
                        }
                        else Console.WriteLine("Mảng không đối xứng");
                        break;
                    case 3:
                        SelectionSort(arr); break;
                    case 4:
                        Find(arr); break;
                    case 5:
                        return;
                }
            } while (choice != 5);
        }
        static int[] CreateArray()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n = 0;
            while (n <= 0)
            {
                Console.WriteLine("Nhập số phần tử mảng: ");
                n = Convert.ToInt32(Console.ReadLine());
            }
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Phần tử thứ {i}: ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            return a;
        }
        static bool IsSymmetryArray(int[] arr)
        {
            int n = arr.Length / 2;
            for (int i = 0; i <= n; i++)
            {
                if (arr[i] != arr[arr.Length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }
        static void SelectionSort(int[] array)
        {
            Array.Sort(array);
        }
        static void Find(int[] array)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập phần tử cần tìm: ");
            int n = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < n; ++i)
            {
                if (array[i] == n)
                {
                    Console.WriteLine($"Phần tử [{i}] nằm ở vị trí {n}");
                }
                else Console.WriteLine("Không tìm thấy!");
            }
        }
    }
}
