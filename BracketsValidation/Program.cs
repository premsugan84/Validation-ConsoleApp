using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Validate Brackets in a given String
namespace BracketsValidation
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string input1, status;
            bool blnValid = false;
            bool UserExit = false;

            //Execute till the user enters exit
            while (!UserExit)
            {
                Console.WriteLine("Please enter your string");
                input1 = Console.ReadLine();
                Validation CVal = new Validation();
                blnValid = CVal.BracketsValidation(input1);
                Console.WriteLine("Is it Valid:" + blnValid);
                Console.WriteLine("Do you want to exit, Type exit otherwise type Enter");
                status = Console.ReadLine();
                if (status == "exit")
                {
                    UserExit = true;
                }
            }
        
        }
    }
    
}
