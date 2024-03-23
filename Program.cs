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
            //Tìm số phần tử giống nhau trong mảng và hiển thị số lượng giống nhau
            int dem = 0;
            int dem1 = 0;
            bool ktTrung = false;
            for (int i = 0; i < Arr.Length; i++)
            {
                dem = 0;
                ktTrung = false;
                for (int j = i-1; j >= 0; j--)
                {
                    if (Arr[i] == Arr[j]) ktTrung = true;
                }
                if (ktTrung)
                {
                    continue;
                }
                else
                {
                    for (int k = i; k < Arr.Length; k++)
                    {
                        if (Arr[i] == Arr[k])
                        {
                            dem += 1;
                        }
                    }
                    if (dem > 1)
                    {
                        Console.WriteLine("Có {0} Phần tử giống nhau có giá trị là {1}.", dem, Arr[i]);
                        dem1 += 1;
                    }
                }
            }
            if (dem1 < 1)
                Console.WriteLine("Mảng bạn nhập không có phần tử giống nhau");

            //In phần tử duy nhất trong mảng.
            Console.WriteLine("In phần tử duy nhất trong mảng:");
            Console.Write(Arr[0] + "\t");
            for (int i = 1; i < Arr.Length; i++)
            {
                ktTrung = false;
                for (int j = i-1; j >= 0; j--)
                {
                    if (Arr[i] == Arr[j])
                    {
                        ktTrung = true;
                        break;
                    }
                }
                if (ktTrung)
                    continue;
                else
                    Console.Write(Arr[i] + "\t");
            }

            //Chia mảng dữ liệu ban đầu thành mảng chẳn và mảng lẻ

            int[] mangChan = new int[n];
            int[] mangLe = new int[n];


            Console.ReadKey();
        }
    }
}
