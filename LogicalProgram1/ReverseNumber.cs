using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram1
{
    internal class ReverseNumber
    {
        public static void ReverseNo()
        {
            //variables
            int n, reverse = 0;
            Console.WriteLine("Enter  the  number : ");
            n = Convert.ToInt32(Console.ReadLine());
            while (n != 0)
            {
                //reverse Calculation
                reverse = reverse * 10;
                reverse = reverse + n % 10;
                n = n / 10;
            }
            //print the reverse number
            Console.WriteLine("Reverse of Entered Number is : " + reverse);
            Console.ReadLine();
        }
    }
}