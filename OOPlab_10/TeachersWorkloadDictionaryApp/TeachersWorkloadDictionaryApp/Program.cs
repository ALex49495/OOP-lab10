using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<int, TeachersWorkload> teachersWorkloads = new Dictionary<int, TeachersWorkload>();

        teachersWorkloads.Add(1, new TeachersWorkload(1, "John Doe", "Math", 20));
        teachersWorkloads.Add(2, new TeachersWorkload(2, "Jane Smith", "Physics", 15));
        teachersWorkloads.Add(3, new TeachersWorkload(3, "Emily Johnson", "Chemistry", 18));

        Console.WriteLine("Teachers Workload:");
        foreach (var workload in teachersWorkloads)
        {
            Console.WriteLine(workload.Value);
        }

        if (teachersWorkloads.ContainsKey(2))
        {
            teachersWorkloads[2].Hours = 25;
            Console.WriteLine("\nUpdated Teachers Workload for Teacher ID 2:");
            Console.WriteLine(teachersWorkloads[2]);
        }

        if (teachersWorkloads.Remove(3))
        {
            Console.WriteLine("\nTeachers Workload after removing Teacher ID 3:");
            foreach (var workload in teachersWorkloads)
            {
                Console.WriteLine(workload.Value);
            }
        }

        if (teachersWorkloads.TryGetValue(1, out TeachersWorkload workload1))
        {
            Console.WriteLine($"\nFound workload for Teacher ID 1: {workload1}");
        }

        Console.WriteLine($"\nNumber of elements in the collection: {teachersWorkloads.Count}");

        teachersWorkloads.Clear();
        Console.WriteLine("\nTeachers Workload after clearing the collection:");
        foreach (var workload in teachersWorkloads)
        {
            Console.WriteLine(workload.Value);
        }
    }
}
