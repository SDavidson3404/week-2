using System;

//Ask user for first number
Console.WriteLine("Enter first number: ");

//store first number as a variable
int firstNumberInput = Convert.ToInt32(Console.ReadLine());

//ask user for second number
Console.WriteLine("Enter second number: ");

//store second number as a variable
int secondNumberInput = Convert.ToInt32(Console.ReadLine());

//ask user for operation
Console.WriteLine("Enter operation (+, -, *, /): ");

//store operation as a variable
string operation = Console.ReadLine();

//if operation is addition
if (operation == "+")
{
    //perform addition
    int answer = firstNumberInput + secondNumberInput;

    //print result
    Console.WriteLine("The answer is: " + answer);
}

//if operation is subtraction
else if (operation == "-")
{
    //perform subtraction
    int answer = firstNumberInput - secondNumberInput;

    //print result
    Console.WriteLine("The answer is: " + answer);
}

//if operation is multiplication
else if (operation == "*")
{
    //perform multiplication
    int answer = firstNumberInput * secondNumberInput;
 
    //print result
    Console.WriteLine("The answer is: " + answer);
}

//if operation is division
else if (operation == "/")
{
    //perform division
    if (secondNumberInput != 0)
    {
        int answer = firstNumberInput / secondNumberInput;
        //print result
        Console.WriteLine("The answer is: " + answer);
    }
    else
    {
        Console.WriteLine("Error: Division by zero is not allowed.");
    }
}
else
{
    Console.WriteLine("Invalid operation.");
}

