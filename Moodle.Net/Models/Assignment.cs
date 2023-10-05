namespace Moodle.Net.Models;

public class Assignment
{
    public int Id { get; set; }
    public int Course { get; set; }
    public string Name { get; set; }
    public long DueDate { get; set; }
}