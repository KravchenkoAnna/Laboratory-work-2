using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class TrainingGame : BasicGame
    {
        public TrainingGame(string nameOfGame) : base(nameOfGame)
        {

        }
        public override int ForRating()
        {
            return this.Rating;
        }
    }
}
