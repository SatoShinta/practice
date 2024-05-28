using System;
using System.Linq;
class Program
{
    static void Main()
    {
        int[] XYZ = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int X = XYZ[0];
        int Y = XYZ[1];
        int Z = XYZ[2];
        if (Z >= 10)
        {
            Console.WriteLine("YES");
        }
        else if (X >= 10 && Y >= 10)
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
}
