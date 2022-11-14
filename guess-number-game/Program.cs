// See https://aka.ms/new-console-template for more information
Console.WriteLine("Let's play Guess the Number");
Console.WriteLine("I'm thinking of a number between 0 and 20. Can you guess it?");
Console.WriteLine("Enter your guess or enter -1 to give up: ");

int number =8 ;
int guess = 0;
int count = 0;

guess=int.Parse(Console.ReadLine());
while(guess!=-1 && guess!=number)
{
    if(guess>number)
    {
        Console.WriteLine("Too high, try again");
    }
    else
    {
        Console.WriteLine("Too low, try again");
    }
    guess=int.Parse(Console.ReadLine());
    count++;
}
Console.WriteLine("Awesome! You guessed the number in {0} tries", count);

