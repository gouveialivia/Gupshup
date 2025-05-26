using RestSharp;

class List : Gupshup
{
    public static async Task Lista(string[] args)
    {
        request.AddParameter("message", @"{""type"":""list"",""title"":""litle text"",""body"":""body text"",""msgid"":""list1"",""globalButtons"":[{""type"":""text"",""title"":""Global button""}],""items"":[{""title"":""first Section"",""subtitle"":""first Subtitle"",""options"":[{""type"":""text"",""title"":""section 1 row 1"",""description"":""first row of first section description"",""postbackText"":""section 1 row 1 postback payload""}]}]}");
        var response = await client.PostAsync(request);
        Console.WriteLine("{0}", response.Content);
    }
}