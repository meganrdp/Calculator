namespace Calculator;

internal class Program
{
    static void Fizzbuzz()
    {
        Console.WriteLine("Welcome to The Calculator!");
    }

    static void CompleteOneCalculation()
    {
        Console.WriteLine("Please enter the operator +, -, * or /");
        string? whichOperator = Console.ReadLine();
        Console.WriteLine("how many numbers do you want to use? ");
        double howMany = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("What is your first number? ");
        double firstNum = Convert.ToDouble(Console.ReadLine());

        double yourAnswer = firstNum;

        for (int i = 1; i < howMany; i++)
        {
            Console.Write("Please enter a number: ");
            double userNumber = Convert.ToDouble(Console.ReadLine());

            if (whichOperator == "+")
            {
                yourAnswer = yourAnswer + userNumber;
            }
            else if (whichOperator == "-")
            {
                yourAnswer = yourAnswer - userNumber;
            }
            else if (whichOperator == "/")
            {
                yourAnswer = yourAnswer / userNumber;
            }
            else if (whichOperator == "*")
            {
                yourAnswer = yourAnswer * userNumber;
            }
        }

        Console.WriteLine("The answer is " + yourAnswer);
        Console.ReadLine();

    }
    
    static void Main(string[] args)
    {
        Fizzbuzz();
        CompleteOneCalculation();
    }
}
