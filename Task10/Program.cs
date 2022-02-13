using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
               Angle angle = new Angle(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
               angle.ToRadians();
                
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка, входное значение имеет неверный формат");
            }
            Console.ReadKey();
        }
    }

    class Angle
    {
       public int Gradus { get; set; }
       int min;
       int sec;

        public int Min
        {
            set

            {
                if (value > 0)
                {
                    min = value;
                }
                else
                {
                    Console.WriteLine("Минуты не могут быть отрицательными");
                }
            }
            get 
            {
                return (min);
            }
        }
        public int Sec
        {
            set

            {
                if (value > 0)
                {
                    sec=value;
                }
                else
                {
                    Console.WriteLine("Секунды не могут быть отрицательными");
                }
            }
            get
            {
                return (sec);
            }
        }
        public Angle(int gradus, int min, int sec)
        {
            Gradus = gradus;
            Min = min;
            Sec = sec;

        }

        public void ToRadians()
        {
            double A = Gradus * Math.PI / 180 + Min * Math.PI / (180 * 60) + Sec * Math.PI / (180 * 60 * 60);
            Console.WriteLine("{0:f4}",A);
        }
    }

}
