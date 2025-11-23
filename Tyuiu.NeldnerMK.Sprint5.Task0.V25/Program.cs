using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.NeldnerMK.Sprint5.Task0.V25.Lib;


namespace Tyuiu.NeldnerMK.Sprint5.Task0.V25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт №1 | Выполнил: Нельднер М. К . | СМАРТб-25-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт  #5                                                               *");
            Console.WriteLine("* Задание #0                                                               *");
            Console.WriteLine("* Вариант #25                                                              *");
            Console.WriteLine("* Выполнил: Нельднер Максим Константинович | СМАРТб-25-1                   *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу ");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ: Math.Round((Math.Pow(3 * x, 4) + 1) / Math.Pow(x, 3), 2)");
            Console.WriteLine();

            DataService ds = new DataService();



            string str = "753159864";

            int n = 3;
            int m = 3;


            Console.WriteLine();

            int index = 0;

            Console.WriteLine("\n Массив:");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{str[index]} \t");
                    index++;
                }
                Console.WriteLine();
            }






            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            int res = ds.Calculate(n, m, str);
            Console.WriteLine(res);

        }
    }
}
