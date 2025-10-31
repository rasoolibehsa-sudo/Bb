using System;

class Program
{
    static void Main()
    {
        Console.Write("عدد را وارد کنید: ");
        int n = int.Parse(Console.ReadLine());

        long factorial = 1;

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }
        Console.WriteLine(factorial);
    }
}
