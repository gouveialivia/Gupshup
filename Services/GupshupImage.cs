using RestSharp;

class Image : Gupshup
{
    public static async Task Imagem(string[] args)
    {
        request.AddParameter("message", @"{""type"":""image"",""originalUrl"":""https://www.buildquickbots.com/whatsapp/media/sample/jpg/sample01.jpg"",""previewUrl"":""https://www.buildquickbots.com/whatsapp/media/sample/jpg/sample01.jpg"",""caption"":""Sample image""}");
        var response = await client.PostAsync(request);
        Console.WriteLine("{0}", response.Content);

    }
}