


using System.Net.Cache;

public class Program
{
  

    public static void Main()
    {
       int favNumber = 200;

        string input = Console.ReadLine();

        int userGuess = int.Parse(Console.ReadLine());

        if (userGuess == favNumber)
        {
            Console.WriteLine("You guessed right!");
        }
         if(userGuess > favNumber)
        {
            Console.WriteLine("You guessed too high!");
        }
        else if(userGuess < favNumber)
        {
            Console.WriteLine("You guessed too low!");
        }
        else if(userGuess != favNumber)
        {
            Console.WriteLine("You guessed wrong!");
        }
    }
}  
