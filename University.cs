// University.cs
using System;

public class University {
    public static void Main() {
        Student student1 = new Student(1, "John Doe", new DateTime(1995, 5, 15));
        Student student2 = new Student(2, "Jane Smith", new DateTime(1998, 8, 25));

        Course mathCourse = new Course(101, "Mathematics");
        mathCourse.EnrollStudent(student1);
        mathCourse.EnrollStudent(student2);

        Course programmingCourse = new Course(102, "Programming");
        programmingCourse.EnrollStudent(student1);

        DisplayCourseInfo(mathCourse);
        DisplayCourseInfo(programmingCourse);
    }

    static void DisplayCourseInfo(Course course) {
        Console.WriteLine($"Course: {course.CourseName}");
        Console.WriteLine("Enrolled Students:");
        foreach (var student in course.EnrolledStudents) {
            Console.WriteLine($"- {student.Name} (ID: {student.StudentId})");
        }
        Console.WriteLine();
    }
}
