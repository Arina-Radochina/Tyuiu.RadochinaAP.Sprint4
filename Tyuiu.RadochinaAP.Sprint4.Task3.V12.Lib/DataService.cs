using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.RadochinaAP.Sprint4.Task3.V12.Lib
{
    public class DataService : ISprint4Task3V12
    {
        public int Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1; 
            int columns = matrix.Length / rows; 

            int min = int.MaxValue;
            int columnIndex = 2; 

            for (int i = 0; i < rows; i++)
            {
                if (matrix[i, columnIndex] < min)
                {
                    min = matrix[i, columnIndex];
                }
            }
            return min;
        }
    }
}
