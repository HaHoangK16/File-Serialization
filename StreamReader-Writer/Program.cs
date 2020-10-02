using System;
using System.IO;
using System.Text;

namespace StreamReader_Writer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            using (StreamWriter sw = new StreamWriter(@"C:\Users\Admin\Desktop\Codegym\File-Serialization\StreamReader-Writer\text.txt"))
            {
                Console.WriteLine("Mã sản phẩm: ");
                int msp = int.Parse(Console.ReadLine());
                sw.WriteLine(msp);
                Console.WriteLine("Tên sản phẩm: ");
                string tsp = Console.ReadLine();
                sw.WriteLine(tsp);
                Console.WriteLine("Hãng sản xuất: ");
                string hsx = Console.ReadLine();
                sw.WriteLine(hsx);
                Console.WriteLine("Giá: ");
                int g = int.Parse(Console.ReadLine());
                sw.WriteLine(g);
                Console.WriteLine("Các mô tả khác: ");
                string mtk = Console.ReadLine();
                sw.WriteLine(mtk);
                sw.Close();
            }
            using (StreamReader sr = new StreamReader(@"C:\Users\Admin\Desktop\Codegym\File-Serialization\StreamReader-Writer\text.txt"))
            {
                Console.WriteLine(sr.ReadToEnd());
                sr.Close();
            }
        }
    }
}
