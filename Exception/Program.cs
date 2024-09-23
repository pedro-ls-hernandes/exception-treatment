//try = código que pode gerar exceções
//catch = tratamento da exceção (podem ser varios) [opicional]
//finally = elemento final (apenas um) [opcional]

try
{
    Console.WriteLine("Digite o dividendo:");
    int dividendo = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite o divisor");
    int divisor = int.Parse(Console.ReadLine());

    double resultado = dividendo / divisor;

    Console.WriteLine(resultado);
}
catch(DivideByZeroException)
{
    Console.WriteLine("Impossivel dividir por 0");
}
catch (FormatException)
{
    Console.WriteLine("O dividendo e/ou divisor deve ser número inteiro");
}
catch (OverflowException)
{
    Console.WriteLine("Digite números entre 1 a 999999");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
    Console.WriteLine(e.StackTrace);
    Console.WriteLine(e.Source);
}
finally
{
    Console.WriteLine("\nProcessamento finalizado");
}
