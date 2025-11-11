using Tyuiu.RadochinaAP.Sprint4.Task1.V29.Lib;
namespace Tyuiu.RadochinaAP.Sprint4.Task1.V29
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("**********************************************************************************************************************************");
            Console.WriteLine("* Спринт #4                                                                                                                      *");
            Console.WriteLine("* Тема: Одномерные массивы (ввод с клавиатуры)                                                                                    *");
            Console.WriteLine("* Задание #1                                                                                                                     *");
            Console.WriteLine("* Вариант #29                                                                                                                     *");
            Console.WriteLine("* Выполнила: Радочина Арина Павловна | ПИНб-25-1                                                                                 *");
            Console.WriteLine("**********************************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                                       *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 14 элементов заполненный значениями с клавиатуры в диапазоне                            *");
            Console.WriteLine("* от 1 до 9 подсчитать сумму нечетных элементов массива. С клавиатуры: 5, 3, 3, 4, 1, 3, 3, 5, 6, 2, 7, 2, 1, 8                  *");
            Console.WriteLine("*                                                                                                                                *");
            Console.WriteLine("**********************************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                                               *");
            Console.WriteLine("**********************************************************************************************************************************");

            int len;
            Console.Write("Введите количество элементов массива: ");
            len = Convert.ToInt32(Console.ReadLine());

            int[] numsArray = new int[len];

            for (int i = 0; i <= len - 1; i++)
            {
                Console.Write("Введите значение " + i + " элемента массива: ");
                numsArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("Массив: ");
            for (int i = 0; i <= len - 1; i++)
            {
                Console.Write(numsArray[i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("*******************************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                                  *");
            Console.WriteLine("*******************************************************************************************************************************");

            int res = ds.Calculate(numsArray);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}