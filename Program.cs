using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34
{
    class Program
    {
        static void Main(string[] args)
        {
            //4. дан курс рубля за каждый день в феврале месяца(случайным образом), рассчитать средний курс рубля, максимальный курс рубля и день с максимальным курсом, минимальный курс рубля и день с минимальным курсом
            double[] array = new double[28];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = 55 + 10* rnd.NextDouble();
                Console.WriteLine($"array[{i}]={array[i]:f2}");
            }
            
                Console.Read();
        }
    }
}
