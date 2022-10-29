using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class GameFactory
    {
        public BasicGame CreateStandartGame(string nameOfGame, int rating)
        {
            return new StandartGame(nameOfGame, rating);
        }

        public BasicGame CreateTrainingGame(string nameOfGame)
        {
            return new TrainingGame(nameOfGame);
        }

        public BasicGame CreateDoubleGame(string nameOfGame, int rating)
        {
            return new DoubleGame(nameOfGame, rating);
        }

    }
}
