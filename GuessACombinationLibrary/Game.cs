using System;
using System.Collections.Generic;
using System.Text;

namespace GuessACombinationLibrary
{
    public class Game
    {
        private List<Types> wantedCombination;
        private Random random = new Random();

        private List<Types> attempt;

        public int counter { get; set; }

        public Game()
        {
            wantedCombination = new List<Types>();
            attempt = new List<Types>();

            counter = 1;
            randomize(wantedCombination);
        }

        private void randomize(List<Types> wantedCombination)
        {
            for (int i = 0; i < 4; ++i) {
                wantedCombination.Add((Types)random.Next(0, 5));
            }
        }

        public string checkAttempt() {

            string output = "";
            int numberOfReds = 0;
            int counter = 0;

            for (int i = 0; i < 4; ++i)
                {
                    if (attempt[i] == wantedCombination[i])
                    {
                        output += "R";
                        numberOfReds++;
                    }
                }
                foreach (var w in wantedCombination)
                {
                        foreach (var a in attempt)
                        {
                            if (w == a) {
                                attempt.Remove(a);
                                counter++;
                                break;
                            }

                        
                        }
                }

            for (int i = 0; i < counter - numberOfReds; ++i)
                output += "Y";

            if (output.Length != 4)
                for (int i = 0; i < 4 - output.Length; ++i)
                    output += " ";

            attempt.Clear();

            return output;

        }

        public void Add(Types type)
        {
            attempt.Add(type);
            counter++;
        }

        public void Delete()
        {
            if (attempt.Count != 0)
            {
                attempt.RemoveAt(attempt.Count - 1);
                counter--;
            }
        }

        public bool attemptSize()
        {
            if (attempt.Count == 4)
                return true;
        
            return false;
        }
    }

    public enum Types { 
        Joker,
        Star,
        Spades,
        Hearts,
        Clubs,
        Diamonds
    };

}
