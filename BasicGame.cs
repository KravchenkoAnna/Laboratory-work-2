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
     
        public BasicGame(string nameOfGame) 
        {
            NameOfGame = nameOfGame;            
            Number = id.ToString();
            id++;

        }
        
        public abstract int ForRating();
    }
}
