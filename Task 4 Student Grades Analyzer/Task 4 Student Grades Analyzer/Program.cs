using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<int> Scores { get; set; }

    public static string GetLetterGrade(double average)
    {
        if (average >= 90) return "A";
        if (average >= 80) return "B";
        if (average >= 70) return "C";
        if (average >= 60) return "D";
        return "F";
    }
}

public static class Program
{
    static void Main(String[] args)
    {
        List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "Ali",    Scores = new List<int> { 85, 90, 78 } },
            new Student { Id = 2, Name = "Sara",   Scores = new List<int> { 92, 95, 89 } },
            new Student { Id = 3, Name = "Bilal",  Scores = new List<int> { 55, 60, 58 } },
            new Student { Id = 4, Name = "Ayesha", Scores = new List<int> { 70, 75, 72 } },
            new Student { Id = 5, Name = "Hamza",  Scores = new List<int> { 45, 50, 48 } },
            new Student { Id = 6, Name = "Fatima", Scores = new List<int> { 88, 91, 85 } },
            new Student { Id = 7, Name = "Usman",  Scores = new List<int> { 65, 68, 70 } }
        };



        Console.WriteLine("*************** Student Grade Analyzer ***************");
        bool running = true;
        while (running)
        {
            Console.WriteLine("All the Students with their Average Marks");
            Console.WriteLine("1. Press 1 to View all students with their average grade\n2. Press 2 to View each student's letter grade\n3. Press 3 to Find the top-performing student\n4. Press 4 to Find the lowest-performing student\n5. Press 5 to View Class average\n6. Press 6 to View Group students by letter grade\n7. Press 7 to Exit");
            int Choice;

            while (!int.TryParse(Console.ReadLine(), out Choice))
            {
                Console.WriteLine("Invalid Input, Please Try Again");
                Console.WriteLine("Enter the Value");
            }
            if (Choice == 1)
            {
                foreach (Student e in students)
                {
                    double studentAvg = e.Scores.Average();

                    Console.WriteLine($"Student Name: {e.Name} and their average score is :{studentAvg}");

                }
            }
            else if (Choice == 2)
            {
                Console.WriteLine("Students With Their Letter Grades");
                foreach (Student e in students)
                {
                    var FinalGrade = Student.GetLetterGrade(e.Scores.Average());

                    Console.WriteLine($"Name: {e.Name}, Average: {e.Scores.Average()}, Grade: {FinalGrade}");
                }

            }
            else if (Choice == 3)
            {
                var Top1 = students.OrderByDescending(e => e.Scores.Average()).FirstOrDefault();
                Console.WriteLine("******* Top Performer *******");
                Console.WriteLine($"Name: {Top1.Name} and Average: {Top1.Scores.Average()}");

            }
            else if (Choice == 4)
            {
                var Low1 = students.OrderBy(e => e.Scores.Average()).FirstOrDefault();
                Console.WriteLine("******* Lowe Performer *******");
                Console.WriteLine($"Name: {Low1.Name} and Average: {Low1.Scores.Average()}");

            }
            else if (Choice == 5)
            {
                double ClassAverage = students.Average(e => e.Scores.Average());

                Console.WriteLine($"Whole Class Average : {ClassAverage}");
            }
            else if (Choice == 6)
            {
                Console.WriteLine("Group students by letter grade");

                var GroupStudents = students.GroupBy(e => Student.GetLetterGrade(e.Scores.Average()));

                foreach (var e in GroupStudents)
                {
                    Console.WriteLine($"Grade {e.Key}");
                    foreach (var student in e)
                    {
                        Console.WriteLine($"Student Name {student.Name} and Average: {student.Scores.Average()}");
                    }
                }
            }
            else if (Choice == 7)
            {
                running = false;
                Console.WriteLine("Closing the Student Grades Analyzer");
            }
            else
            {
                Console.WriteLine("Invalid Value, PLease Enter the Value Between 1 and 7");
            }
        }
    }
}
