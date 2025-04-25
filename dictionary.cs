using System;
using System.Collections.Generic;
public class DictionaryManager
{
    private Dictionary <int,string> dictionary;
    public DictionaryManager()
    {
        dictionary = new Dictionary<int ,string>();
    }
    public void Add (int key, string value)
    {
        dictionary.Add (key, value);
    }
    public void Remove (int key)
    {
        dictionary.Remove (key);
    }
    public bool Contains (int key)
    {
        if (dictionary.ContainsKey (key)){Console.Write("Y");}
    }
    public void Print()
    {
        foreach (var kvp in dictionary)
        {
            Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
        }
        Console.WriteLine();
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        DictionaryManager dm = new DictionaryManager();
        dm.Add(1, "Apple");
        dm.Add(2, "Banana");
        dm.Add(3, "Cherry");
        dm.Print();

        dm.Remove(2);
        dm.Print();
        dm.Contains(3);
    }
}