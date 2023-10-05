using Moodle.Net.Models;
using Moodle.Net.Models.Lists;
using Newtonsoft.Json;

namespace Moodle.Net.Services;

public class CourseService
{
    private readonly Client _client;

    public CourseService(Client client)
    {
        _client = client;
    }

    public CourseList GetCourses()
    {
        var response = _client.WithService("mod_assign_get_assignments").Get<Course>();
        return JsonConvert.DeserializeObject<CourseList>(response.Content);
    }

}