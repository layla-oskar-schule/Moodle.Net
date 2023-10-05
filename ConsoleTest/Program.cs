using Moodle.Net.Extensions;

namespace ConsoleTest;

public class Program
{
    public static void Main(string[] args)
    {
        var client = new Moodle.Net.Client("https://moodle.oszimt.de/", "9903806f77bc22af4fd0ed36d23e2ca9",
            "webservice/rest/server.php");
        Console.WriteLine(client.GetCourses().Courses[16].FullName);
    }
}