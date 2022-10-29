using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class AccountX2 : GameAccount
    {
        public int CurrentSpecialRating 
        {
            get {
                int currentSpecialRating = 0;
                foreach (BasicGame element in allGames)
                {
                    currentSpecialRating += 2*element.ForRating();
                }

                return currentSpecialRating;
            } 
        }
        public AccountX2(string userName) : base(userName)
        {

        }


        public override void LoseGame(BasicGame game, string userName, string opponentName)
        {
            
            base.LoseGame(game, userName, opponentName);
            game.Rating = -game.Rating + 1;
            allGames.Add(game);
        }


    }
}
