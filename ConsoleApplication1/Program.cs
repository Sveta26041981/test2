using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Class1
    {
        static void Main()
        {
            string buf;
            Console.WriteLine("Введіть значення x: ");
            buf = Console.ReadLine();
            double x = Convert.ToDouble(buf);
            Console.WriteLine("Введіть alfa: ");
            buf = Console.ReadLine();
            double a = double.Parse(buf);
            double y = Math.Sqrt(Math.PI * x) -
                              Math.Exp(0.2 * Math.Sqrt(a)) +
                              2 * Math.Tan(2 * a) +
                             1.6 * Math.Log10(Math.Pow(x, 2));
            Console.WriteLine("Для х = {0} і  alfa = {1}", x, a);
            Console.WriteLine("Результат = " + y+" новий результат");
            Console.ReadKey();
        }
    }
}
