using Ex10_MaiorDe3Vls;

internal class Program
{
    private static void Main(string[] args)
    {
        MaiorValorDeTres obj = new MaiorValorDeTres();
        obj.LerValores();
        Console.WriteLine($"o maior valor é {obj.encontraValor()}");
    }
}