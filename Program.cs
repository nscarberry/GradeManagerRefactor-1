using System;

namespace RefactoringHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeManager gm = new GradeManager();
            gm.LogGradeProcessingMessage();

            double[] grades = { 90, 85, 78 };
            gm.processGrades("Neil", grades);

            double finalGrade = gm.calculateFinalGrade(84, 5);
            Console.WriteLine("Final Grade: " + finalGrade);
        }
    }
}
