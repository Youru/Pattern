using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class GameMaker
    {
        public Dictionary<string, string> Construct(GameBuilder gameBuilder)
        {
            gameBuilder.BuildBoard();
            gameBuilder.BuildBox();
            gameBuilder.BuildComponent();
            gameBuilder.BuildRules();

            return gameBuilder.Game.GetGame;
        }
    }
}
