namespace TheSCoPO
{
    public class PlayerId
    {
        private readonly string fName;
        private readonly string lName;
        private readonly Random random = new Random();
        private readonly int id;
        
   
        public PlayerId(string _first, string _last)
        {
            
            this.fName = _first;
            this.lName = _last;
            // change id to an rng created thing. Keep it out of the players hands
            this.id = random.Next(100,999);
        }



        //Ask Questions to log variables for PlayerID
        public static void Setup()
        {

            Console.WriteLine("Enter First Name: ");
            var first = Console.ReadLine();

            Decor.ShowLoggedPercentage();
            

            Console.WriteLine("Enter Last Name: ");
            var last = Console.ReadLine();

            // remove this later, let the function do it
/*            Console.WriteLine("Enter 3 digit id#: ");
            var id = Int32.Parse(Console.ReadLine());*/

     
            
           
     
            object lawId = new PlayerId(first, last);

            Decor.ShowSimplePercentage(lawId);

            // just as u passed lawId into that function, pass it again into a differnet class that shows their ID and stuff on the screen - but u need a menu first

            
        }

        public override string ToString()
        {
            return fName + " " + lName + " " + id;
        }
    }
}