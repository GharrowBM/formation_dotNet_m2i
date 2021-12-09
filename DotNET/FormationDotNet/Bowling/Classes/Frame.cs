using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling.Classes
{
    public class Frame
    {
        private int score;
        private List<Roll> rolls;

        private bool lastFrame;

        private IGenerator generator;
        public int Score { get => score; }
        public bool LastFrame { get => lastFrame; set => lastFrame = value; }
        public List<Roll> Rolls { get => rolls; set => rolls = value; }

        public Frame(IGenerator g, bool lastFrame)
        {
            this.generator = g;
            score = 0;
            Rolls = new List<Roll>();
            LastFrame = lastFrame;
        }

        public bool Roll()
        {
            throw new NotImplementedException();
        }
    }
}
