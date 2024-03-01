namespace ProjetoLampada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lampada lamp1 = new Lampada();

            lamp1.Ligada = true;
            lamp1.Potencia = 100;
            lamp1.Cor = "Vermelho";

            Console.WriteLine("Mostrando Dados do Objeto lamp1");
            Console.WriteLine("A lâmpada está ligada? " + lamp1.Ligada);
            Console.WriteLine("A potência da lâmpada é: " + lamp1.Potencia);
            Console.WriteLine("A cor da lâmpada é: " + lamp1.Cor);

        }
    }
}