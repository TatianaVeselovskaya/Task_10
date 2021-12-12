using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10
{
    class Program
    {
        static void Main(string[] args)
        {
            string gradus, min, sec;
            Ygol y1 = new Ygol();

            Console.Write("Введите градусы:");
            gradus = Console.ReadLine();
            Console.Write("Введите минуты:");
            min = Console.ReadLine();
            Console.Write("Введите секунды:");
            sec = Console.ReadLine();

            if (int.TryParse(gradus, out y1.gradus))
            {
                y1.gradus = Convert.ToInt32(gradus);
                if (int.TryParse(min, out y1.min))
                {
                    y1.min = Convert.ToInt32(min);
                    if (int.TryParse(sec, out y1.sec))
                    {
                        y1.sec = Convert.ToInt32(sec);
                        Console.WriteLine("В радианах это: " + y1.ToRadians());
                    }
                    else
                    {
                        Console.WriteLine("Введенное:" + sec + " не число");
                    }
                }
                else
                {
                    Console.WriteLine("Введенное:" + min + " не число");
                }
            }
            else
            {
                Console.WriteLine("Введенное:" + gradus + " не число");
            }
            Console.ReadKey();
        }
  
        class Ygol

        {
            public int gradus = 0, min = 0, sec = 0;

            public double ToRadians()
            {
                return (gradus + (min + sec / 60) / 60) * Math.PI / 180;
            }
        }
        
    }
}