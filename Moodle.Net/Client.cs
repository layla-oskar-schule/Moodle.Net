using RestSharp;

namespace Moodle.Net;

public class Client
{
    private readonly RestClient _restClient;

    public Client(string baseUrl)
    {
        _restClient = new RestClient(baseUrl);
    }

    public Client WithToken(string token)
    {
        _restClient.AddDefaultParameter("wstoken", token);
        return this;
    }

    public Client AsJson()
    {
        _restClient.AddDefaultParameter("moodlewsrestformat", "json");
        return this;
    }

    public Client WithService(string service)
    {
        _restClient.AddDefaultParameter("wsfunction", service);
        return this;
    }
}
