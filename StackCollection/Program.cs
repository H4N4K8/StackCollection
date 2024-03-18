using System;

namespace Stack
{
    internal class StackCollection
    {
        static void Main(string[] args)
        {
            Stack<string> numbers = new Stack<string>();

            numbers.Push("1");
            numbers.Push("2");
            numbers.Push("3");
            numbers.Push("4");
            numbers.Push("5");

            int num = 0;
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Member name: ");
                numbers.Push(Console.ReadLine());
            }
            Console.WriteLine("Write the number you would like to search for 1-5");
            string Number = Console.ReadLine();
              if (numbers.Contains(Number))
                {
                    Console.WriteLine("That number is still in the collection");
                }
              else
                {
                    Console.WriteLine("That numnber has been removed");
                }

            string firstMem = numbers.Peek();  
            Console.WriteLine($"Would you like to remove the number {firstMem}? Y or N.");
            string answer = Console.ReadLine();
            while (answer == "Y" || answer == "y")
            {
                numbers.Pop();  
                firstMem = numbers.Peek();
                Console.WriteLine($"Would you like to remove the number {firstMem}? Y or N.");
                answer = Console.ReadLine();
            }

            Console.WriteLine($"Here are the {numbers.Count()} numbers ");
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }
        }
    }
}