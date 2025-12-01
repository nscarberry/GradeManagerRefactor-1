using System;

namespace RefactoringHomework
{
    // Extract Interface
    public interface IGradeManager
    {
        void processGrades(string studentName, double[] grades);
        double calculateFinalGrade(double average, double bonus);
    }

    public class GradeManager : IGradeManager
    {
        // Encapsulate Field
        private double passingGrade = 50.0;

        public double PassingGrade
        {
            get { return passingGrade; }
            set { passingGrade = value; }
        }

        // Rename doWork() → LogGradeProcessingMessage()
        public void LogGradeProcessingMessage()
        {
            Console.WriteLine("Working on grades...");
        }

        public void processGrades(string studentName, double[] grades)
        {
            Console.WriteLine("Processing grades for " + studentName);

            // Extract Method: CalculateTotal
            double total = CalculateTotal(grades);

            // Extract Method: CalculateAverage
            double average = CalculateAverage(total, grades.Length);

            Console.WriteLine("Average: " + average);

            if (average >= PassingGrade)
            {
                Console.WriteLine("Status: Pass");
            }
            else
            {
                Console.WriteLine("Status: Fail");
            }
        }

        // Extracted Method
        private double CalculateTotal(double[] grades)
        {
            double total = 0;

            for (int i = 0; i < grades.Length; i++)
            {
                total += grades[i];
            }
            return total;
        }

        // Extracted Method
        private double CalculateAverage(double total, int count)
        {
            return total / count;
        }

        // Change Signature: (average, bonus)
        public double calculateFinalGrade(double average, double bonus)
        {
            return average + bonus;
        }
    }
}
