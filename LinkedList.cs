using System;
using System.Collections.Generic;
public class LinkedListManager
{
    private LinkedList<int> m_list;
    public LinkedListManager()
    {
        m_list = new LinkedList<int>();
    }
    public void AddFirst(int number)//O(1)
    {
        m_list.AddFirst(number);
    }
    public void AddLast(int number) //O(1)
    {
        m_list.AddLast(number);
    }
    public void Remove(int number) //O(1)
    {
        m_list.Remove(number);
    }
    public bool Contains(int number) //O(n)
    {
        return m_list.Contains(number);
    }
    public void Print()// O(n)
    {
        foreach ( var item in m_list )
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        LinkedListManager ll = new LinkedListManager();
        ll.AddFirst(10);
        ll.AddLast(20);
        ll.AddFirst(30);
        ll.Print();

        ll.Remove(20);
        ll.Print();

        if(ll.Contains(10)){Console.Write("Y");}
    }
}