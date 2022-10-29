using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    abstract class BasicGame
    {
        public string NameOfGame { get; }
        public int Rating { get;  set; }
        public string Number { get; }

        private static int id = 123;

        public int Counter
        {
            get
            {
                int counter = 0;
                counter++;
                return counter;
            }


        }
        public BasicGame(string nameOfGame, int rating) // конструктор для StandartGame
        {
            NameOfGame = nameOfGame;
            Rating = rating;
            Number = id.ToString();
            id++;

        }

        public BasicGame(string nameOfGame) // конструктор для TrainingGame
        {
            NameOfGame = nameOfGame;
            this.Rating = 1;
            Number = id.ToString();
            id++;

        }
        
        public abstract int ForRating();
    }
}
