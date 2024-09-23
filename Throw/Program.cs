using Throw;
using System;

/*throw new Exception();
  throw new Exception("mensagem");
  throw NotImplementedException();
        ArgumentException();
        NullReferenceException();
        FormatException();
        InvalidCastException();
        FileNotFoundException();
*/
try
{
    A.ProcessarA();
}
catch
{
    Console.WriteLine("Tratamento da exceção no main");
}

A.ProcessarA();
B.ProcessarB();
