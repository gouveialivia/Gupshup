using RestSharp;

class Image
{
    public static async Task Imagem(string[] args)
    {
        var options = new RestClientOptions("https://api.gupshup.io/wa/api/v1/msg");
        var client = new RestClient(options);
        var request = new RestRequest("");
        request.AddHeader("accept", "application/json");
        request.AddHeader("apikey", "ryornu2uprwvmgdqmbqu9juwosefam5e");
        request.AddParameter("message", @"{""type"":""image"",""originalUrl"":""https://www.buildquickbots.com/whatsapp/media/sample/jpg/sample01.jpg"",""previewUrl"":""https://www.buildquickbots.com/whatsapp/media/sample/jpg/sample01.jpg"",""caption"":""Sample image""}");
        request.AddParameter("channel", "whatsapp");
        request.AddParameter("source", "558000003109");
        request.AddParameter("destination", "5521971635318");
        request.AddParameter("src.name", "MacroPromotora");
        var response = await client.PostAsync(request);

        Console.WriteLine("{0}", response.Content);

    }
}