using System;

public class Banana : Power
{
    public string function = "You slip if you drive over it";

    public void Throw()
    {
        use = true;
        
        if (use == true)
        {
            Console.WriteLine("Status of er een item gebruikt is: " + use + ".");
        }
        Console.WriteLine(function);

    }

}
