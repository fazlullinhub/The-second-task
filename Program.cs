using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the string of zeros and ones: ");
            string binaryString = Console.ReadLine();

            try
            {
                int decimalNumber = ConvertBinaryToDecimal(binaryString);
                Console.WriteLine("Decimal representation: " + decimalNumber);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: there is a wrong symbol.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: The number range is exceeded Int32.");
            }
        }

        static int ConvertBinaryToDecimal(string binaryString)
        {
            int result = 0;

            foreach (char c in binaryString)
            {
                if (c != '0' && c != '1')
                {
                    throw new FormatException();
                }

                int digit = c - '0';
                try
                {
                    result = checked(result * 2 + digit);
                }
                catch (OverflowException)
                {
                    throw new OverflowException();
                }
                {

                }
            }
        }
    }
}
        

