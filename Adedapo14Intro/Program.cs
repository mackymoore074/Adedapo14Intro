


using System;
using System.ComponentModel.Design;
using System.Net.Cache;
using System.Runtime.CompilerServices;

public class Program
{
    /*
    static void Main(string[] args)
    {
        /*int x = 10;
        int x = 0;

        if(x> 5)
        {
            Console.WriteLine("x is greater than 5");
        }
        else if(x < 5)
        {
            Console.WriteLine("x is less than 5");
        }
        else
        {
           Console.WriteLine("x is equal to 5");
        }

        string name = "Adedapo";
        switch(name.ToLower())
        {
            case "Adedapo":
                Console.WriteLine("Hello Adedapo");
                break;
            case "John":
                Console.WriteLine("Hello John");
                break;
            default:
                Console.WriteLine("Hello Stranger");
                break;
        }

        int A = 10;
        int B = 20;

        if (A == B || B==A)
        {
            Console.WriteLine(1);
        }
        else if (B >= + 11)
        {
            Console.WriteLine(2);
        }
        else if (A != B)
        {
            Console.WriteLine(3);
        }
        else 
        {
            Console.WriteLine(4);
        }
    }
    

        string userName = "Adedapo";
        string dayOfTheWeek = "Monday";

        switch (dayOfTheWeek.ToLower())
        {
            case "monday":
                Console.WriteLine("Hello " + userName + " Happy Monday");
                break;
            case "tuesday":
                Console.WriteLine("Hello " + userName + " Happy Tuesday");
                break;
            case "wednesday":
                Console.WriteLine("Hello " + userName + " Happy Wednesday");
                break;
            case "thursday":
                Console.WriteLine("Hello " + userName + " Happy Thursday");
                break;
            case "friday":
                Console.WriteLine("Hello " + userName + " Happy Friday");
                break;
            case "saturday":
                Console.WriteLine("Hello " + userName + " Happy Saturday");
                break;
            case "sunday":
                Console.WriteLine("Hello " + userName + " Happy Sunday");
                break;
            default:
                Console.WriteLine("Hello " + userName + " Happy Day");
                break;
        }
    }
}




Console.WriteLine("what is your favorite subject?");

string subject = Console.ReadLine();

switch (subject)
{
    case "Math":
        Console.WriteLine("Math is a great subject");
        break;
    case "Science":
        Console.WriteLine("Science is a nice subject");
        break;
    case "History":
        Console.WriteLine("History is a great subject to historical Heritage");
        break;
    case "English":
        Console.WriteLine("English is a great subject to improve vocabulary");
        break;
    case "Art":
        Console.WriteLine("Art is a great subject to show talent");
        break;
    default:
        Console.WriteLine("Interesting choice! What do you like about it?");
        break; ;
}
*/
        /*
        double mileRanToday = 0;
        bool isParsable;
        //Loop until the user enters a valid number
        do
        {
            Console.WriteLine("How many miles did you run today?");
            var input = Console.ReadLine();
            // Convert that input to a double
            isParsable = double.TryParse(input, out mileRanToday);

        } while (!isParsable==false);

        Console.WriteLine($"You ran  {mileRanToday} miles today");
        */
        /*
        //while loop

        var i = 0;
        while (i < 10)
        {
            Console.WriteLine(i);
            i++;
        }
        */
        /*
        // The For loop
        var students = new string[5] { "Adedapo", "John", "Jane", "Doe", "Smith" };
        for (int i = 0; i < students.Length; i++)
            if (i % 1 == 0)
            {
                Console.WriteLine($"Email: {students[i]}@truecoders.io");
            }
        */
        // A for loop contain 5 parts
        // 1. The keyword for
        // 2. The Initialization
        // 3. The Condition
        // 4. The Incrementor
        // 5. The Body
        /*
        // foreach loop
        var candyBag = new string[5] { "Snickers", "Mars", "Twix", "Milky Way", "Kit Kat" };
        foreach (var candyName in candyBag)
        {
          Console.WriteLine(candyName);
        }

        // The foreach loop is used to iterate over a collection of items
        // It is used when you want to do something with each item in a collection
        // It is used when you don't need to know the index of the item in the collection
        // It is used when you don't need to know how many items are in the collection
         */

    public static string whoareyou(string name, string lastName)
    {
        return $"Hello {name}, {lastName}!";

    }

    public static string whoareyou(string name, string lastName, string occupation, int age)
    {
        return $"Hello {occupation} {name} {lastName} {age}!";
    }


    public static int Add(int a, int b)
    {
        return a + b;
    }
    //Now create an overload of the Add method to account for being able to add two decimals together
    public static decimal Add(decimal a, decimal b)
    {
        return a + b;
    }
    //Now create another overload of the Add method that returns a string and accepts 3 parameters: 2 integers and 1 boolean
    //If the boolean parameter is equal to true, the Add method will return the sum of the 2 numbers plus the word “dollars” at the end of the string.

    //You must also account for the appropriate grammar of the string - so it can’t be “1 dollars”



    public static string Add(int a, int b, bool isTrue)
    {
        var sum = a + b;
        if (isTrue)
        {
            return $"{sum} dollars";
        }
        else
        {
            return $"{sum}";
        }

    }
    
    public static int Add(int a, int b, int c)
    {
        return a + b + c;
    }

    public static int Add(int a, int b, int c, int d)
    {
        return a + b + c + d;
    }

    public static string DoSomething (bool isTrue, int number)
    {
        if (isTrue)
        {
            return $"The number is {number}";
        }
        else
        {
            return "The number is not true";
        }
    }

    static void Main(string[] args)
    {
        var sum = Add(1, 2);
        Console.WriteLine(sum);

        var sum2 = Add(1, 2, 3);
        Console.WriteLine(sum2);

        var sum3 = Add(1, 2, 3, 4);
        Console.WriteLine(sum3);

        var greeting = whoareyou("Adedapo", "Aluko");
        Console.WriteLine(greeting);

        var greeting2 = whoareyou("Adedapo", "Aluko", "Software Developer", 18);
        Console.WriteLine(greeting2);

    }

 } 

