using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class StandartGame : BasicGame
    {
        public StandartGame(string nameOfGame, int rating) : base(nameOfGame)
        {
            base.Rating = rating;
        }
        public override int ForRating()
        {
            return this.Rating;
        }
    }
}
