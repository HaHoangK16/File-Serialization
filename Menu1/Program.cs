using System;

namespace Menu1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program a = new Program();
            int choice;
            Console.WriteLine("1. Tao mang");
            Console.WriteLine("2. Kiem tra mang doi xung");
            Console.WriteLine("3. Sap xep mang");
            Console.WriteLine("4. Tim kiem mang");
            Console.WriteLine("5. Thoat");
            do
            {
                Console.WriteLine("\nXin hay lua chon chuc nang: ");
                int.TryParse(Console.ReadLine(),out choice);
                switch(choice)
                {
                    case 1: a.CreateArray();
                    break;

                    case 2: a.IsSymmetryArray();
                    break;

                    case 3: a.BubbleSort();
                    break;

                    case 4: a.Find();
                    break;

                    case 5: return;
                }
            } while(choice!=5);
        }

        public void CreateArray()
        {
            int[] array;
            int n;
            Console.WriteLine("Nhap kich thuoc mang: ");
            n = Int32.Parse(Console.ReadLine());
            array = new int[n];
            int i = 0;
            while (i < array.Length)
            {
                Console.WriteLine($"Nhap phan tu {i}: ");
                array[i]= Int32.Parse(Console.ReadLine());
                i++;
            }
        }

        public void IsSymmetryArray()
        {
            int[] array;
            if()
            {

            }

        }

        static void BubbleSort(int[] dataset, int n)
        {
            int i, j;
            for (i = 0; i < n; i++) 
            {
                for (j = n - 1; j > i; j--)
                {
                    if(dataset[j] < dataset[j - 1])
                    {
                        int temp = dataset[j];
                        dataset[j] = dataset[j - 1];
                        dataset[j - 1] = temp;
                    }
                }
            }

        }

        public int Find(int[] dataset, int target, int n)
        {
            int found = 0;
            int i;
            int pos = -1;
            for (i = 0; i < n && found != 1; i++)
                if (target == dataset[i]) 
                { 
                    pos = i; 
                    found = 1; 
                }
            return pos;
        }


    }
}
