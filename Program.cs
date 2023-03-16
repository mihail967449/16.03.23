﻿using System;
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
            //1 нахождение максимального элемента и его индекса в ОМ
            int[] array = {8, -1, 4, 16, -5, 3};
            int max = array[0];
            int indexMax = 0;
            int min = array[0];
            int indexMin = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    indexMax = i;
                }
                if (array[i] < min)
                {
                    min = array[i];
                    indexMin = i;
                }
            }  
            Console.WriteLine($"max={max}\t indexMAX={indexMax}");
            Console.WriteLine($"min={min}\t indexMIN={indexMin}");
            Console.Read();
        }
    }
}
