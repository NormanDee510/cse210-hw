using System;

class Program
{
    static void Main(string[] args)
    {
       Console.Write("Enter your grade percentage: ");
        string input = Console.ReadLine();
        
        if (int.TryParse(input, out int gradePercentage))
        {
            string letter = "";
           
            if (gradePercentage >= 90)
            {
                letter = "A";
            }
            else if (gradePercentage >= 80)
            {
                letter = "B";
            }
            else if (gradePercentage >= 70)
            {
                letter = "C";
            }
            else if (gradePercentage >= 60)
            {
                letter = "D";
            }
            else
            {
                letter = "F";
            }

            Console.WriteLine($"Your grade is: {letter}");
            
            if (gradePercentage >= 70)
            {
                Console.WriteLine("Congratulations! You passed the course.");
            }
            else
            {
                Console.WriteLine("Don't give up! Keep working hard for next time.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a numeric value for your grade percentage.");
        }
    }
}