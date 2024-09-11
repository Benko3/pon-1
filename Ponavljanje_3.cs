using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponavljanje_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upisite prvu stranicu z:");
            int z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Upisite prvu stranicu x:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Upisite prvu stranicu y:");
            int y = Convert.ToInt32(Console.ReadLine());

            if (z > 0 && x > 0 && y > 0)
            {
                int a = z * z;
                int b = x * x;
                int c = y * y;

                if(a > 0 &&){

                    Console.WriteLine("Trokut je pravokutan.");
                }
                else if(b > 0 &&) {
                    Console.WriteLine("Trokut je pravokutan.");
                }
                else if(c > 0 &&){
                    Console.WriteLine("Trokut je pravokutan.");
                }
                else{
                    Console.WriteLine("Trokut nije pravokutan.");
                }
                Console.ReadKey();
            }
        }
    }
} 
