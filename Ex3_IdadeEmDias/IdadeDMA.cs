using System.Diagnostics.Contracts;

namespace Ex3_IdadeEmDiasMeA;

public class IdadeDMA
{
    public int dia,mes,ano;
    DateTime dataAtual = DateTime.Now;

    public IdadeDMA(){}

    public void LerDados(){
        Console.WriteLine("Digite o dia do seu aniversário:");
        dia=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o mês do seu aniversário:");
        mes=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o ano do seu aniversário (yyyy):");
        ano=Convert.ToInt32(Console.ReadLine());

        Contagem();
    }

    public void Contagem(){
        int contagemDias = dataAtual.Day;
        int contagemMeses = dataAtual.Month-1;
        int contagemAnos = (dataAtual.Year - this.ano)-1;

        Console.WriteLine($"Você tem:\n{contagemAnos} anos\n{contagemMeses} meses\n{contagemDias} dias");

        Console.WriteLine($"\nEquivale a {(contagemAnos*12*30)+(contagemMeses*30)+contagemDias} dias\n");
    }

}
