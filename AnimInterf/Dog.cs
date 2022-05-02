using System;

namespace AnimInterf
{
    public class Dog : Animal
    {
        public override string Sound()
        {
            return base.Sound() + "Woof!";
        }
    }
}
