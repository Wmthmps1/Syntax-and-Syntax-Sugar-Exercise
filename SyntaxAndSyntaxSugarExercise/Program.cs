﻿namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int answer = 4;

            var response = (answer < 9) ? $"{answer} is less than nine" : $"{answer} is greater than or equal to nine";
            Console.WriteLine(response);

            
        }
    }
}
/*


 Given the following code, change the code to implement:
inferred typing
string interpolation
and the ternary operator
 
 */