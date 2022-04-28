using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAbstractLab
{

    public enum Genre
    {
        action,
        horror,
        comedy
    }
    public abstract class Movie
    {
       public string MovieTitle { get; set; }   

       public Genre Category { get; set; }    
        
        public int RunTime { get; set; }

        public List<string> Scenes { get; set; }  
        
      
        public Movie(string movieTitle, Genre genreType, int RunTime, params string [] Scenes)
        {
            this.MovieTitle = movieTitle;
            this.Category = genreType;
            this.RunTime = RunTime;
            this.Scenes = Scenes.ToList();
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine("You have selected " + MovieTitle);
            Console.WriteLine("The Genre is "  + Category);
            Console.WriteLine("The run time for this movie is " + RunTime + " minutes");
        }

        public void PrintScenes()
        {
            for(int i = 0; i < Scenes.Count; i++)
            {
                Console.WriteLine($"Scene {i}: {Scenes[i]}");
            }
        }
        //Play will have no body since it is abstract
        //Abstract methods make a promise that children of this class will fill in the implementation
        public abstract void Play(int num);
        
    }
}