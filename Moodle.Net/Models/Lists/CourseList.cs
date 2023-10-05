namespace Moodle.Net.Models.Lists;

public class CourseList
{
    public List<Course> Courses { get; set; }

    public List<Course> List()
    {
        return Courses;
    }
}