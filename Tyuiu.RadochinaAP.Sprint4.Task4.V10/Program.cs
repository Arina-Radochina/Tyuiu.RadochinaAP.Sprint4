using Tyuiu.RadochinaAP.Sprint4.Task4.V10.Lib;
namespace Tyuiu.RadochinaAP.Sprint4.Task4.V10
{
    class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();

            Console.WriteLine("**********************************************************************************************************************************");
            Console.WriteLine("* Спринт #4                                                                                                                      *");
            Console.WriteLine("* Тема: Двумерные массивы (ввод с клавиатуры)                                                                                         *");
            Console.WriteLine("* Задание #4                                                                                                                     *");
            Console.WriteLine("* Вариант #10                                                                                                                    *");
            Console.WriteLine("* Выполнила: Радочина Арина Павловна | ПИНб-25-1                                                                                 *");
            Console.WriteLine("**********************************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                                       *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный значениями с клавиатуры в диапазоне                            *");
            Console.WriteLine("* от 1 до 7. Заменить нечетные элементы массива на 0.                                                                            *");
            Console.WriteLine("*                                                                                                                                *");
            Console.WriteLine("**********************************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                                               *");
            Console.WriteLine("**********************************************************************************************************************************");

            Console.WriteLine("Введите количество строк в массиве: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов в массиве: ");
            int columns = Convert.ToInt32(Console.ReadLine());

            int[,] mtrx = new int[rows, columns];

            Console.WriteLine("********************************************************************************************************************************************");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"Введите {i},{j} элемент массива: ");
                    mtrx[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\nМассив:");
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

            int[,] res = ds.Calculate(mtrx);

            Console.WriteLine("Массив после замены нечётных на 0:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{res[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
