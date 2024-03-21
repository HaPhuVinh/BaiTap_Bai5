using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap_Bai5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Bạn muốn tạo mảng một chiều bao nhiêu phần tử: ");
            int n = int.Parse(Console.ReadLine());
            int[] Arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhập vào phần tử số nguyên thứ {0}: ", i+1);
                Arr[i] = int.Parse(Console.ReadLine());
            }
            //In mảng vừa nhập
            Console.WriteLine("Bạn vừa nhập mảng số nguyên có {0} phần tử", n);
            foreach (int i in Arr) 
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();
            //In mảng dữ liệu theo chiều đảo ngược
            Console.WriteLine("Đảo ngược mảng trên là: ");
            for (int i = Arr.Length-1; i >=0; i--)
            {
                Console.Write(Arr[i]+"\t");
            }

            Console.WriteLine();
            //Tìm số phần tử giống nhau trong mảng và hiển thị số lượng giống nhau ra màng hình
            for (int i = 0; i < length; i++)
            {

            }

            Console.ReadKey();
        }
    }
}
