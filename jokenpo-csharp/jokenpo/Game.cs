using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jokenpo
{
    public class Game : IGame
    {
        public IPlayer Player1 { get; set; }
        public IPlayer Player2 { get; set; }
        public IJudge Judge { get; set; }

        private Score score;

        public Game() {
            score = new Score();
        }

        public Score RunOneRound()
        {
            var winner = Judge.judge(Player1.play(), Player2.play());
            UpdateScore(winner);
            return score;
        }

        private void UpdateScore(WinnerPosition winner)
        {
            if (winner == WinnerPosition.First)
                score.FirstPlayerWins++;
            else if (winner == WinnerPosition.Second)
                score.SecondPlayerWins++;
            else
                score.Ties++;
        }
    }
}
