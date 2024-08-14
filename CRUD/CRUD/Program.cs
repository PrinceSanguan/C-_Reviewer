using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    // Define the Student class
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    // In-memory list to store students
    static List<Student> students = new List<Student>();
    static int nextId = 1; // For auto-incrementing IDs

    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Create Student");
            Console.WriteLine("2. Read Students");
            Console.WriteLine("3. Update Student");
            Console.WriteLine("4. Delete Student");
            Console.WriteLine("5. Exit");

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateStudent();
                    break;
                case "2":
                    ReadStudents();
                    break;
                case "3":
                    UpdateStudent();
                    break;
                case "4":
                    DeleteStudent();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    // Create a new student
    static void CreateStudent()
    {
        Console.Write("Enter student name: ");
        string name = Console.ReadLine();

        var student = new Student
        {
            Id = nextId++,
            Name = name
        };

        students.Add(student);
        Console.WriteLine("Student added successfully.");
    }

    // Read (list) all students
    static void ReadStudents()
    {
        if (students.Count == 0)
        {
            Console.WriteLine("No students available.");
            return;
        }

        foreach (var student in students)
        {
            Console.WriteLine($"ID: {student.Id}, Name: {student.Name}");
        }
    }

    // Update an existing student
    static void UpdateStudent()
    {
        Console.Write("Enter student ID to update: ");
        if (int.TryParse(Console.ReadLine(), out int id))
        {
            var student = students.FirstOrDefault(s => s.Id == id);
            if (student != null)
            {
                Console.Write("Enter new name: ");
                student.Name = Console.ReadLine();
                Console.WriteLine("Student updated successfully.");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }
        else
        {
            Console.WriteLine("Invalid ID.");
        }
    }

    // Delete a student
    static void DeleteStudent()
    {
        Console.Write("Enter student ID to delete: ");
        if (int.TryParse(Console.ReadLine(), out int id))
        {
            var student = students.FirstOrDefault(s => s.Id == id);
            if (student != null)
            {
                students.Remove(student);
                Console.WriteLine("Student deleted successfully.");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }
        else
        {
            Console.WriteLine("Invalid ID.");
        }
    }
}
