using System;

namespace les3
{
    class Program
    {
        static void Main(string[] args)
        {
            Banana banaan = new Banana();
            Bigmushroom bigmushroom = new Bigmushroom();
            Mushroom mushroom = new Mushroom();

            banaan.Throw();
            bigmushroom.Grow();
            mushroom.Accelerate();
        }
    }
}
