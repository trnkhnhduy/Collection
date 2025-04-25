using System;
using System.Collections.Generic;

public class MyNumbers : IEnumerable<int>, ICollection<int>
{
    private List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

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

    public void Add(int number)
    {
        numbers.Add(number);
    }

    public void Clear()
    {
        numbers.Clear();
    }

    public bool Contains(int number)
    {
        return numbers.Contains(number);
    }

    public void CopyTo(int[] array, int arrayIndex)
    {
        numbers.CopyTo(array, arrayIndex);
    }

    public bool Remove(int number)
    {
        return numbers.Remove(number);
    }

    public int Count => numbers.Count;
    public bool IsReadOnly => false;
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

    public static void Main(string[] args)
    {
        MyNumbers myNumbers = new MyNumbers();
        PrintNumbers(myNumbers); // In số ban đầu

        myNumbers.Add(6);
        Console.WriteLine("After adding 6:");
        PrintNumbers(myNumbers); // In sau khi thêm 6

        myNumbers.Remove(3);
        Console.WriteLine("After removing 3:");
        PrintNumbers(myNumbers); // In sau khi xóa 3

        Console.WriteLine("Contains 4: " + myNumbers.Contains(4)); // true
        Console.WriteLine("Count: " + myNumbers.Count); // 6
    }
}
