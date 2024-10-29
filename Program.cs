// See https://aka.ms/new-console-template for more information
Console.WriteLine("***Exponents Lab***");
Console.WriteLine("***Learn your Squares and Cubes***");
do
{
repeat:
    Console.Write("Enter an Integer between 1 and 1290 inclusive \t");
    string str = Console.ReadLine();
    //validating the user input
    int userNumber = 0;
    bool isInteger = int.TryParse(str, out userNumber);
    if (!isInteger || userNumber <= 1 || userNumber >= 1290) 
    {
        Console.WriteLine("Invalid number");
        goto repeat;
    }
    int squareNum = 0;
    int cubeNum = 0;
    string printNum = "";
    Console.WriteLine("Number\t\t\tSquared\t\t\tCubed\t");
    Console.WriteLine("======\t\t\t=======\t\t\t=====\t");
    //iterate the loop till the number entered to fing square and cube
    for (int i = 1; i <= userNumber; i++)
    {
        squareNum = i * i;
        cubeNum = i * i * i;

        Console.WriteLine(i + "\t\t\t" + squareNum + "\t\t\t" + cubeNum);
        //printNum = printNum + " " + squareNum;
    }
    //Console.WriteLine(printNum);
    //program continues till the user like to continue
} while (GetPlayAgainAnswer() == true);

bool GetPlayAgainAnswer(string strMessage = "Do you like to play again? y/n")
{
    Console.WriteLine(strMessage);
    string userAnswer = Console.ReadLine();
    if (userAnswer.ToLower() != "y")
    {
        return false;
    }

    //Console.WriteLine("YEAH LETS PLAY");
    return true;
}

