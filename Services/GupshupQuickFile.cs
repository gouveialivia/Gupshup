using RestSharp;

class QuickFile : Gupshup
{
    public static async Task ArquivoRapido(string[] args)
    {
        request.AddParameter("message", @"{""type"":""quick_reply"",""msgid"":""qr1"",""options"":[{""type"":""text"",""title"":""First""}],""content"":{""type"":""file"",""url"":""https://www.buildquickbots.com/whatsapp/media/sample/pdf/sample01.pdf"",""text"":""this is the body"",""filename"":""Sample file"",""caption"":""this is the footer""}}");
        var response = await client.PostAsync(request);
        Console.WriteLine("{0}", response.Content);
    }
}
