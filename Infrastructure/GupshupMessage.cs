using System;
using System.Threading.Tasks;
using RestSharp;
using System.Text.Json;
using System.Net;
// Ideia: jogar todos os SendMessages aqui e deixar de uma forma que no futuro nao precise mexer (igual o Configuracoes.VideoUrl)
// Mudar: Text, Type, caption, Urls, PreviewsUrl e tudo mais
class Message : Gupshup
{
    public static async Task Texto()
    {
        var message = "{\"type\":\"text\",\"text\":\"Oi tudo bem\"}";
        request.AddParameter("message", message);

        var response = await client.PostAsync(request);
        Console.WriteLine(response.Content);
    }
    public static async Task Video()
    {
        var message = $"{{\"type\":\"video\",\"caption\":\"Vídeo teste\",\"url\":\"{Configuracoes.VideoUrl}\"}}";
        request.AddParameter("message", message);

        var response = await client.PostAsync(request);
        Console.WriteLine("{0}", response.Content);
    }
    public static async Task Imagem()
    {
        var message = $"{{\"type\":\"image\",\"originalUrl\":\"\",\"previewUrl\":\"{Configuracoes.ImagemUrl}\",\"caption\":\"Sample image\"}}";
        request.AddParameter("message", message);

        var response = await client.PostAsync(request);
        Console.WriteLine("{0}", response.Content);
    }
     public static async Task Document()
    {
        var message = $"{{\"type\":\"document\",\"originalUrl\":\"\",\"previewUrl\":\"{Configuracoes.PdfUrl}\",\"caption\":\"Sampled document\"}}";
        request.AddParameter("message", message);

        var response = await client.PostAsync(request);
        Console.WriteLine("{0}", response.Content);
    }
      public static async Task Sticker()
    {
        var message = $"{{\"type\":\"document\",\"originalUrl\":\"\",\"previewUrl\":\"{Configuracoes.PdfUrl}\",\"caption\":\"Sampled document\"}}";
        request.AddParameter("message", message);

        var response = await client.PostAsync(request);
        Console.WriteLine("{0}", response.Content);
    }
}
