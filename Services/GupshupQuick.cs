using RestSharp;

class Quick : Gupshup
{
    public static async Task Rapido(string[] args)
    {
        request.AddParameter("message", @"{""type"":""quick_reply"",""msgid"":""qr1"",""options"":[{""type"":""text"",""title"":""First""}],""content"":{""type"":""image"",""url"":""https://www.buildquickbots.com/whatsapp/media/sample/jpg/sample01.jpg"",""text"":""this is the body"",""caption"":""this is the footer""}}");
        var response = await client.PostAsync(request);
        Console.WriteLine("{0}", response.Content);
    }
}
