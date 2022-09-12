using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumeMathService.localhost
{
    internal class Program
    {
        static void Main(string[] args)
        {localhost.MathService myMathService = new localhost.MathService();
            Console.Write($"2 * 4 = {myMathService.Multiply(2, 4)}\n");
            Console.Write($"8 % 2 = {myMathService.Divide(8, 2)}");
        }
    }
}
