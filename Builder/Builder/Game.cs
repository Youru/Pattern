using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Game
    {
        private string _boardGameType;
        private Dictionary<string, string> _parts = new Dictionary<string, string>();

        public Game(string _boardGameType)
        {
            this._boardGameType = _boardGameType;
        }

        public void AddPart(string typePart, string content)
        {
            _parts.Add(typePart, content);
        }

        public Dictionary<string, string>  GetGame => _parts;
        
    }
}
