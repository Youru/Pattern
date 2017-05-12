using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public abstract class GameBuilder
    {

        protected Game game;
        public Game Game => game;
        public abstract void BuildBox();
        public abstract void BuildBoard();
        public abstract void BuildComponent();
        public abstract void BuildRules();
    }
}
