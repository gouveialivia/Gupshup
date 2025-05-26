using RestSharp;

class QuickFile
{
    public static async Task ArquivoRapido(string[] args)
    {
        var options = new RestClientOptions("https://api.gupshup.io/wa/api/v1/msg");
        var client = new RestClient(options);
        var request = new RestRequest("");
        request.AddHeader("accept", "application/json");
        request.AddHeader("apikey", "ryornu2uprwvmgdqmbqu9juwosefam5e");
        request.AddParameter("message", @"{""type"":""quick_reply"",""msgid"":""qr1"",""options"":[{""type"":""text"",""title"":""First""}],""content"":{""type"":""file"",""url"":""https://www.buildquickbots.com/whatsapp/media/sample/pdf/sample01.pdf"",""text"":""this is the body"",""filename"":""Sample file"",""caption"":""this is the footer""}}");
        request.AddParameter("channel", "whatsapp");
        request.AddParameter("source", "558000003109");
        request.AddParameter("destination", "21971635318");
        request.AddParameter("src.name", "MacroPromotora");
        var response = await client.PostAsync(request);

        Console.WriteLine("{0}", response.Content);
    }
}
