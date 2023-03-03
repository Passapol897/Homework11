using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        Console.Write("Input password : ");
        string passwordStr = Console.ReadLine();
        int[] P = Array.ConvertAll(passwordStr.ToCharArray(), c => (int)Char.GetNumericValue(c));

        Console.Write("Input Organization {CIA, FBI, NSA} : ");
        string organization = Console.ReadLine().ToUpper();

        bool TrueorFalse = false;

        if (P[5] % 3 == 0 && P[4] != 1 && P[4] != 3 && P[4] != 5 && P[2] >= 6 && P[2] != 8 && organization == "CIA")
        {
            TrueorFalse = true;

            if (TrueorFalse == true)
            {
                Console.Write(TrueorFalse);
            }                              
        }

        if (P[0] >= 4 && P[0] <= 7 && P[3] % 2 == 0 && P[3] != 6 && P[1] % 2 != 0 && organization == "FBI")
        {
            TrueorFalse = true;

            if (TrueorFalse == true)
            {
                Console.Write(TrueorFalse);
            }           
        }

        if (P[5] >= 1 && P[5] <= 6 && P[5] != 4 && P[3] % 3 == 0 && P[3] % 2 != 0 && P.Contains(7) && organization == "NSA")
        {
            TrueorFalse = true;

            if (TrueorFalse == true)
            {
                Console.Write(TrueorFalse);
            }            
        }

        if (TrueorFalse == false)
        {
            Console.Write("false");
        }
    }
}