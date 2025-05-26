using RestSharp;

class Contact : Gupshup
{
    public static async Task Contato(string[] args)
    {
        request.AddParameter("message", @"{""type"": ""contact"",""contact"":{""addresses"":[{""city"":""Rio de Janeiro"",""country"": ""Brasil"",""countryCode"":""br"",""state"":""RJ"",""street"":""Alamedo James Franco 178"",""type"":""Trabalho"",""zip"":""25125265""}],""birthday"":""2005-02-02"",""emails"":[{""email"":""gouveialivia731@gmail.com"",""type"":""Personal""}],""name"":{""firstName"":""Livia"",""formattedName"":""Livia Gouveia"",""lastName"":""Vieira""},""org"":{""company"":""RedeBr"",""department"":""Desenvolvimento"",""title"":""Desenvolvedor""},""phones"":[{""phone"":""+5521971635318"",""type"":""Personal""}],""urls"":[{""url"":""https://redebrtelecom.com.br/"",""type"":""WORK""}]}}");
        var response = await client.PostAsync(request);
        Console.WriteLine("{0}", response.Content);
    }
}