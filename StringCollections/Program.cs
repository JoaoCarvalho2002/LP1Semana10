using System;
using System.Collections;
using System.Collections.Generic;

namespace StringCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello, World!");

            List<string> cities = new List<string>();
            cities.Add("New York");
            cities.Add("London");
            cities.Add("Mumbai");
            cities.Add("Chicago");
            cities.Add("London");

            Console.WriteLine();

            Stack<string> numbers = new Stack<string>();
            numbers.Push("one");
            numbers.Push("two");
            numbers.Push("three");
            numbers.Push("four");
            numbers.Push("one");

            Queue<string> elements = new Queue<string>();
            elements.Push("Fire");
            elements.Push("Water");
            elements.Push("Rock");
            elements.Push("Air");
            elements.Push("Water");

            HashSet<string> Dogs = new HashSet<string>();
            Dogs.Push("Shepherd");
            Dogs.Push("labrador");
            Dogs.Push("Beagle");
            Dogs.Push("Golden Retriever");
            Dogs.Push("Shepherd");

        }
    }
}
