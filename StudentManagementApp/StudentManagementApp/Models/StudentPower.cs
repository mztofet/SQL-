using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentManagementApp.Models;

[PrimaryKey(nameof(StudentID), nameof(PowerID))]
[Table("StudentPower")]
public class StudentPower
{
    public int StudentID { get; set; }

    public int PowerID { get; set; }

    public byte Rating { get; set; }

    [ForeignKey(nameof(StudentID))]
    public Student Student { get; set; } = null!;

    [ForeignKey(nameof(PowerID))]
    public Power Power { get; set; } = null!;
}