using Tyuiu.RadochinaAP.Sprint4.Task0.V9.Lib;
namespace Tyuiu.RadochinaAP.Sprint4.Task0.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("**********************************************************************************************************************************");
            Console.WriteLine("* Спринт #4                                                                                                                      *");
            Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                                                                                    *");
            Console.WriteLine("* Задание #0                                                                                                                     *");
            Console.WriteLine("* Вариант #9                                                                                                                     *");
            Console.WriteLine("* Выполнила: Радочина Арина Павловна | ПИНб-25-1                                                                                 *");
            Console.WriteLine("**********************************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                                       *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный статическими значениями в диапазоне                            *");
            Console.WriteLine("* от 0 до 9 подсчитать сумму четных элементов массива.  {4 ,6 ,2 ,8 ,4 ,5 ,6 ,9 ,8 ,7}                                           *");
            Console.WriteLine("*                                                                                                                                *");
            Console.WriteLine("**********************************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                                               *");
            Console.WriteLine("**********************************************************************************************************************************");

            int[] numsArray = { 4, 6, 2, 8, 4, 5, 6, 9, 8, 7 };

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i <= numsArray.Length - 1; i++)
            {
                Console.WriteLine(numsArray[i]);
            }

            Console.WriteLine("*******************************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                                  *");
            Console.WriteLine("*******************************************************************************************************************************");
            Console.WriteLine("Результурующий массив: ");

            int result = ds.GetSumEvenArrEl(numsArray);
            Console.Write(result + "\t");

            Console.WriteLine();
            Console.ReadKey();

        }
    }
}