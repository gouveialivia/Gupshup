using DotNetEnv;
using System;

public static class Config
{
    static Config()
    {
        Env.Load();
    }

    public static string Apikey => Environment.GetEnvironmentVariable("apikey") ?? "";
    public static string Token => Environment.GetEnvironmentVariable("token") ?? "";
    public static string Numero => Environment.GetEnvironmentVariable("numero") ?? "";
    public static string Nome => Environment.GetEnvironmentVariable("nome") ?? "";
    public static string Url => Environment.GetEnvironmentVariable("url") ?? "";
    public static string AppId => Environment.GetEnvironmentVariable("app_id") ?? "";

    public static string Destino_Numero => Environment.GetEnvironmentVariable("destino_numero") ?? "";
}
