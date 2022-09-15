using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter amount of matrix rows: ");
            int amountString = int.Parse(Console.ReadLine());

            Console.Write("Enter amount of matrix column: ");
            int amountColumn = int.Parse(Console.ReadLine());

            int[,] mX1, mX2, mX3;

            Random random = new Random();

            mX1 = new int[amountString, amountColumn];
            Console.WriteLine("\n\tОбъявляем первую матрицу.\t\n");
            for (int i = 0; i < mX1.GetLength(0); i++)
            {
                for (int j = 0; j < mX1.GetLength(1); j++)
                {
                    mX1[i, j] = random.Next(10);
                    Console.Write($"{mX1[i, j]}\t");
                }
                Console.WriteLine();
            }
            var sum = 0;
            foreach (var item in mX1)
            {
                sum += item;
            }
            Console.WriteLine("Сумма всех элементов - {0}", sum);

            mX3 = new int[amountString, amountColumn];

            var countString = 0;
            var countColumn = 0;

            // Просматриваем первую матрицу и присваиваем ее значения третьей матрице.
            foreach (var item in mX1)
            {
                mX3[countString, countColumn] = item;
                countColumn++;
                if (countColumn == amountColumn)
                {
                    countString++;
                    countColumn = 0;
                }
            }
            countString = 0;
            countColumn = 0;

            Console.WriteLine("\n\tОбъявляем вторую матрицу.\t\n");
            mX2 = new int[amountString, amountColumn];
            for (int i = 0; i < mX2.GetLength(0); i++)
            {
                for (int j = 0; j < mX2.GetLength(1); j++)
                {
                    mX2[i, j] = random.Next(10);
                    Console.Write($"{mX2[i, j]}\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n\tСуммируем обе матрицы.\n");
            foreach (var item in mX2)
            {
                mX3[countString, countColumn] += item;
                Console.Write($"{mX3[countString, countColumn]}\t");
                countColumn++;
                if (countColumn == amountColumn)
                {
                    countString++;
                    countColumn = 0;
                    Console.WriteLine();
                }
            }


            Console.ReadKey();
        }
    }
}
