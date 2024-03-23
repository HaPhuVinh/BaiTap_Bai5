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
            Console.Write("Bạn muốn tạo mảng một chiều bao nhiêu phần tử: ");
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
            Console.WriteLine();

            //Chia mảng dữ liệu ban đầu thành mảng chẳn và mảng lẻ

            int[] mangChan = new int[0];
            int[] mangLe = new int[0];
            int demSoChan = 0;
            int demSoLe = 0;
            for (int i = 0;i < Arr.Length; i++)
            {
                if (Arr[i] % 2 == 0)
                {
                    demSoChan += 1;
                    Array.Resize(ref mangChan, demSoChan);
                    mangChan[demSoChan-1] = Arr[i];
                }
                else
                {
                    demSoLe += 1;
                    Array.Resize(ref mangLe, demSoLe);
                    mangLe[demSoLe - 1] = Arr[i];
                }
            }
            if(mangChan.Length>0)
            {
                Console.WriteLine("Mảng số chẵn có được từ Mãng ban đầu:");
                foreach (int i in mangChan)
                {
                    Console.WriteLine(i + "\t");
                }
            }
            else
            {
                Console.WriteLine("Mãng ban đầu không có số chẵn.");
            }

            if (mangLe.Length > 0)
            {
                Console.WriteLine("Mảng số lẻ có được từ Mãng ban đầu:");
                foreach (int i in mangLe)
                {
                    Console.WriteLine(i + "\t");
                }
            }
            else
            {
                Console.WriteLine("Mãng ban đầu không có số lẻ.");
            }

            //Sắp xếp Mảng ban đầu theo thứ tự giảm dần.
            int m = 0;
            int u = 0;
            int temp = 0;
            while (m < Arr.Length)
            {
                u = m +1 ;
                while (u < Arr.Length)
                {
                    if (Arr[m] < Arr[u])
                    {
                        temp = Arr[m];
                        Arr[m] = Arr[u];
                        Arr[u] = temp;
                    }
                    u++;
                }
                m++;
            }
            Console.WriteLine("Sắp xếp Mảng ban đầu giảm dần");
            foreach (int i in Arr)
            {
                Console.WriteLine(i + "\t");
            }
            Console.WriteLine();

            //int[] mangGiamDan = new int[n];
            //mangGiamDan = Arr;
            //Array.Sort(mangGiamDan);
            //Array.Reverse(mangGiamDan);
            //Console.WriteLine("Sắp xếp Mảng ban đầu giảm dần");
            //foreach (int i in mangGiamDan)
            //{
            //    Console.WriteLine(i + "\t");
            //}
            //Console.WriteLine();

            //Kiểm tra lại thứ tự Mảng ban đầu
            //foreach (int i in Arr)
            //{
            //    Console.WriteLine(i + "\t");
            //}
            //Console.WriteLine();





            Console.ReadKey();
        }
    }
}
