using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAbstractLab
{
    class Blockbuster 
    {
        public List<Movie> Movies { get; set; }
        public Blockbuster() 
        {

            Movies = new List<Movie>();
            DVD m = new DVD("Friday", Genre.comedy,97, "Craig gets fired on his day off","Hey Ms Parker","Craig vs Deebo");
            Movies.Add(m);
            Movies.Add(new DVD("Transformers", Genre.action, 144, "Sam buys car","BumbleBee saves Sam", "Sam meets Autobots"));
            Movies.Add(new DVD("Nightmare on Elm Street", Genre.horror, 91, "Freddy Fights Mike Tyson", "Freddy cries in a corner","I hate freddy"));

            VHS v = new VHS("The Exorcist", Genre.horror, 132, "The possessed meets Super Mario","The demon breakdances","Demon takes a picture with Obama");
            Movies.Add(v);
            Movies.Add(new VHS("Dumb and Dumb", Genre.comedy,107,"Limo scene","LLoyd gets fired","Lloyd transcends stupidity"));
            Movies.Add(new VHS("Die Hard", Genre.action, 132, "Bruce Willis blows stuff up","Bruce Willis blows even more stuff up","Bruce blows stuff up x3"));
        }
        public void PrintMovies()
        {
            for(int i = 1; i < Movies.Count + 1; i++)
            {
                Console.WriteLine("Movie #" + i + " " + Movies[i-1].MovieTitle);
            }
            
        }
        public Movie CheckOut()
        {
            Console.WriteLine("Which movie would you like to checkout?");
            PrintMovies();
            int userinput = int.Parse(Console.ReadLine());
            Movies[userinput - 1].PrintInfo();
            return Movies[userinput -1];
        }
    }
}
