using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling.Classes
{
    public class Game
    {
        private List<Frame> frames;
        private int globalScore;

        public List<Frame> Frames { get => frames; set => frames = value; }
        public int GlobalScore { get => globalScore; set => globalScore = value; }
        
        public Game()
        {
            frames = new List<Frame>();
        }
    }
}
