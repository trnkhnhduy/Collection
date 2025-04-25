using System;
using System.Collections.Generic;
public class QueueManager
{
    private Queue<int> numbers;
    public QueueManager()
    {
        numbers = new Queue<int>();
    }
    public void Add(int number)
    {
        numbers.Enqueue(number);
    }
    public void Remove ()
    {
        numbers.Dequeue();
    }
    public void Print()
    {
        foreach ( var number in numbers)
        {
            Console.Write(number + " " );
        }
        Console.WriteLine();
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        QueueManager q = new QueueManager();
        q.Add(10);
        q.Add(20);
        q.Add(30);
        q.Print();

        q.Remove();
        q.Print();

        q.Remove();
        q.Print();
        
        q.Remove(); 
        q.Remove(); // Kiểm tra có còn phần tử nào hay không
    }
}