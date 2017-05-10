using System;
using System.Collections.Generic;
using System.Text;

namespace HouseWorkFactory
{
    public class Child
    {
        private Parent _parent;
        private Chore _chore;

        public Child (HouseWorkFactory factory)
        {
            _parent = factory.CreateParent();
            _chore = factory.CreateChore();
        }

        public string RunAction()
        {
            return _parent.Order(_chore);
        }
    }
}
