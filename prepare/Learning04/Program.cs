using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("james", "Schkrunk");
        assignment.GetSummary();

        MathAssignment mathAssignment = new MathAssignment("12", "8-9", "Gimble", "Addition");
        mathAssignment.GetHomeworkList();

        WritingAssignment writingAssignment = new WritingAssignment("Hjjlipple and the Coplyites", "Kafterbald", "Creative Writing");
        writingAssignment.GetWritingInformation();
    }
}