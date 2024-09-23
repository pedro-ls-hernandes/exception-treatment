try
{
    Console.WriteLine("Digite a url da página");
    string url = Console.ReadLine();
    HttpClient client = new HttpClient();
    HttpResponseMessage response = client.GetAsync(url).Result;
    if (response.IsSuccessStatusCode)
    {
        Console.WriteLine("Acesso Sucesso");
        Console.WriteLine($"Código Status: {response.StatusCode}");
    }
    else
    {
        throw new HttpRequestException($"Erro: {(int)response.StatusCode}");
    }
}
catch (HttpRequestException e) when (e.Message.Contains("404"))
{
    Console.WriteLine("Página não encontrada");
}
catch (HttpRequestException e) when (e.Message.Contains("400"))
{
    Console.WriteLine("Página não encontrada");
}
catch(Exception e)
{
    Console.WriteLine($"{e.Message}");
}
finally
{
    Console.WriteLine("Fim");
}