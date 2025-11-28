using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.NeldnerMK.Sprint5.Task1.V2.Lib;


namespace Tyuiu.NeldnerMK.Sprint5.Task1.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт №1 | Выполнил: Нельднер М. К . | СМАРТб-25-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт  #5                                                               *");
            Console.WriteLine("* Задание #1                                                               *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнил: Нельднер Максим Константинович | СМАРТб-25-1                   *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу ");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ: ");
            Console.WriteLine();

            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            string res = ds.SaveToFileTextData(startValue, stopValue);
            Console.WriteLine("Файл"+res);
            Console.WriteLine("Создан");
        }
    }
}
