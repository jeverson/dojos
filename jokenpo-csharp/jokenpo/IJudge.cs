using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jokenpo
{
    public enum WinnerPosition {
        None = 0,
        First = 1, 
        Second = 2
    }

    public interface IJudge
    {
        WinnerPosition judge(Play firstPlayerMove, Play secondPlayerMove);
    }
}
