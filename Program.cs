
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace KnowledgeCheck2
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("How many records do you want to add? ");
            var NumOfRecords = int.Parse(Console.ReadLine());

            var recordList = new List<Cat>();
            for (int i = 0; i < NumOfRecords; i++)
            {
                // In this loop, populate the object's properties using Console.ReadLine()
                var Cat = new Cat();

                Console.WriteLine("Enter the value for number of legs");
                Console.ReadLine();
                Console.WriteLine("Enter the value for number of tails");
                Console.ReadLine();
                Console.WriteLine("Enter the value for number of heads");
                Console.ReadLine();
                Console.WriteLine("This Cat has " + Cat.legs + " Legs!");
                Console.WriteLine("This Cat has " + Cat.tail + " Tail!");
                Console.WriteLine("This Cat has " + Cat.head + " head that must be scratched!");
                Cat.Fur();

                Console.ReadKey();
                recordList.Add(Cat);
            }

        }

        // Print out the list of records using Console.WriteLine()
    }

}
public class Animal
{
    public int legs = 4;
    public int tail = 1;
    public int head = 1;
    public string? animalName;
    public static void Fur()
    {
        Console.WriteLine("This Animal is Furry!");
    }
}
public class Cat : Animal
{
    public int legs = 4;
    public int head = 1;
    public int tail = 1;

    public Cat()
    {
    }

    public Cat(int legs, int head, int tail)
    {
        this.legs = legs;
        this.head = head;
        this.tail = tail;
    }
}




