using RestSharp;

class List
{
    public static async Task Lista(string[] args)
    {
        var options = new RestClientOptions("https://api.gupshup.io/wa/api/v1/msg");
        var client = new RestClient(options);
        var request = new RestRequest("");
        request.AddHeader("accept", "application/json");
        request.AddHeader("apikey", "ryornu2uprwvmgdqmbqu9juwosefam5e");
        request.AddParameter("message", @"{""type"":""list"",""title"":""litle text"",""body"":""body text"",""msgid"":""list1"",""globalButtons"":[{""type"":""text"",""title"":""Global button""}],""items"":[{""title"":""first Section"",""subtitle"":""first Subtitle"",""options"":[{""type"":""text"",""title"":""section 1 row 1"",""description"":""first row of first section description"",""postbackText"":""section 1 row 1 postback payload""}]}]}");
        request.AddParameter("channel", "whatsapp");
        request.AddParameter("source", "558000003109");
        request.AddParameter("destination", "21971635318");
        request.AddParameter("src.name", "MacroPromotora");
        var response = await client.PostAsync(request);

        Console.WriteLine("{0}", response.Content);
    }
}