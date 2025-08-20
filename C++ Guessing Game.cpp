
#include <iostream>

int main()

{	// Generate a random number between 1 and 100
	int secretNumber = rand() % 100 + 1;
	// This program asks the user to guess a number and tells them if they are too high, too low, or correct.

	while (true)
	{
		std::cout << "Please guess a number: ";
		int numberGuess;
		std::cin >> numberGuess;
		if (numberGuess < secretNumber)
		{
			std::cout << "Too low!\n";
		}
		else if (numberGuess > secretNumber)
		{
			std::cout << "Too high!\n";
		}
		else
		{
			std::cout << "You guessed it!\n";
			break; // Exit the loop if the guess is correct
		}
	}
}