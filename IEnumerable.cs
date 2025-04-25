using System;
using System.Collections;
using System.Collections.Generic;

public class MyNumbers : IEnumerable<int>
{
    private int[] numbers = { 1, 2, 3, 4, 5 };

    public IEnumerator<int> GetEnumerator()
    {
        foreach (var number in numbers)
        {
            yield return number;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

public class Program
{
    public static void PrintNumbers(IEnumerable<int> numbers)
    {
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
    }

}