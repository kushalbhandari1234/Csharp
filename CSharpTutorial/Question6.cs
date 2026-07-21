using System;

public class Question6
{
    public void Swap()
    {
        int a = 20;
        int b = 30;

       
        (a, b) = (b, a);

        Console.WriteLine($"a is {a}");
        Console.WriteLine($"b is {b}");
    }
}