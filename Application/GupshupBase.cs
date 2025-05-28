using System;
using System.Threading.Tasks;
using RestSharp;

public class Gupshup
{
    public static RestClient client;
    public static RestRequest request;

    public static void GupshupBase()
    {
        var options = new RestClientOptions(Config.Url);
        client = new RestClient(options);
        request = new RestRequest();

        request.AddHeader("accept", "application/json");
        request.AddHeader("apikey", Config.Apikey);
        request.AddParameter("channel", "whatsapp");
        request.AddParameter("source", Config.Numero);
        request.AddParameter("destination", Config.Destino_Numero);
        request.AddParameter("src.name", Config.Nome);
    }
}
//Arrumar aqui!!!!!!!!!! (Codigo esta mei cagado)
// IDEIA: todas as variaveis repetitivas que sao usadas em todos os SendMessages estao resumidas aqui, pra diminuir o codigo e ficar mais clean