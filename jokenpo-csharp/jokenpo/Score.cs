using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace jokenpo
{
    public class Score
    {
        public int FirstPlayerWins { get; set; }
        public int SecondPlayerWins { get; set; }
        public int Ties { get; set; }
        public int TotalOfRounds { get { return FirstPlayerWins + SecondPlayerWins + Ties; } }
    }
}
