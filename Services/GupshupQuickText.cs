using RestSharp;

class QuickText : Gupshup
{
    public static async Task TextoRapido(string[] args)
    {
        request.AddParameter("message", @"{""type"":""quick_reply"",""msgid"":""qr1"",""options"":[{""type"":""text"",""title"":""First""}],""content"":{""type"":""text"",""header"":""this is the header"",""text"":""this is the body"",""caption"":""this is the footer""}}");
        var response = await client.PostAsync(request);
        Console.WriteLine("{0}", response.Content);
    }
}