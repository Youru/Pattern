using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class DiceGameBuilder : GameBuilder
    {
        public DiceGameBuilder()
        {
            this.game = new Game("DiceGame");
        }

        public override void BuildBoard()
        {
            game.AddPart("board", "No board");
        }

        public override void BuildBox()
        {
            game.AddPart("box", "Awesome black");
        }

        public override void BuildComponent()
        {
            game.AddPart("component", "Full of dice");
        }

        public override void BuildRules()
        {
            game.AddPart("rules", "Unleash the kraken");
        }
    }
}
