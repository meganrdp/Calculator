namespace Calculator;

class Program
{
    static void Main(string[] args)
    {
        
// request an opperator to use for the calculation
        Console.WriteLine("welcome to the Calculator");
        Console.WriteLine("Please enter the operator +, -, * or /");
        string? whichOperator = Console.ReadLine();
        Console.WriteLine("how many numbers do you want to use? ");
        double howMany = Convert.ToDouble(Console.ReadLine());

// asked for first number so that it can be stored and subsequent numbers added/taken et from that
        Console.WriteLine("What is your first number? ");
        double firstNum = Convert.ToDouble(Console.ReadLine());

// storing the first number in the variable to be worked on
        double yourAnswer = firstNum;

// using for loop to run if statements and stop when up to the users number       
        for (int i = 1; i < howMany; i++) {
            Console.Write("Please enter a number: ");
            double userNumber = Convert.ToDouble(Console.ReadLine());

// bit clunky... is there an easier way to do this?
            if(whichOperator == "+"){
                yourAnswer = yourAnswer + userNumber;
            }
            else if(whichOperator == "-"){
                yourAnswer = yourAnswer - userNumber;;
            }
            else if(whichOperator == "/"){
                yourAnswer = yourAnswer / userNumber;;
            }
            else if(whichOperator == "*"){
                yourAnswer = yourAnswer * userNumber;;
            }

        }
        Console.WriteLine("The answer is" + yourAnswer);
           
        Console.ReadLine();
       
    }
}
