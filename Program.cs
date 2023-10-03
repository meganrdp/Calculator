namespace Calculator;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("welcome to the Calculator");
        Console.WriteLine("Please enter the operator +, -, * or /");
        string? whichOperator = Console.ReadLine();
        Console.WriteLine("Please enter your first number");
        double? firstNum = Double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter your second number");
        double? secondNum = Double.Parse(Console.ReadLine());

        if(whichOperator == "+"){
            Console.WriteLine("Your answer is:" + (firstNum + secondNum));
        }
        else if(whichOperator == "-"){
            Console.WriteLine("Your answer is:" + (firstNum - secondNum));
        }
        else if(whichOperator == "/"){
            Console.WriteLine("Your answer is:" + (firstNum / secondNum));
        }
        else if(whichOperator == "*"){
            Console.WriteLine("Your answer is:" + (firstNum * secondNum));
        }
        else{
            Console.WriteLine("Sorry I don't know that operator!");
        }
        Console.ReadLine();

        //Console.WriteLine("Your answer is: " + (firstNum * secondNum));

    }
}
