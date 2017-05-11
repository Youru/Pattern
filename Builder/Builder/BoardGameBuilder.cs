using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class BoardGameBuilder : GameBuilder
    {
        public BoardGameBuilder()
        {
            this.game = new Game("BoardGame");
        }

        public override void BuildBoard()
        {
            game.AddPart("board","Large board");
        }

        public override void BuildBox()
        {
            game.AddPart("box","Huge!!");
        }

        public override void BuildComponent()
        {
            game.AddPart("component","So many cards and looks this mini");
        }

        public override void BuildRules()
        {
            game.AddPart("rules","RTFM");
        }
    }
}
