
Console.WriteLine("Please enter your age: ");
    var age = Console.ReadLine();
if (int.TryParse(age, out int ageNumber))
    {
    if (ageNumber < 0)
    {
        Console.WriteLine("Age cannot be negative.");
    }
    else if (ageNumber <= 3)
    {
        Console.WriteLine("You are a toddler.");
    }
    else if (ageNumber >= 4 && ageNumber <= 12)
    {
        Console.WriteLine("You are a child.");
    }
    else if (ageNumber >= 20 && ageNumber <= 59)
    {
        Console.WriteLine($"You are an adult.");
    else
        {
            Console.WriteLine("You are a Senior.");
        }
    }
else
    {
        Console.WriteLine("Invalid input. Please enter a valid year.");
    }