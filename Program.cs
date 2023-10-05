namespace Calculator;

class Program
{
    static void Main(string[] args)
    {
        
//request an opperator to use for the calculation
        Console.WriteLine("welcome to the Calculator");
        Console.WriteLine("Please enter the operator +, -, * or /");
        string? whichOperator = Console.ReadLine();
        Console.WriteLine("how many numbers do you want to use? ");
        double howMany = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("What is your first number? ");
        double firstNum = Convert.ToDouble(Console.ReadLine());

        double yourAnswer = firstNum;
        
        for (int i = 1; i < howMany; i++) {
            Console.Write("Please enter a number: ");
            double userNumber = Convert.ToDouble(Console.ReadLine());

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
        




        /*if(whichOperator == "+"){
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
        }*/


        Console.ReadLine();

        //Console.WriteLine("Your answer is: " + (firstNum * secondNum));

    }
}
