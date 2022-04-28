
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAbstractLab
{
    class Run
    {



        public bool RunAgain()
        {
            Console.WriteLine("Would you like to run the program again? Y/N");
            string answer = Console.ReadLine().ToLower().Trim();

            if (answer == "y")
            {
                return true;
            }
            else if (answer == "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("I didn't understand please input y or n");
                return RunAgain();
            }
        }
    }
}
