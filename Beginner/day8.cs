// 8. Check if a number is even or odd

using System;

public class day8
{
    public static void evenOrOdd(int num) { 
        if(num % 2 == 0) {
            Console.WriteLine($"{num} is an Even number");
        }
        else {
            Console.WriteLine($"{num} is an Odd number");
        }
    }
}