using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;


namespace Tyuiu.NeldnerMK.Sprint5.Task4.V10.Lib
{
    public class DataService : ISprint5Task4V10
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);

            
            double x = double.Parse(strX, CultureInfo.InvariantCulture);

            double res = Math.Pow(x, 3) * 1.2 * x + 2;

            return Math.Round(res, 3);

        }
    }
}