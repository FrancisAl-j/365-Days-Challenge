// 5. Swap two variable values

using System;

public class day5
{
    public static void swapVariable(string name1, string name2)
    {
        Console.WriteLine("Before Swap");
        Console.WriteLine($"name1: {name1}");
        Console.WriteLine($"name2: {name2}");
        // Swapping the values
        string firstValue = name1;
        name1 = name2;
        name2 = firstValue;
        
        Console.WriteLine("After the swap");
        Console.WriteLine($"name1: {name1}");
        Console.WriteLine($"name2: {name2}");

    }
}