using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class Room
    {
        private List<Element> _elements = new List<Element>();

        // Constructor calls abstract Factory method
        public Room()
        {
            this.CreateRoom();
        }

        public List<Element> Elements
        {
            get { return _elements; }
        }

        // Factory Method
        public abstract void CreateRoom();
    }

    public class BedRoom : Room
    {
        public override void CreateRoom()
        {
            Elements.Add(new Bed());
            Elements.Add(new Desk());
            Elements.Add(new Computer());
        }
    }

    public class LivingRoom : Room
    {
        public override void CreateRoom()
        {
            Elements.Add(new Television());
            Elements.Add(new Kitchen());
            Elements.Add(new Chair());
        }
    }
}
