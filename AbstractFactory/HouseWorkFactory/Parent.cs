using System;

namespace HouseWorkFactory
{
    public abstract class Parent
    {
        public abstract string Order(Chore chore);
    }

    public class Mother : Parent
    {
        public override string Order(Chore chore)
        {
            return this.GetType().Name + " allow the " + chore.GetType().Name;
        }
    }

    public class Father : Parent
    {
        public override string Order(Chore chore)
        {
            return this.GetType().Name + " forbid the " + chore.GetType().Name;
        }
    }
}