// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;

namespace TheSCoPO // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static async Task Main(string[] args)
        {


            //Create menu here?
            Console.ForegroundColor = ConsoleColor.DarkRed;
            PlayerId.Setup();
            Decor.ColorGreen("New Account");
            await Decor.ConsoleCompleteAnim();
            await MainMenu();

            Console.WriteLine("Program.cs");
        }



        public static async Task MainMenu()
        {


            Console.WriteLine("Good afternoon (insert lawID here)"); 
            Console.WriteLine("");
            Console.WriteLine("1. Cases"); // bring to a new function
            Console.WriteLine("2. Reference"); // bring to a new function
            Console.WriteLine("3. LawId Profile"); // bring to a new function
            Console.WriteLine("4. Self Termonate"); // bring to a new function

            var answer = Int32.Parse(Console.ReadLine());

            switch(answer)
            {
                case 1:
                    Console.WriteLine("This is where cases go");
                    break;

                case 2:
                    Console.WriteLine("This is where the ref function will go");
                    break;

                case 3:
                    Console.WriteLine("lawID shit");
                    break;

                case 4:
                    Console.WriteLine("resigned");
                    break;

                case -1:
                    Console.WriteLine(String.Format("Unknown command: {0}", answer));
                    break;
                  
                default:
                    Console.WriteLine(String.Format("Unknown command: {0}", answer));
                    break;
                 
            }

            await MainMenu();
       




        }





    }

  



}