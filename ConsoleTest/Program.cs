using Moodle.Net.Extensions;

namespace ConsoleTest;

public class Program
{
    public static void Main(string[] args)
    {
        var client = new Moodle.Net.MoodleClient("https://moodle.oszimt.de/", "",
            "webservice/rest/server.php");
        var course = client.GetCourseById(5027);
        foreach (var assignment in course.Assignments)
        {
            Console.WriteLine(assignment.Id);
        }
    }
}