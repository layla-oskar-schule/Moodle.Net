using Moodle.Net.Models.Lists;
using Moodle.Net.Services;

namespace Moodle.Net.Extensions;

public static class ClientExtension
{
    public static CourseList GetCourses(this Client client)
    {
        var courseService = new CourseService(client);
        return courseService.GetCourses();
    }
}