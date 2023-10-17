using Moodle.Net.Models;
using Moodle.Net.Services;

namespace Moodle.Net.Extensions;

public static class ClientExtension
{
    public static List<Course> GetCourses(this MoodleClient client)
    {
        var courseService = new CourseService(client);
        return courseService.GetCourses();
    }

    public static Course GetCourseByName(this MoodleClient client, string name)
    {
        var courseService = new CourseService(client);
        return courseService.GetCourseByName(name);
    }

    public static Course GetCourseById(this MoodleClient client, int id)
    {
        var courseService = new CourseService(client);
        return courseService.GetCourseById(id);
    }
}