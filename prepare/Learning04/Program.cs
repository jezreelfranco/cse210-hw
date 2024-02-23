using System;
class Program
{ 
    static void Main(string[] args)
    { // 
        Assignment assignement1 = new Assignment();
        assignement1.SetSummary("Samuel Bennett", "Multiplication");
        Console.WriteLine(assignement1.GetSummary());

        MathAssignment mathAssignment = new MathAssignment();
        mathAssignment.SetSummary("Robeto Rodrigues", "Fractions");
        Console.WriteLine(mathAssignment.GetSummary());
        mathAssignment.SetHomeworkList("Section 7.3", "Problems 8-19");
        Console.WriteLine(mathAssignment.GetHomeworkList());

        WritingAssignment writingAssignment = new WritingAssignment();
        writingAssignment.SetSummary("Mary Waters", "European History");
        Console.WriteLine(writingAssignment.GetSummary());
        writingAssignment.SetGetWritingInfo("The Causes of World War II", "Mary Waters");
        Console.WriteLine(writingAssignment.GetWritingInfo());
    }
}