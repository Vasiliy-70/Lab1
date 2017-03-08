using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_test
{
    //Меняем программу согласно пункту 3 задания
    //Меняем еще раз
    class Program
    {
        static void Main(string[] args)
        {
            float rez0 = 0;
            float rez1 = 0;
            float val = 0;
            int i = 0;
            Console.WriteLine("Введите подкоренное число");
            val = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите приближенное значение корня");
            rez0 = float.Parse(Console.ReadLine());
            while (i!=1)
            {
                rez1 = (rez0 + (val / rez0)) * (0.5F);
                if (rez1 == rez0)
                {
                    i = 1;
                }
                rez0 = rez1;
            }
            Console.WriteLine("Корень равен:");
            Console.WriteLine(rez1);
            Console.ReadLine();
        }
    }
}
