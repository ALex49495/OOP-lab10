using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        ArrayList arrayList = new ArrayList();

        arrayList.Add("Hello");
        arrayList.Add(42);
        arrayList.Add(3.14);
        arrayList.Add("World");
        arrayList.Add(100);

        Console.WriteLine("Initial ArrayList:");
        foreach (var item in arrayList)
        {
            Console.WriteLine(item);
        }

        arrayList.Insert(1, "Inserted String");
        Console.WriteLine("\nArrayList after insertion:");
        foreach (var item in arrayList)
        {
            Console.WriteLine(item);
        }

        arrayList.Remove(42);
        Console.WriteLine("\nArrayList after removal:");
        foreach (var item in arrayList)
        {
            Console.WriteLine(item);
        }

        arrayList[2] = 2.718;
        Console.WriteLine("\nArrayList after update:");
        foreach (var item in arrayList)
        {
            Console.WriteLine(item);
        }

        bool containsHello = arrayList.Contains("Hello");
        Console.WriteLine($"\nContains 'Hello': {containsHello}");

        arrayList.Clear();
        Console.WriteLine("\nArrayList after clearing:");
        foreach (var item in arrayList)
        {
            Console.WriteLine(item);
        }
    }
}
