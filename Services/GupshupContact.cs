using RestSharp;

class Contact
{
    public static async Task Contato(string[] args)
    {
        var options = new RestClientOptions("https://api.gupshup.io/wa/api/v1/msg");
        var client = new RestClient(options);
        var request = new RestRequest("");
        request.AddHeader("accept", "application/json");
        request.AddHeader("apikey", "ryornu2uprwvmgdqmbqu9juwosefam5e");
        request.AddParameter("message", @"{""type"": ""contact"",""contact"":{""addresses"":[{""city"":""Rio de Janeiro"",""country"": ""Brasil"",""countryCode"":""br"",""state"":""RJ"",""street"":""Alamedo James Franco 178"",""type"":""Trabalho"",""zip"":""25125265""}],""birthday"":""2005-02-02"",""emails"":[{""email"":""gouveialivia731@gmail.com"",""type"":""Personal""}],""name"":{""firstName"":""Livia"",""formattedName"":""Livia Gouveia"",""lastName"":""Vieira""},""org"":{""company"":""RedeBr"",""department"":""Desenvolvimento"",""title"":""Desenvolvedor""},""phones"":[{""phone"":""+5521971635318"",""type"":""Personal""}],""urls"":[{""url"":""https://redebrtelecom.com.br/"",""type"":""WORK""}]}}");
        request.AddParameter("channel", "whatsapp");
        request.AddParameter("source", "558000003109");
        request.AddParameter("destination", "21971635318");
        request.AddParameter("src.name", "MacroPromotora");
        var response = await client.PostAsync(request);

        Console.WriteLine("{0}", response.Content);
    }
}