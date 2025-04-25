using System;
using System.Collections.Generic;

public class ListManager 
{
    private List<int> numbers;
    public ListManager()
    {
        numbers = new List<int> ();
    }
    public void Add(int number) // có big O là 1 
    {
        numbers.Add(number);
        int index = numbers.IndexOf (number); 
    }
    public void Remove(int number) // có big O là n
    {
        numbers.Remove(number);
    }
    public void Update(int number, int newvalue) // có big O là 1 
    {
        int index = numbers.IndexOf (number);
        numbers[index]= newvalue;
    }
    public void Print () // có big O là n
    {
        foreach(var number in numbers)
        {
            Console.WriteLine(number + " ");
        }
        Console.WriteLine();
    }
    public void Sort ()
    {
        numbers.Sort();
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        ListManager l = new ListManager();
        l.Add(10);
        l.Add(20);
        l.Add(30);
        l.Print();

        l.Remove(20);
        l.Print();

        l.Update(30, 40);
        l.Print();
    }
}