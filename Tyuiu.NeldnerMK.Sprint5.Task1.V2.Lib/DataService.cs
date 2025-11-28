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

                double denominator = Math.Cos(x) - 2 * x;
                double result;


                if (Math.Abs(denominator) < 0.0000001)
                {
                    result = 0;
                }
                else
                {
                    result = (2 * x - 3) / denominator + 5 * x - 6;
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