using Tyuiu.RadochinaAP.Sprint4.Task5.V5.Lib;
namespace Tyuiu.RadochinaAP.Sprint4.Task5.V5
{
    class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();

            Console.WriteLine("**********************************************************************************************************************************");
            Console.WriteLine("* Спринт #4                                                                                                                      *");
            Console.WriteLine("* Тема: Двумерные массивы (генератор случайных чисел)                                                                                            *");
            Console.WriteLine("* Задание #5                                                                                                                     *");
            Console.WriteLine("* Вариант #5                                                                                                                     *");
            Console.WriteLine("* Выполнила: Радочина Арина Павловна | ПИНб-25-1                                                                                 *");
            Console.WriteLine("**********************************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                                       *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный случайными значениями в диапазоне                                   *");
            Console.WriteLine("* от -5 до 8. Найти сумму положительных элементов.                                                                                     *");
            Console.WriteLine("*                                                                                                                                *");
            Console.WriteLine("**********************************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                                               *");
            Console.WriteLine("**********************************************************************************************************************************");

            int rows = 5;
            int columns = 5;

            int[,] mtrx = new int[rows, columns];
            Random rnd = new Random();

            // Заполняем случайными числами от -5 до 8
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    mtrx[i, j] = rnd.Next(-5, 9);
                }
            }

            Console.WriteLine("Массив 5x5 (случайные числа от -5 до 8):");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{mtrx[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("****************************************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                                                *");
            Console.WriteLine("********************************************************************************************************************************************");

            int res = ds.Calculate(mtrx);

            Console.WriteLine("Сумма положительных элементов = " + res);
            Console.ReadKey();
        }
    }
}
