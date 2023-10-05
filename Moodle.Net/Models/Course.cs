namespace Moodle.Net.Models;

public class Course
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public string ShortName { get; set; }
    public long TimeModified { get; set; }
    public List<Assignment> Assignments { get; set; }
}