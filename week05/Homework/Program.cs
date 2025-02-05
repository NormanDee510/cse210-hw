using System;

class Program
{
    static void Main()
    {
        // Test Assignment (Base Class)
        Assignment assignment = new Assignment("Tatenda Chari", "Multiplication");
        Console.WriteLine(assignment.GetSummary());
        Console.WriteLine();

        // Test MathAssignment
        MathAssignment mathAssignment = new MathAssignment("Charles Carlos", "Fractions", "5.2", "7-15");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());
        Console.WriteLine();

        // Test WritingAssignment
        WritingAssignment writingAssignment = new WritingAssignment("Mildred Dube", "European History", "The Causes of World War II");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}