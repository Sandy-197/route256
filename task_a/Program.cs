using System;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        int caseCount = int.Parse(Console.ReadLine()!);
        int [] array = new int[caseCount];
        for (var i = 0; i < caseCount; i++)
        {
            array[i]= Console.ReadLine()!.Split(' ').Select(item => int.Parse(item)).ToArray().Sum();
        }
        foreach (var item in array)
        {
           Console.WriteLine(item); 
        }
    }
}