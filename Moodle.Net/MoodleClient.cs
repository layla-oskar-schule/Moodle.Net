using RestSharp;

namespace Moodle.Net;

public class Client
{
    private readonly RestClient _restClient;
    private string _endpoint;

    public Client(string baseUrl, string token, string endpoint)
    {
        _restClient = new RestClient(baseUrl);
        _restClient.AddDefaultParameter("wstoken", token);
        _restClient.AddDefaultParameter("moodlewsrestformat", "json");
        _endpoint = endpoint;
    }

    public Client WithService(string service)
    {
        _restClient.AddDefaultParameter("wsfunction", service);
        return this;
    }

    public RestResponse Get<T>()
    {
        RestRequest request = new(_endpoint, Method.Get);
        return _restClient.Execute<T>(request);
    }

}
