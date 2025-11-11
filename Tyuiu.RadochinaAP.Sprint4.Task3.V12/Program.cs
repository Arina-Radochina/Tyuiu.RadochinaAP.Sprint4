using Tyuiu.RadochinaAP.Sprint4.Task3.V12.Lib;
namespace Tyuiu.RadochinaAP.Sprint4.Task3.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mtrx = new int[5, 5] {
                { 9, 7, 4, 9, 7 },
                { 5, 2, 5, 7, 6 },
                { 8, 3, 3, 5, 7 },
                { 8, 4, 2, 4, 5 },
                { 8, 8, 9, 5, 6 }
            };

            int rows = mtrx.GetUpperBound(0) + 1; 
            int columns = mtrx.Length / rows; 

            DataService ds = new DataService();

            Console.WriteLine("**********************************************************************************************************************************");
            Console.WriteLine("* Спринт #4                                                                                                                      *");
            Console.WriteLine("* Тема: Двумерные массивы (статический ввод)                                                                                     *");
            Console.WriteLine("* Задание #3                                                                                                                     *");
            Console.WriteLine("* Вариант #12                                                                                                                    *");
            Console.WriteLine("* Выполнила: Радочина Арина Павловна | ПИНб-25-1                                                                                 *");
            Console.WriteLine("**********************************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                                       *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный статическими значениями в диапазоне                           *");
            Console.WriteLine("*  от 2 до 9. Найдите минимальный элемент третьем столбце массива.                                                               *");
            Console.WriteLine("*                                                                                                                                *");
            Console.WriteLine("**********************************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                                               *");
            Console.WriteLine("**********************************************************************************************************************************");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{mtrx[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("*******************************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                                  *");
            Console.WriteLine("*******************************************************************************************************************************");

            int res = ds.Calculate(mtrx);

            Console.WriteLine("Минимальный элемент в третьем столбце - " + res);
            Console.ReadKey();

        }
    }
}