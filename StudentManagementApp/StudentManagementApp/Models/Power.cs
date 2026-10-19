using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentManagementApp.Models;

[Table("Power")]
public class Power
{
    [Key]
    public int PowerID { get; set; }

    public int? PowerTypeID { get; set; }

    public string PowerName { get; set; } = string.Empty;

    public string PowerDescription { get; set; } = string.Empty;

    public ICollection<StudentPower> StudentPowers { get; set; }
        = new List<StudentPower>();
}