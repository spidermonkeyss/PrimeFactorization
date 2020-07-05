using System;
using System.Collections.Generic;
using System.Text;

namespace Utlity
{
    public class UserInput
    {
        public static int GetUserNumericInput()
        {
            int intInput = 0;

            string input = Console.ReadLine();
            bool isNumber = int.TryParse(input, out int n);
            if (!isNumber)
            {
                Console.WriteLine("Not a number");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
            intInput = Convert.ToInt32(input);
            return intInput;
        }
    }
}