using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;

namespace consumerQlola.Helper;

public class GraphQLHttpClientHandler
{
    // global variabel
    private string endpoint = "http://172.18.247.123:8003/graphql";

    // constructor
    public GraphQLHttpClientHandler()
    {

    }

    // create method generate client
    public GraphQLHttpClient GetGraphQlApiClient()
    {
        var handle = new HttpClientHandler();
        handle.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => true;

        HttpClient client = new HttpClient(handle);

        var httpClientOption = new GraphQLHttpClientOptions
        {
            EndPoint = new Uri(this.endpoint)
        };

        return new GraphQLHttpClient(httpClientOption, new NewtonsoftJsonSerializer(), client);
    }
}