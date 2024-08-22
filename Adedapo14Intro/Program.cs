


using System.Net.Cache;

public class Program
{
   public static int Addiction( int num1 , int num2)
   {
        return num1 + num2;
        
   }
    public static int multiplication(int num1, int num2)
    {
        return num1 * num2;

    }

    public static void Main()
    {
       int answer1 = Addiction(500, 439);

      int answer2 =   Addiction(10, 6 );

        int answer3 = multiplication(10, 6);
        int answer4 = multiplication(500, 439);

        Console.WriteLine(answer1);
        Console.WriteLine(answer2);
        Console.WriteLine(answer3);
        Console.WriteLine(answer4);
    }
}  
