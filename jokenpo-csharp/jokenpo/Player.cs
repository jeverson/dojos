using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jokenpo
{
    public class Player : IPlayer
    {
        public Play play()
        {
            var number = new Random().Next(0, 2).ToString();
            return (Play) Enum.Parse(typeof(Play), number);
        }

        public string WinningMessage()
        {
            return "I knew you could not beat me not even in your dreams.";
        }


        public string LosingMessage()
        {
            return "You are probably thinking I let you win.. and you're right...hahaha";
        }
    }
}
