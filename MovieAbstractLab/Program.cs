namespace MovieAbstractLab
{
    public class Program
    {
        public static void Main()
        {
            VHS Tape = new VHS("", Genre.action,1,"");
            Console.WriteLine("Welcome to GC BlockBuster");
            Blockbuster BB = new Blockbuster(); 
            Movie Disc = BB.CheckOut();
            //Disc.PrintScenes();
            if (Disc is DVD)
            {
                while (true)
                {


                    int MovieIndex = BB.Movies.IndexOf(Disc);
                    Disc.Play(MovieIndex);
                    Console.WriteLine("Would you like to watch another scene? Y or N");
                    string answer = Console.ReadLine().ToLower().Trim();
                    if (answer == "y")
                    {
                        continue;
                    }
                    else if (answer == "n")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Sorry I did not understand that, please try again");
                        continue;
                    }
                }
            }
            else if (Disc is VHS)
            {
                int VHSIndex = BB.Movies.IndexOf(Disc);
                Tape.Play(VHSIndex);
                Tape.Rewind();
            }


            Console.WriteLine("GoodBye");
        }
    }
}
