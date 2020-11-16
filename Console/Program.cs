using System;
using System.Collections.Generic;

namespace Arrayz
{
    class Program
    {
        static void Main(string[] args)
        {

            //string[] names = new string[]
            //{
            //    "Reeva Walmsley",
            //    "Will Dorsey",
            //    "Vivienne Singh",
            //    "Geraldine Morton",
            //    "King Colley",
            //    "Perry Mcdonnell",
            //    "Gloria Klein",
            //    "Kameron Riley",
            //    "Aliya Villarreal",
            //    "Alex Dudley"
            //};

            //int[] marks = new int[]
            //{
            //    5,
            //    4,
            //    5,
            //    3,
            //    4,
            //    5,
            //    5,
            //    5,
            //    4,
            //    5
            //};

            //Console.WriteLine(names.Length);
            //Console.WriteLine(marks.Length);

            //Console.WriteLine($"1. {names[0]} | {marks[0]}");
            //Console.WriteLine($"2. {names[1]} | {marks[1]}");
            //Console.WriteLine($"3. {names[2]} | {marks[2]}");
            //Console.WriteLine($"4. {names[3]} | {marks[3]}");
            //Console.WriteLine($"5. {names[4]} | {marks[4]}");
            //Console.WriteLine($"6. {names[5]} | {marks[5]}");
            //Console.WriteLine($"7. {names[6]} | {marks[6]}");
            //Console.WriteLine($"8. {names[7]} | {marks[7]}");
            //Console.WriteLine($"9. {names[8]} | {marks[8]}");
            //Console.WriteLine($"10. {names[9]} | {marks[9]}");



            //Console.ReadKey();

            var names = new List<string>{"Alex", "John", "Danny", "Brad", "Steven", "Rebecca"};

            Console.WriteLine("Please add name");
            string addition = Console.ReadLine();

            Console.WriteLine("Please add another name");
            string addition1 = Console.ReadLine();

            names.Add(addition);
            names.Add(addition1);


            Console.WriteLine(names[0]);
            Console.Clear();
            foreach (var name in names)
            {
                Console.WriteLine(name);   
            }
            
            Console.ReadKey();

        }
    }
}
