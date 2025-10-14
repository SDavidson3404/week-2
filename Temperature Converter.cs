//Ask user input for converting FROM
Console.WriteLine("What would you like to convert FROM (F/C/K): ");

//Store input as variable
string convertFrom = Console.ReadLine();

//Ask user input for converting TO
Console.WriteLine("What would you like to convert TO (F/C/K): ");

//Store input as variable
string convertTo = Console.ReadLine();

//Ask user what temp they want to convert
Console.WriteLine("What temp would you like to convert?");

//Store input as variable
int temp = Convert.ToInt32(Console.ReadLine());

//If Converting from C
if (convertFrom == "C")
{
    //If Converting to F
    if (convertTo == "F")
    {
        //Do Conversion
        int converted = 9 / 5 * temp + 32;

        //Return Result
        Console.WriteLine("The temp is " + converted);
    }

    //If Converting to K
    else if (convertTo == "K")
    {
        //Do Conversion
        int converted = temp + 273;

        //Return Result
        Console.WriteLine("The temp is " + converted);
    }

    //If Converting to C
    else if (convertTo == "C")
    {
        //Return Temp
        Console.WriteLine("The temp is " + temp);
    }
}

//if Converting from F
else if (convertFrom == "F")
{
    //If Converting to C
    if (convertTo == "C")
    {
        //Do Conversion
        int converted = 5 / 9 * (temp - 32);

        //Return Temp
        Console.WriteLine("The temp is " + converted);
    }

    //If Converting to K
    else if (convertTo == "K")
    {
        //Do Conversion
        int converted = 5/9 * (temp - 32) + 273;

        //Return Temp
        Console.WriteLine("The temp is " + converted);
    }

    //If Converting to F
    else if (convertTo == "F")
    {
        //Return Temp
        Console.WriteLine("The temp is " + temp);
    }

}

//if Converting from K
else if (convertFrom == "K")
{
    //if Converting to C
    if (convertTo == "C")
    {
        //Do Conversion
        int converted = temp - 273;

        //return Result
        Console.WriteLine("The temp is " + converted);
    }

    //If Converting to F
    else if (convertTo == "F")
    {
        //Do conversion
        int converted = 9 / 5 * (temp - 273) + 32;

        //Return Result
        Console.WriteLine("The temp is " + converted);
    }

    //If Converting to K
    else if (convertTo == "K")
    {
        //Return Temp
        Console.WriteLine("The temp is " + temp);
    }
}

