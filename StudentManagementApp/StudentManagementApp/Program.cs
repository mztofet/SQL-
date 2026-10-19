using Microsoft.EntityFrameworkCore;
using StudentManagementApp;
using StudentManagementApp.Models;

using var context = new StudentManagementContext();

using var transaction = context.Database.BeginTransaction();

try
{
    var student = new Student
    {
        FirstName = "Test",
        LastName = "Student",
        Alias = "ShadowFox",
        DoB = new DateTime(2005, 1, 1)
    };

    context.Students.Add(student);
    context.SaveChanges();

    var studentPower = new StudentPower
    {
        StudentID = student.StudentID,
        PowerID = 1,
        Rating = 80
    };

    context.StudentPowers.Add(studentPower);
    context.SaveChanges();

    var studentSection = new StudentSection
    {
        StudentID = student.StudentID,
        SectionID = 1,
        Grade = 0,
        Absences = 0
    };

    context.StudentSections.Add(studentSection);
    context.SaveChanges();

    transaction.Commit();

    Console.WriteLine("Transaction completed successfully.");
}
catch (Exception ex)
{
    transaction.Rollback();

    Console.WriteLine($"Transaction failed: {ex.Message}");
}