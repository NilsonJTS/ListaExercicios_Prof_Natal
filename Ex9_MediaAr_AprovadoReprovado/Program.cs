using Ex9_MediaAr_AprovadoReprovado;

internal class Program
{
    private static void Main(string[] args)
    {
        MediaNotas obj = new MediaNotas();
        obj.AprovadoReprovado(obj.LerDados());
    }
}