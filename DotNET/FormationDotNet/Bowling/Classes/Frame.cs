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
        public int Score
        {
            get
            {
                int score = 0;
                Rolls.ForEach(r =>
                {
                    score += r.Pins;
                });
                return score;
            }
        }
        public bool LastFrame { get => lastFrame; set => lastFrame = value; }
        public List<Roll> Rolls { get => rolls; set => rolls = value; }

        public Frame(IGenerator g, bool lastFrame)
        {
            this.generator = g;
            score = 0;
            Rolls = new List<Roll>();
            LastFrame = lastFrame;
        }


        private void MakeRoll(int max)
        {
            int randomPins = generator.RandomPins(max);
            Rolls.Add(new Roll(randomPins));
        }
        public bool Roll()
        {
            int nbRolls = Rolls.Count;
            if (nbRolls == 0 || (nbRolls == 1 && Rolls[0].Pins == 10 && lastFrame))
            {
                MakeRoll(10);
            }
            else if (nbRolls == 1 && !(Rolls[0].Pins == 10 && !lastFrame))
            {
                MakeRoll(10 - Rolls[0].Pins);
            }
            else if(nbRolls == 2 && lastFrame)
            {
                Roll r1 = Rolls[0];
                Roll r2 = Rolls[1];
                if ((r1.Pins + r2.Pins) >= 10)
                {
                    int max = 20 - (r1.Pins + r2.Pins);
                    MakeRoll(max);
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
            return true;
        }
    }
}
