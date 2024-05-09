using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_calculator_tester
{
    public static class Calculator
    {
        public static float Add(float num1, float num2) => num1 + num2;
        public static float Substract(float num1, float num2) => num1 - num2;
        public static float Divide(float num1, float num2)
        {
            try
            {
                if (num2 <= 0)
                {
                    throw new ArgumentException("Non puoi dividere per 0");
                }
                return num1 / num2;
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
            
        }
        public static float Multiply(float num1, float num2) => num1 * num2;
        
    }
}
