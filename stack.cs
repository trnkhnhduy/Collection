using System;
using System.Collections.Generic;
public class StackManager
{
    private Stack<int> numbers;
    public StackManager()
    {
        numbers = new Stack<int>();
    }
    public void Add (int number)
    {
        numbers.Push(number);
    }
    public void Remove()
    {
        numbers.Pop();
    }
    public bool Contains(int number)
    {
        return numbers.Contains(number);
    }
    public void Print()
    {
        foreach ( var number in numbers )
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
        StackManager s = new StackManager();
        s.Add(10);
        s.Add(20);
        s.Add(30);
        s.Print();

        s.Remove(20);
        s.Print();

        s.Add(30); // Thử thêm phần tử đã tồn tại
        s.Print();
        
        s.Remove(40); // Thử xóa phần tử không tồn tại
        s.Contains(0);
    }
}