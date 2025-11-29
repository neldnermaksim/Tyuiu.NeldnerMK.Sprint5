using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;


namespace Tyuiu.NeldnerMK.Sprint5.Task2.V2.Lib
{
    public class DataService : ISprint5Task2V2
    {

        //Дан двумерный целочисленный массив 3 на 3 элементов, заполненный значениями с клавиатуры.
        //Заменить положительные элементы массива на 1, отрицательные на 0. 
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv");
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        matrix[i, j] = 1;
                    }
                    else
                    {
                        matrix[i, j] = 0;
                    }
                }
            }

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (j != cols - 1)
                    {
                        str = str + matrix[i, j] + ";";
                    }
                    else
                    {
                        str += matrix[i, j];
                    }
                }

                if (i != rows - 1)
                {
                    File.AppendAllText(path, str + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, str);
                }

                str = "";
            }

            return path;

        }

    }
}