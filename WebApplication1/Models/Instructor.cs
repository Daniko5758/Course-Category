using System;

namespace WebApplication1.Models;

public class Instructor
{
    public int InstructorId { get; set; }
    public string InstructorName { get; set;} = null!;
    public string InstructorEmail { get; set; } = null!;
    public string InstructorPhoneNumber { get; set; } = null!;
    public string InstructorAddress { get; set; } = null!;
    public string InstructorCity { get; set; } = null!;
}
