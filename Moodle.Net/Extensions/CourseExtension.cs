using Moodle.Net.Models;
using Moodle.Net.Models.Lists;
using Moodle.Net.Services;

namespace Moodle.Net.Extensions;

public static class ClientExtension
{
    public static List<Course> GetCourses(this Client client)
    {
        var courseService = new CourseService(client);
        var response = courseService.GetCourses();
        return response.Courses;
    }
}