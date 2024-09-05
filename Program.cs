using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI1_2_3_4_5_6_dangclass
{
    class Baitaptonghop
    {
        public void BAI1()
        {
            Console.WriteLine("VU DUC HUY - MASV: 22810310409 - CNPM6");

            Console.Write("NHAP SO PHAN TU CUA MANG: ");
            int n = int.Parse(Console.ReadLine());
            int[] number = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap phan tu so " + i + " :");
                number[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += number[i];
            }
            Console.WriteLine("Tong mang = " + sum);
        }


        // BAI 2: Dem ky tu trong chuoi


        public void BAI2()
        {
            Console.Write("NHAP CHUOI BAT KY: ");
            string msg = Console.ReadLine();
            int dem = 0;
            foreach (char c in msg)
            {
                if (char.IsLetterOrDigit(c)) { dem++; }
            }
            Console.WriteLine("SO LUONG KY TU (KHONG TINH SPACE VA DAU) = " + dem);
        }


        // BAI 3: Find max


        public void BAI3()
        {
            Console.Write("NHAP so luong phan n = ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap phan tu so " + i + " :");
                a[i] = int.Parse(Console.ReadLine());
            }

            int max = a[0];
            for (int i = 0; i < n; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }

            Console.WriteLine("MAX = " + max);
        }


        // BAI 4: Dao nguoc chuoi


        public void BAI4()
        {
            Console.Write("NHAP CHUOI: ");
            string msg = Console.ReadLine();

            char[] chars = msg.ToCharArray();
            Array.Reverse(chars);
            string reversemsg = new string(chars);
            Console.WriteLine("CHUOI SAU KHI DAO NGUOC LA: " + reversemsg);
        }


        // BAI 5: Kiem tra mang doi xung


        public void BAI5()
        {
            int n;
            do
            {
                Console.Write("NHAP SO PHAN TU CUA MANG: ");
                n = int.Parse(Console.ReadLine());
            } while (n % 2 == 0);

            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap phan tu so " + i + " :");
                a[i] = int.Parse(Console.ReadLine());
            }

            bool isPalindrome = true;
            for (int i = 0; i < n / 2; i++)
            {
                if (a[i] != a[a.Length - 1 - i])
                {
                    isPalindrome = false;
                    break;
                }
            }

            if (isPalindrome)
            {
                Console.WriteLine("MANG NAY DOI XUNG");
            }
            else
            {
                Console.WriteLine("MANG KHONG DOI XUNG");
            }
        }


        // BAI 6: Dem so lan xuat hien trong chuoi


        public void BAI6()
        {
            Console.Write("NHAP CHUOI: ");
            string msg = Console.ReadLine();

            Console.Write("NHAP KEY: ");
            char key = Console.ReadKey().KeyChar;
            Console.WriteLine();

            int count = 0;
            char[] chars = msg.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == key)
                {
                    count++;
                }
            }

            Console.WriteLine("So lan ma tu K xuat hien trong chuoi la = " + count);
        }


        internal class Program
        {
            static void Main(string[] args)
            {
                Baitaptonghop baitaptonghop = new Baitaptonghop();


                //baitaptonghop.BAI1();
                baitaptonghop.BAI2();
                //baitaptonghop.BAI3();
                //baitaptonghop.BAI4();
                //baitaptonghop.BAI5();
                //baitaptonghop.BAI6();


            }
        }
    }
}
