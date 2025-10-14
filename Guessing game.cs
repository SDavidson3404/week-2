using System;
using System.ComponentModel.Design;
Random random = new Random();

//create guess and playing variables

int guessCount = 0;
bool playing = false;
bool correct = false;

//create random answer for guess and store as variable


int answer = random.Next(1, 101);

//ask if user wants to play

Console.WriteLine("Want to play my game? (Y/N):");
string play = Console.ReadLine();

//if yes set playing to true
if (play == "Y")
{
    playing = true ;
}

//if yes begin loop
while (playing == true)
{
    //ask for user input
    guessCount++;
    Console.WriteLine("Please enter a number as a guess:");
    //get user input
    int guess = Convert.ToInt32(Console.ReadLine());
    //compare input with answer
    if (guess == answer)
    {
        //if correct break
        playing = false;
        correct = true;
    }
    //if wrong ask if wants to play again
    else if (guess != answer)
    {
        Console.WriteLine("Incorrect");
        if (guess > answer)
        {
            Console.WriteLine("Too high");
        }
        else if (guess < answer)
        {
            Console.WriteLine("Too low");
        }
    }
    //if no, break
}
if (playing == false)
{

    //if no check if got answer correct
    if (correct)
    {
        //if correct, congratulate
        Console.WriteLine("Congrats!  You got it! It took " + guessCount + " attempts");
    }
    else if (!correct)
    {
        //if not, close game
        Console.WriteLine("Welp, you tried, or you didn't, I don't know.");
    }

}

