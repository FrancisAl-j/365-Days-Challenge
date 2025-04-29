// 10. Check if a number is positive or negative

using System;

public class day10 {
    public static void negatieOrPositive(int num) {
        if(num > 0) {
            Console.WriteLine($"{num} is a Positive number");
        }
        else {
            Console.WriteLine($"{num} is a Negative number");
        }
    }
}