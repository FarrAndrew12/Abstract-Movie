using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAbstractLab
{
    class DVD : Movie
    {
        public DVD(string movieTitle, Genre genreType, int RunTime, params string[] Scenes) : base(movieTitle, genreType, RunTime, Scenes)
        {
        }

        public override void Play(int num)
        {
            
            Console.WriteLine("Which scene would you like to watch? Please input 0 to " + (Scenes.Count -1));
            string input = Console.ReadLine();
            int index = int.Parse(input);
            string scene = Scenes[index];
            Console.WriteLine(scene);
         
        }
    }
}
