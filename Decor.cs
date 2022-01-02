
namespace TheSCoPO
{
    class Decor
    {
/*        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadKey();

            ShowSimplePercentage();

            Console.ReadKey();
        }*/

        public static void ShowSimplePercentage(object arg)
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.Write($"\rProgress: {i}%   ");
                Thread.Sleep(10);
            }

            Console.Write("\rNew LawID generated: ------>  " + arg + "  <------ ");
        }


        public static void ShowLoggedPercentage()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.Write($"\rProgress: {i}%   ");
                Thread.Sleep(2);
            }
            Console.Write("\rLogged: Proceed    ");
            
        }


        public static void Spinner()
        {
            var counter = 0;
            for (int i = 0; i < 25; i++)
            {
                switch (counter % 4)
                {
                    case 0: Console.Write("/"); break;
                    case 1: Console.Write("-"); break;
                    case 2: Console.Write("\\"); break;
                    case 3: Console.Write("|"); break;
                }
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                counter++;
                Thread.Sleep(100);
            }
        }

        public static void ColorGreen(string arg)
        {
       
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(arg);
            Console.ResetColor();

        }

        public static async Task ConsoleCompleteAnim()
        {
            Console.ForegroundColor= ConsoleColor.DarkCyan;
            for (int i = 0; i < 4; i++)
            {
                Console.Write("| +");
                await Task.Delay(50);
                Console.Write("\b\b\b");
                Console.Write("/ ++");
                await Task.Delay(50);
                Console.Write("\b\b\b");
                Console.Write("- +");
                await Task.Delay(50);
                Console.Write("\b\b\b");
                Console.Write("\\ +");
                await Task.Delay(50);
                Console.Write("\b\b\b");
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkRed;
        }

    }


}
