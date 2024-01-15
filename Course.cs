// Course.cs
using System;
using System.Collections.Generic;

public class Course {
    public int CourseId { get; set; }
    public string CourseName { get; set; }
    public List<Student> EnrolledStudents { get; } = new List<Student>();

    public Course(int courseId, string courseName) {
        CourseId = courseId;
        CourseName = courseName;
    }

    public void EnrollStudent(Student student) {
        EnrolledStudents.Add(student);
    }

    // Other methods
    // ...
}
