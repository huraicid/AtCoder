using System;
using System.Linq;
using System.Collections.Generic;

public class Coodinate
{
    long x;
    long y;

    public Coodinate(long x, long y) {
        this.x = x;
        this.y = y;
    }

    public static void Main()
    {
        var line = System.Console.ReadLine();
        var value = line.Split(' ');
        var values = value.Select(long.Parse).ToArray();

        var point1s = new List<Coodinate> {
            new Coodinate(values[0] + 1, values[1] + 2),
            new Coodinate(values[0] - 1, values[1] - 2),
            new Coodinate(values[0] + 2, values[1] + 1),
            new Coodinate(values[0] - 2, values[1] - 1),
            new Coodinate(values[0] + 2, values[1] - 1),
            new Coodinate(values[0] + 1, values[1] - 2),
            new Coodinate(values[0] - 2, values[1] - 1),
            new Coodinate(values[0] - 1, values[1] + 2)
        };

        var point2s = new List<Coodinate> {
            new Coodinate(values[2] + 1, values[3] + 2),
            new Coodinate(values[2] - 1, values[3] - 2),
            new Coodinate(values[2] + 2, values[3] + 1),
            new Coodinate(values[2] - 2, values[3] - 1),
            new Coodinate(values[2] + 2, values[3] - 1),
            new Coodinate(values[2] + 1, values[3] - 2),
            new Coodinate(values[2] - 2, values[3] - 1),
            new Coodinate(values[2] - 1, values[3] + 2),
        };

        int result = 0;
        foreach (var point1 in point1s)
        {
            foreach (var point2 in point2s)
            {
                if(point1.x == point2.x && point1.y == point2.y)
                {
                    result++;
                }
            }

            if(result > 0)
            {
                break;
            }
        }
        if (result > 0)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}