using Moodle.Net.Models;
using Moodle.Net.Models.Lists;
using Newtonsoft.Json;

namespace Moodle.Net.Services;

public class CourseService
{
    private readonly MoodleClient _client;

    public CourseService(MoodleClient client)
    {
        _client = client;
    }

    public List<Course> GetCourses()
    {
        var response = _client.WithService("mod_assign_get_assignments").Get<Course>();
        var courseList = JsonConvert.DeserializeObject<CourseList>(response.Content);
        return courseList.Courses;
    }

    public Course GetCourseByName(string courseName)
    {
        return GetCourses().Find(c => c.FullName == courseName || c.ShortName == courseName);
    }

    public Course GetCourseById(int id)
    {
        return GetCourses().Find(c => c.Id == id);
    }
}