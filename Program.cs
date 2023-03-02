public class Program
{
    static void Main(string[] args)
    {
        /// Simple tuple
        Tuple<int, string, string> person = new Tuple<int, string, string>(1, "Arunkumar", "Parthasarathy");

        /// Display tuple item
        Console.WriteLine("Simple tuple");
        Console.WriteLine($"Item 1:{person.Item1}");
        Console.WriteLine($"Item 2:{person.Item2}");
        Console.WriteLine($"Item 3:{person.Item3}\n");

        /// Tuple without constructor
        var address = Tuple.Create(45, "Pondicherry", "India");

        /// Display tuple item
        Console.WriteLine("Tuple without constructor");
        Console.WriteLine($"Item 1:{address.Item1}");
        Console.WriteLine($"Item 2:{address.Item2}");
        Console.WriteLine($"Item 3:{address.Item3}\n");

        /// Nested tuple
        var personDetails = Tuple.Create(1, "Arunkumar", "Parthasarathy", Tuple.Create(45, "Pondicherry", "India"));

        /// Display nested tuple item
        Console.WriteLine("Nested tuple");
        Console.WriteLine($"Item 1:{personDetails.Item1}");
        Console.WriteLine($"Item 2:{personDetails.Item2}");
        Console.WriteLine($"Item 3:{personDetails.Item3}");
        Console.WriteLine($"Item 4:{personDetails.Item4}");
        Console.WriteLine($"Item 4->1:{personDetails.Item4.Item1}");
        Console.WriteLine($"Item 4->2:{personDetails.Item4.Item2}");
        Console.WriteLine($"Item 4->3:{personDetails.Item4.Item3}\n");

        /// Use case of Tuple
        var xs = new[] { 4, 7, 9 };
        var limits = FindMinMax(xs);
        Console.WriteLine($"Limits of [{string.Join(" ", xs)}] are {limits.min} and {limits.max}");
    }

    static (int min, int max) FindMinMax(int[] input)
    {
        if (input == null || input.Length == 0)
        {
            throw new ArgumentNullException("Input cannot be null");
        }

        // Initialize min to MaxValue so every value in the input 
        // is less than this initial value.
        var min = int.MaxValue;
        // Initialze max to MinValue so every value in the input
        // is greater than this initial value.
        var max = int.MinValue;
        foreach (var i in input)
        {
            if (i < min)
            {
                min = i;
            }
            if (i > max)
            {
                max = i;
            }
        }
        return (min, max);

    }
}
