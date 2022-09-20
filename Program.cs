using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] income = {100_000, 120_000, 80_000, 70_000, 100_000,200_000, 130_000, 150_000, 190_000, 110_000, 150_000, 100_000};
            int[] consumption = {80_000, 90_000, 70_000, 70_000, 80_000, 120_000, 140_000, 65_000, 90_000, 70_000, 120_000, 80_000};
            int[] profit = new int[12];
            int mouth = 0;
            int countMouth = 0;
            int [] mouthBad = new int[20];

            Console.WriteLine("Месяц\tДоход, тыс. руб.\tРасход, тыс. руб.\tПрибыль, тыс. руб.");
            for (int i = 0; i < income.Length; i++)
            {
                profit[i] = income[i] - consumption[i];  
                Console.WriteLine($"{mouth = mouth + 1}\t{income[i]}\t\t\t{consumption[i]}\t\t\t{profit[i]}");
                if (profit[i]>0)
                {
                    countMouth++;
                }

                if (profit[i] <= 20_000)
                {
                    mouthBad[i] = mouthBad[i] + mouth;
                }
            }
            Console.Write($"Худшая прибыль в месяцах: ");

            for (int i = 0; i < mouthBad.Length; i++)
            {
                if (mouthBad[i] != 0)
                {
                    Console.Write($"{mouthBad[i]} ");
                }   
            }
            Console.WriteLine($"\nМесяцев с положительной прибылью: {countMouth}");
            


            Console.ReadKey();


        }
    }
}
