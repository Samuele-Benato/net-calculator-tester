using System.Security.Cryptography.X509Certificates;

namespace net_calculator_tester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float sum = Calculator.Add(2, 3);
            Console.WriteLine($"risultato somma : {sum}");

            float subtraction = Calculator.Substract(2, 3);
            Console.WriteLine($"risultato sottrazione : {subtraction}");

            float divide = Calculator.Divide(2, 0);
            Console.WriteLine($"risultato divisione : {divide}");

            float moltiply = Calculator.Multiply(2, 4);
            Console.WriteLine($"risultato moltiplicazione : {moltiply}");
        }
    }
}
