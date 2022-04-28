using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAbstractLab
{
    public class VHS : Movie
    {
        public int CurrentScene { get; set; }
        public VHS(string movieTitle, Genre genreType, int RunTime,params string[] Scenes ) : base(movieTitle, genreType, RunTime, Scenes)
        {
        }

        public override void Play(int num)
        {
            Blockbuster B = new Blockbuster();
            int CurrentScene = 0;
            for (int i = 0; i < B.Movies[num].Scenes.Count; i++)
            {
                if(CurrentScene <= B.Movies[num].Scenes.Count)
                {
                    Console.WriteLine(B.Movies[num].Scenes[i]);
                    CurrentScene++;
                }
                
            }
        }
        public void Rewind()
        {
            CurrentScene = 0;
        }
       
    }
}
