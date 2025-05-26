using RestSharp;

class Location : Gupshup
{
    public static async Task Localizacao(string[] args)
    {
        request.AddParameter("message", @"{""type"":""location"",""latitude"":-22.68147,""longitude"":-43.2729,""name"":""Jardim Primavera"",""address"":""Jardim Primavera, Caxias""}");
        var response = await client.PostAsync(request);
        Console.WriteLine("{0}", response.Content);
    }
}