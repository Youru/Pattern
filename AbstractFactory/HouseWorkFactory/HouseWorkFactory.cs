using System;

namespace HouseWorkFactory
{
    public abstract class HouseWorkFactory
    {
        public abstract Parent CreateParent();
        public abstract Chore CreateChore();
    }

    public class DoTheCooking : HouseWorkFactory
    {
        public override Chore CreateChore()
        {
            return new Cooking();
        }

        public override Parent CreateParent()
        {
            return new Mother();
        }
    }

    public class WontDoTheCleaning : HouseWorkFactory
    {
        public override Chore CreateChore()
        {
            return new Cleaning();
        }

        public override Parent CreateParent()
        {
            return new Father();
        }
    }
}