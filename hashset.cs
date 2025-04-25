using System;
using System.Collections.Generic;
public class HashSetManager
{
    private HashSet <int> numbers;
    public HashSetManager()
    {
        numbers = new HashSet<int>();
    }
    public void Add(int number)
    {
        numbers.Add(number);
    }
    public void Remove()
    {
        numbers.Remove();
    }
    public void Print()
    {
        foreach (int number in numbers)
        {
            Console.Write(number);
        }
        Console.WriteLine();
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        HashSetManager h = new HashSetManager();
         h.Add(10);
        h.Add(20);
        h.Add(30);
        h.Print();

        h.Remove(20);
        h.Print();

        h.Add(30); // Thử thêm phần tử đã tồn tại
        h.Print();
        
        h.Remove(40); // Thử xóa phần tử không tồn tại
    }
}