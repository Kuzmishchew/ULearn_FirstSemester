//Задано время Н часов (ровно).
//Вычислить угол в градусах между часовой и минутной стрелками.
//Например, 5 часов -> 150 градусов, 20 часов -> 120 градусов. Не использовать циклы.
using System.Runtime.CompilerServices;

namespace Expr3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int H = Int32.Parse(Console.ReadLine());

            Console.WriteLine(calcDegree(Math.Abs(H - 12)));
        }

        static int calcDegree(int H) {
            int result;
            const int ONE_HOUR_DEGREE = 360 / 12;

            if (H >= 6)
            {
                result = (12 - H) * ONE_HOUR_DEGREE;
            }
            else
            {
                result = H * ONE_HOUR_DEGREE;
            }

            return result;
        }
    }
}
