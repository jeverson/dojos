using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jokenpo
{
    public class Judge : IJudge
    {
        public WinnerPosition judge(Play firstPlayerMove, Play secondPlayerMove)
        {
            if (firstPlayerMove == secondPlayerMove)
                return WinnerPosition.None;
            if (
                (firstPlayerMove == Play.Paper && secondPlayerMove == Play.Stone) ||
                (firstPlayerMove == Play.Scissors && secondPlayerMove == Play.Paper) ||
                (firstPlayerMove == Play.Stone && secondPlayerMove == Play.Scissors)
                )
                return WinnerPosition.First;
            else
                return WinnerPosition.Second;
        }
    }
}
