using RestSharp;

class Video : Gupshup
{
    public static async Task Videos(string[] args)
    {
        request.AddParameter("message", "{\"type\":\"video\",\"caption\":\"Vídeo teste\",\"url\":\"https://www.buildquickbots.com/whatsapp/media/sample/video/sample01.mp4\"}");
        var response = await client.PostAsync(request);
        Console.WriteLine("{0}", response.Content);
    }
}
