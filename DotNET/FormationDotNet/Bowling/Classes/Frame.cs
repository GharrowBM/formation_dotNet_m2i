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

        public bool Roll()
        {
            int nbRolls = Rolls.Count;
            int ramdomPins;
            if (nbRolls == 0)
            {
                ramdomPins = generator.RandomPins(10);
                Rolls.Add(new Roll(ramdomPins));
            }
            else if (nbRolls == 1)
            {
                Roll r = Rolls[0];
                if (r.Pins == 10)
                {
                    return false;
                }
                else
                {
                    ramdomPins = generator.RandomPins(10 - r.Pins);
                    Rolls.Add(new Roll(ramdomPins));
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
