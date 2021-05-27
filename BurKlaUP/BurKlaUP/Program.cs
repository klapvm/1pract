using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurKlaUP
{
    public class lib1
    {
        public static string stpow(string a, int b)
        {
            string n = "";
            while (b > 0)
            {
                n += a;
                b--;
            }
            return n;
        }
        public static string rev(string a)
        {
            string n = "";
            for(int i = a.Length-1; i >= 0; i--)
            {
                n+=a[i];
            }
            return n;
        }
        public static string remov(string str, string s)
        {
            str = str.Replace(s, "");
            return str;
        }
        public static int leng(string str)
        {
            int i = str.Length;
            return i;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //1
            {
                Console.WriteLine("stpow\nВведите строку:");
                string a = Console.ReadLine();
                Console.WriteLine("Введите кол-во повторов:");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Строка {b} раз(а): {lib1.stpow(a, b)}");
                Console.WriteLine("rev\nВведите строку:");
                a = Console.ReadLine();
                Console.WriteLine($"Перевернутое слово: {lib1.rev(a)}");
                Console.WriteLine("remov\nВведите строку:");
                string str = Console.ReadLine();
                Console.WriteLine("Введите подстроку:");
                string s = Console.ReadLine();
                Console.WriteLine($"Строка без подстроки: {lib1.remov(str, s)}");
                Console.WriteLine("leng\nВведите строку:");
                str = Console.ReadLine();
                Console.WriteLine($"Длина строки: {lib1.leng(str)}");
                Console.ReadLine();
                
            }
        }
    }
}
