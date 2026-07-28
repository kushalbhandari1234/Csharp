using System;

class Question11
{
    static void Main()
    {
        double price1 = 10.50;
        int qty1 = 2;

        double price2 = 5.00;
        int qty2 = 4;

        double price3 = 20.00;
        int qty3 = 1;

        double total1 = price1 * qty1;
        double total2 = price2 * qty2;
        double total3 = price3 * qty3;

        double grandTotal = total1 + total2 + total3;

        Console.WriteLine($"Product 1 Total: {total1}");
        Console.WriteLine($"Product 2 Total: {total2}");
        Console.WriteLine($"Product 3 Total: {total3}");
        Console.WriteLine($"Grand Total Bill: {grandTotal}");
    }
}
