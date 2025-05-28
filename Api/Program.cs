using System;
using System.Threading.Tasks;
using RestSharp;
//Aqui eu puxo os arquivos Base que todos os SendMessage precisa e depois escolho qual quero iniciar
// Fazer: modificar esse arquivo pois acho que nao encaixa no conceito de Gateway como esta agora
// Pesquisar como temos que deixar tudo para encaixar no conceito de Gateway e nao fugir disso.

class Inicio : Gupshup
{
    public static async Task Main()
    {
        Gupshup.GupshupBase();
        await Message.Video();
    }
}
