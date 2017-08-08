using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jokenpo
{

    public enum Play { 
        Stone = 0,
        Paper = 1, 
        Scissors = 2
    }

    public interface IPlayer
    {
        Play play();
        string WinningMessage();
        string LosingMessage();
    }
}
