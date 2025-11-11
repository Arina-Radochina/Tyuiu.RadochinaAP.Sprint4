using Tyuiu.RadochinaAP.Sprint4.Task2.V4.Lib;
namespace Tyuiu.RadochinaAP.Sprint4.Task2.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            DataService ds = new DataService();

            Console.WriteLine("**********************************************************************************************************************************");
            Console.WriteLine("* Спринт #4                                                                                                                      *");
            Console.WriteLine("* Тема: Одномерные массивы (ввод с клавиатуры)                                                                                    *");
            Console.WriteLine("* Задание #2                                                                                                                     *");
            Console.WriteLine("* Вариант #4                                                                                                                      *");
            Console.WriteLine("* Выполнила: Радочина Арина Павловна | ПИНб-25-1                                                                                 *");
            Console.WriteLine("**********************************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                                       *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 13 элементов заполненный случайными в диапазоне                                         *");
            Console.WriteLine("* от 2 до 9 подсчитать сумму нечетных элементов массива.                                                                         *");
            Console.WriteLine("*                                                                                                                                *");
            Console.WriteLine("**********************************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                                               *");
            Console.WriteLine("**********************************************************************************************************************************");

            Console.Write("Введите количество элементов массива: ");
            int len = Convert.ToInt32(Console.ReadLine());

            int[] numsArray = new int[len];

            for (int i = 0; i <= len - 1; i++)
            {
                numsArray[i] = rnd.Next(5, 20);
            }

            Console.WriteLine("Массив:");
            for (int i = 0; i <= len - 1; i++)
            {
                Console.Write(numsArray[i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine("*******************************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                                  *");
            Console.WriteLine("*******************************************************************************************************************************");

            int res = ds.Calculate(numsArray);

            Console.WriteLine("Сумма элементов больше 10 = " + res);
            Console.ReadKey();
        }
    }
}
