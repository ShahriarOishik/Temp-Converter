using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tempareture_Converter
{
    class Program
    {
        static void Main(string[] args)
        {           // Var Only
            double inputNum;
            string inputConv;
            Console.WriteLine("C stands for Celsius. F stands for Fahrenheit. K stands for Kelvin");
            Console.Write("<Unit> To <Unit>(example: F to C): ");
            inputConv = Console.ReadLine();
            inputConv = inputConv.ToUpper();
            Console.Write("Current Temp(Only Number): ");
            inputNum = Convert.ToDouble(Console.ReadLine());
            string crash = ("Sorry! The Program has crashed.\nPress Enter Key to Exit");
            // output paths here
            if (inputConv == "F TO C")
            {
                Console.WriteLine((((inputNum - 32) / 9) * 5 ) + "°C");

            }
            else if (inputConv == "F TO K")
            {
                Console.WriteLine((((5 * (inputNum - 32)) / 9) + 273) + "K");
            }
            else if (inputConv == "C TO F")
            {
                Console.WriteLine(((5 * (inputNum - 32)) / 9) + "°F");
            }
            else if (inputConv == "C TO K")
            {
                Console.WriteLine((inputNum + 273) + "K");
            }
            else if (inputConv == "K TO C")
            {
                Console.WriteLine((inputNum - 273) + "°C");
            }
            else if (inputConv == "K TO F")
            {
                Console.WriteLine((((9 * (inputNum - 273)) / 5) + 32)+ "°F");
            }
            else
            {
                Console.WriteLine(crash);
            }
            Console.ReadLine();
        }
    }
}
       

