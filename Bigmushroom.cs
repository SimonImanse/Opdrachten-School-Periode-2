using System;

public class Bigmushroom : Power
{
    public int grow = 3;

    public void Grow()
    {
        use = true;
        if (use == true)
        {
            Console.WriteLine("Status of er een item gebruikt is: " + use + ".");
            Console.WriteLine("Je bent " + grow + " keer groter geworden.");

        }

    }
}