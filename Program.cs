namespace Calculator;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("welcome to the Calculator");
        Console.WriteLine("Please enter your first number");
        double? firstNum = Double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter your second number");
        double? secondNum = Double.Parse(Console.ReadLine());
        Console.WriteLine("Your answer is: " + (firstNum * secondNum));

    }
}
