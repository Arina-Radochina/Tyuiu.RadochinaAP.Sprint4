using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.RadochinaAP.Sprint4.Task4.V10.Lib
{
    public class DataService : ISprint4Task4V10
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            int[,] result = (int[,])matrix.Clone();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (result[i, j] % 2 != 0) 
                    {
                        result[i, j] = 0;
                    }
                }
            }
            return result;
        }
    }
}
