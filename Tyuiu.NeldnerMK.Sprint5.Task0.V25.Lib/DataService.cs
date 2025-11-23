using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5; 


namespace Tyuiu.NeldnerMK.Sprint5.Task0.V25.Lib 
{
    public class DataService : ISprint5Task0V25
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");
            double y = Math.Round((3*(Math.Pow(x, 4) + 1)) / Math.Pow(x, 3), 2);
            File.WriteAllText(path, Convert.ToString(y));
            return path;
        }
    }
}