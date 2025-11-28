using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;


namespace Tyuiu.NeldnerMK.Sprint5.Task1.V2.Lib
{
    public class DataService : ISprint5Task1V2
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {


            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }

            double y;
            string strv;
            for (int x = startValue; x <= stopValue; x++)
            {
                double result = 2 * x + 3 * Math.Pow(x, 2) + 4;
                if (double.IsInfinity(result) || double.IsNaN(result))
                {
                    result = 0;
                }
                y = Math.Round(result, 2);
                strv = Convert.ToString(y);

                if (x != stopValue)
                {
                    File.AppendAllText(path, strv + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, strv);
                }
            }
            return path;
        }
    }
}