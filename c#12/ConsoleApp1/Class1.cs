namespace ConsoleApp1
{
    public class Class1
    {
        public static void Main()
        {
            // Demonstrate Primary Constructor
            var person = new Person("Alice", 30);
            Console.WriteLine($"{person.Name} is {person.Age} years old.");

            // Demonstrate Lambda Expression
            var addResult = AddNumbers(5, 10);
            Console.WriteLine($"Sum: {addResult}");

            // Demonstrate Raw String Literals
            var message = """
            Hello, World!
            This is a raw string literal.
            It can span multiple lines without escaping.
            """;
            Console.WriteLine(message);

            // Demonstrate Static Abstract Members in Interface
            IShape circle = new Circle(5);
            Console.WriteLine($"Area of the circle: {circle.Area()}");

            // Demonstrate Pattern Matching
            HandleInput(42);
            HandleInput("Hello");
            HandleInput(3.14);

            // Lambda Expression Example
            static int AddNumbers(int x, int y) => x + y;

            // Pattern Matching Example
            static void HandleInput(object input)
            {
                switch (input)
                {
                    case int i when i > 0:
                        Console.WriteLine("Positive integer");
                        break;
                    case string s:
                        Console.WriteLine("String input");
                        break;
                    default:
                        Console.WriteLine("Unknown type");
                        break;
                }
            }
        }
    }
}
