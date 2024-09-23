using System;
using CustomizedException;

try
{
    throw new CustomException("Esta é minha exception");
}
catch(CustomException e)
{
    Console.WriteLine(e.Message);
    Console.WriteLine(e.StackTrace);
}
finally
{
    Console.WriteLine("Fim");
}