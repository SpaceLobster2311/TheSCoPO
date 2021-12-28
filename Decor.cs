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
    }


}
