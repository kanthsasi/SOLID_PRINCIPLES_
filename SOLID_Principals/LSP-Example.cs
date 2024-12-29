using System;


namespace SOLID_Principals
{
    public class LSP_Example
    {
        public abstract class Fruit
        {
            public abstract void GetColor();
        }

        public class Apple : Fruit
        {
            public override void GetColor()
            {
                Console.WriteLine("Red");
            }
        }

        public class Orange : Fruit
        {
            public override void GetColor()
            {
                Console.WriteLine("Orange");
            }
        }

      /*  static void Main()
        {
            Fruit fruit = new Apple();
            fruit.GetColor();
            fruit = new Orange();
            fruit.GetColor();
        }
      */
    }
}
