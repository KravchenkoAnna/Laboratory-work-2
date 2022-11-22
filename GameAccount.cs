using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class GameAccount
    {
        protected List<BasicGame> allGames = new List<BasicGame>();
        public string UserName { get; }
        public int GamesCount { get; }
        public int CurrentRating
        {
            get
            {
                int currentRating = 0;
                foreach (BasicGame element in allGames)
                {
                    currentRating += element.ForRating();
                }

                return currentRating;
            }
            

        }

        public GameAccount(string userName)
        {
            UserName = userName;
        }

        public void WinGame(BasicGame game, string userName, string opponentName)
        {
            if (game.ForRating() < 1)
            {
                throw new ArgumentException("Invalid Game. No winner");
            }

            allGames.Add(game);
            Console.WriteLine("{0} won and {1} lost", userName, opponentName);

        }

        public virtual void LoseGame(BasicGame game, string userName, string opponentName)
        {
            if (game.ForRating() < 1)
            {
                throw new ArgumentException("Invalid Game. No winner");
            }
            
            Console.WriteLine("{0} won and {1} lost", opponentName, userName);
        }
        public string GetHistory()
        {
            var report = new StringBuilder();
            int currentRating = 0;
            int gamesCounter = 0;
            report.AppendLine("Name\t\tGoal\tCurrent Rating");
            foreach (var item in allGames)
            {
                currentRating += item.Rating;               
                report.AppendLine($"{item.NameOfGame}\t{item.Rating}\t{currentRating}");
            }
            return report.ToString();
        }

    }
}
