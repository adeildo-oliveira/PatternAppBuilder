using PatternAppBuilder.PatternBuiler;
using System;

namespace PatternAppBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var clienteBuilder = new ClienteBuilder()
                .ComNome("João")
                .ComSobreNome("Silva")
                .ComEmail("teste@noemail.com")
                .ConstroiCliente();

            Console.WriteLine($"{clienteBuilder.Nome}\n{clienteBuilder.SobreNome}\n{clienteBuilder.Email}");
            //Console.ReadKey();
        }
    }
}
