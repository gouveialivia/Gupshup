using RestSharp;

class Document
{
    public static async Task Documento(string[] args)
    {
        var options = new RestClientOptions("https://api.gupshup.io/wa/api/v1/msg");
        var client = new RestClient(options);
        var request = new RestRequest("");
        request.AddHeader("accept", "application/json");
        request.AddHeader("apikey", "ryornu2uprwvmgdqmbqu9juwosefam5e");
        request.AddParameter("message", @"{""type"":""file"",""filename"":""Sample file"",""url"":""https://www.buildquickbots.com/whatsapp/media/sample/pdf/sample01.pdf""}");
        request.AddParameter("channel", "whatsapp");
        request.AddParameter("source", "558000003109");
        request.AddParameter("destination", "5521971635318");
        request.AddParameter("src.name", "MacroPromotora");
        var response = await client.PostAsync(request);

        Console.WriteLine("{0}", response.Content);
    }
}