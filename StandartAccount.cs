using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class StandartAccount : GameAccount
    {
        public StandartAccount(string userName) : base(userName)
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
