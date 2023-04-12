using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemSoLanKyTu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Chuoi();
            Console.ReadLine();
        }
        static void Chuoi()
        {
            string n, t;
            int dem = 0, dai;
            Console.WriteLine("Nhập chuỗi (KHÔNG DẤU) muốn kiểm tra:");
            n = Console.ReadLine();
            Console.WriteLine("Chuỗi vừa tạo:");
            char[] chuoi = n.ToCharArray();
            dai = chuoi.Length;
            for (int i = 0; i < dai; i++)
            {
                Console.Write($"{chuoi[i]}|");
            }
            Console.WriteLine();
            Console.WriteLine("Nhập 1 ký tự muốn tìm:");
            t = Console.ReadLine();
            char[] tim = t.ToCharArray();
            for (int i = 0; i < dai; i++)
            {
                if (tim[0] == chuoi[i])
                {
                    dem++;
                }
            }
            Console.WriteLine("Số lần xuất hiện của ký tự trong chuỗi là: " + dem);
        }
    }
}
