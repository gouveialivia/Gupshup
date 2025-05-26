using System;
using System.Threading.Tasks;
using RestSharp;
using System.Text.Json;

class Text : Gupshup
{
    public static async Task Texto(string[] args)
    {
        request.AddParameter("message", "{\"type\":\"text\",\"text\":\"Oi tudo bem\"}");
        var response = await client.PostAsync(request);
        Console.WriteLine(response.Content);
    }
}
