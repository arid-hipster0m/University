// Student.cs
using System;

public class Student {
    public int StudentId { get; set; }
    public string Name { get; set; }
    public DateTime DateOfBirth { get; set; }

    public Student(int studentId, string name, DateTime dateOfBirth) {
        StudentId = studentId;
        Name = name;
        DateOfBirth = dateOfBirth;
    }

    // Other methods
    // ...
}
