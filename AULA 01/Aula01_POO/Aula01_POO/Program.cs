using System;

namespace Aula01_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aula 01 - POO");
            
            //Criando uma instância da classe Conta
            Conta conta1 = new Conta();

            //Atribuindo os valores para cada atributo da classe Conta
            conta1.Saldo = 1500;
            conta1.Limite = 500;
            conta1.Numero = 123;

            Console.WriteLine("Olá fulano, seu saldo em conta é de: R$ " + conta1.Saldo);
            Console.WriteLine("Seu limite de saque é de R$ " + conta1.Limite);
            Console.WriteLine("Sua conta é nº " + conta1.Numero);


        }
    }
}



