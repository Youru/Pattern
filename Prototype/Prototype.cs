using System;

namespace Prototype
{
    public abstract class Prototype
    {
        private string _id;

        public Prototype(string id)
        {
            this._id = id;
        }

        public string Id => _id;

        public abstract Prototype Clone();
    }

    public class Ninja : Prototype
    {
        public Ninja(string id) : base(id)
        {
        }

        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }

    public class Thief : Prototype
    {
        public Thief(string id) : base(id)
        {
        }

        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }
}
