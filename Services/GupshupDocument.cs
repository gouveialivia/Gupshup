using RestSharp;

class Document : Gupshup
{
    public static async Task Documento(string[] args)
    {
        request.AddParameter("message", @"{""type"":""file"",""filename"":""Sample file"",""url"":""https://www.buildquickbots.com/whatsapp/media/sample/pdf/sample01.pdf""}");
        var response = await client.PostAsync(request);
        Console.WriteLine("{0}", response.Content);
    }
}