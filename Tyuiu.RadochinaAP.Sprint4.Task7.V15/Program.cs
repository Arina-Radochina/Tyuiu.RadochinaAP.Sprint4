using Tyuiu.RadochinaAP.Sprint4.Task7.V15.Lib;
namespace Tyuiu.RadochinaAP.Sprint4.Task7.V15
{
    class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();

            Console.WriteLine("**********************************************************************************************************************************");
            Console.WriteLine("* Спринт #4                                                                                                                      *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                                                                                            *");
            Console.WriteLine("* Задание #7                                                                                                                     *");
            Console.WriteLine("* Вариант #15                                                                                                                        *");
            Console.WriteLine("* Выполнила: Радочина Арина Павловна | ПИНб-25-1                                                                                 *");
            Console.WriteLine("**********************************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                                       *");
            Console.WriteLine("* Дана строка из одноразрядных цифр 10293847. Преобразуйте ее в матрицу                                                          *");
            Console.WriteLine("* 4 на 2 и подсчитайте количество нечетных чисел в матрице.                                                                                      *");
            Console.WriteLine("*                                                                                                                                *");
            Console.WriteLine("**********************************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                                               *");
            Console.WriteLine("**********************************************************************************************************************************");

            int n = 4;  // строки
            int m = 2;  // столбцы
            string value = "10293847";

            Console.WriteLine($"Количество строк (n): {n}");
            Console.WriteLine($"Количество столбцов (m): {m}");
            Console.WriteLine($"Строка (value): \"{value}\"");

            // Создаем и выводим матрицу
            int[,] matrix = new int[n, m];
            int index = 0;

            Console.WriteLine($"\nМатрица {n}x{m}:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = int.Parse(value[index].ToString());
                    Console.Write($"{matrix[i, j]} \t");
                    index++;
                }
                Console.WriteLine();
            }

            Console.WriteLine("**********************************************************************************************************************************");
            Console.WriteLine("****************************************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                                                *");
            Console.WriteLine("********************************************************************************************************************************************");

            int res = ds.Calculate(n, m, value);

            Console.WriteLine("Количество нечётных чисел в матрице = " + res);
            Console.ReadKey();
        }
    }
}