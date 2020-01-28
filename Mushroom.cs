using System;

public class Mushroom : Power
{
        public int speed = 2;

        public void Accelerate()
    {
        use = true;
        if (use == true)
        {
            Console.WriteLine("Status of er een item gebruikt is: " + use + ".");
            Console.WriteLine("Je bent " + speed + " keer sneller geworden.");

        }

    }
}