namespace TheSCoPO
{
    public class PlayerId
    {
        private string fName;
        private string lName;
        private int id;
        public PlayerId(string _first, string _last, int _id)
        {
            this.fName = _first;
            this.lName = _last;
            this.id = _id;
        }



        //Ask Questions to log variables for PlayerID
        public static void Setup()
        {

            Console.WriteLine("Enter First Name: ");
            var first = Console.ReadLine();

            Console.WriteLine("Enter Last Name: ");
            var last = Console.ReadLine();

            Console.WriteLine("Enter 3 digit id#: ");
            var id = Int32.Parse(Console.ReadLine());
           
     
            var lawId = new PlayerId(first, last, id);

         

            Console.WriteLine(lawId);
        }

        public override string ToString()
        {
            return fName + " " + lName + id;
        }
    }
}