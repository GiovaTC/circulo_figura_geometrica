using System;

class Program
{
    static void Main()
    {
        int radio = 10;
        double aspectRatio = 2.0;
        double precision = 0.5;

        for (int y = -radio; y <= radio; y++)
        {
            for (int x = -radio; x <= radio; x++)
            {
                double distance = Math.Sqrt(Math.Pow(x * aspectRatio, 2) + Math.Pow(y, 2));
                if(Math.Abs(distance - radio) < precision)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}