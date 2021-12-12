using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10_1
{
    class Program
    {
        static void Main(string[] args)


             class Corner
             {
                        private Double gradus;
                        private Double min;
                        private Double sec;
                    {
                        Console.WriteLine("Грудус  {0} минуты {1}' секунды {2}", gradus, min, sec);
                    }
                     //private Double Radian;

            //public static Corner operator +(Corner cor1, Corner cor2)
            //{
            //   return new Corner(cor1.Radian + cor2.Radian);
            //}

            //public static Corner operator -(Corner cor1, Corner cor2)
            //{
            //    return new Corner(cor1.Radian - cor2.Radian);
            //}

            private double DegreeToRadian(double angle)
            {
                return Math.PI * angle / 180.0;
            }
            private double RadianToDegree(double angle)
            {
                return angle * (180.0 / Math.PI);
            }

            public Corner() { }

            public Corner(Double radian)
            {
                Double angle = RadianToDegree(radian);
                Radian = radian;
                Seconds = Math.Round(angle * 3600);
                Degree = Math.Floor(Seconds / 3600);
                Seconds = Math.Abs(Seconds % 3600);
                Minutes = Math.Floor(Seconds / 60);
                Seconds %= 60;
            }

            public Corner(Double degree, Double minutes, Double seconds)
            {
                Degree = degree;
                Minutes = minutes;
                Seconds = seconds;
                Radian = DegreeToRadian(degree + (minutes / 60) + (seconds / 3600));
            }
            public double radian
            {
                get
                {
                    return Radian;
                }
                set
                {
                    Radian = value;
                }
            }
            public double angle
            {
                get
                {
                    return Degree;
                }
                set
                {
                    Degree = value;
                }
            }
            public Double minutes
            {
                get
                {
                    return Minutes;
                }
                set
                {
                    Minutes = value;
                }
            }
            public Double seconds
            {
                get
                {
                    return Seconds;
                }
                set
                {
                    Seconds = value;
                }
            }
        }

        class Sector : Corner
        {
            private Double Radius;
            public double radius
            {
                get { return Radius; }
                set { Radius = value; }
            }
            public double Square()
            {
                return 0.0;
            }
        }

        static void Main(string[] args)
        {
            Corner cor = new Corner(4);
            Console.WriteLine("Angle:{0} - min:{1} - sec:{2}", cor.angle, cor.minutes, cor.seconds);

            Corner cor1 = new Corner(57.3D, 0.0, 0.0);
            Console.WriteLine("rad :{0} ", cor1.radian);

            Corner cor2 = cor + cor1;
            Console.WriteLine("rad  {0} ", cor2.radian);
            Console.WriteLine("Angle:{0} - min:{1} - sec:{2}", cor2.angle, cor2.minutes, cor2.seconds);

            Corner cor3 = cor - new Corner(3.0D);
            Console.WriteLine("rad  {0} ", cor3.radian);
            Console.WriteLine("Angle:{0} - min:{1} - sec:{2}", cor3.angle, cor3.minutes, cor3.seconds);

            Console.ReadLine();
        }
    }
    
}
