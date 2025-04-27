// 9. Find the largest of three numbers

using System;

public class day9 {
    public static void findTheLarget(int num1, int num2, int num3) {
        if(num1 > num2 && num1 > num3) {
            Console.WriteLine($"{num1} is the largest of three numbers");
        }
        else if (num2 > num1 && num2 > num3) {
            Console.WriteLine($"{num2} is the largest of three numbers");
        }
        else {
            Console.WriteLine($"{num3} is the largest of three numbers");
        }

    }
}