//Задается натуральное трехзначное число (гарантируется, что трехзначное). Развернуть его, т.е. получить трехзначное число, записанное теми же цифрами в обратном порядке.
namespace Expr2
{
    internal class Program
    {
        static int ReverseNumber(int number)
        {
            string numberString = number.ToString();

            string result = numberString[2].ToString() + numberString[1].ToString() + numberString[0].ToString();

            return Convert.ToInt32(result);
        }
        static void Main(string[] args)
        {
            int number;
            number = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine(ReverseNumber(number));
        }
    }
}
