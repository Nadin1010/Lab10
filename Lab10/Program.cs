using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            Angle angle;
            do
            {
                Console.WriteLine("введите данные");
                int gradus_ = Convert.ToInt32(Console.ReadLine());
                int minute_ = Convert.ToInt32(Console.ReadLine());
                int second_ = Convert.ToInt32(Console.ReadLine());

                angle = new Angle(gradus_, minute_, second_);
            }
            while (angle.isCorrect == false);

            int totalSecond = angle.ToRadians();
            Console.WriteLine(totalSecond);
            Console.ReadKey();
        }
    }
}

 
