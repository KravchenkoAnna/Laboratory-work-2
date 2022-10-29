using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class DoubleGame : BasicGame
    {
        public DoubleGame(string nameOfGame, int rating) : base(nameOfGame, rating)
        {

        }
        public override int ForRating()
        {
            return 2*this.Rating;
        }
    }
}
