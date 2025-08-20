Console.WriteLine("Please input your age");
    var age = Console.ReadLine();
if (int.TryParse(age, out int parsedAge))
    {
    if (parsedAge < 0)
    {
        Console.WriteLine("Age cannot be negative.");
    }
    else if (parsedAge <= 3)
    {
        Console.WriteLine("You are a toddler.");
    }
    else if (parsedAge <= 12)
    {
        Console.WriteLine("You are a child.");
    }
    else if (parsedAge <= 19)
    {
        Console.WriteLine("You are a teenager.");
    }
    else if (parsedAge <= 59)
    {
        Console.WriteLine("You are an adult.");
    }
    else
    {
        Console.WriteLine("You are a senior citizen.");
    }
}
else
{
    Console.WriteLine("Invalid input. Please enter a valid age.");
}