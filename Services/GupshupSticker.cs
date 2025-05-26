using RestSharp;

class Sticker : Gupshup
{
    public static async Task Adesivo(string[]args)
    {
        request.AddParameter("message", @"{""type"":""sticker"",""url"":""https://www.buildquickbots.com/whatsapp/stickers/SampleSticker01.webp""}");
        var response = await client.PostAsync(request);
        Console.WriteLine("{0}", response.Content);

    }
}