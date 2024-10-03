namespace Ex7_CarroNovo;

public class ValorCarro
{

    public double CustoFabrica;

    public ValorCarro(){}

    public void ValorFinal(){
        double impostos, distribuidor;
        Console.WriteLine("Digite o custo do carro:");
        this.CustoFabrica=Convert.ToDouble(Console.ReadLine());

        distribuidor=this.CustoFabrica*0.28;
        impostos=distribuidor*0.45;
        Console.Write($"\n================================\nCusto: R$ {CustoFabrica:N2}\nDistribuidor R$ {distribuidor:N2}\nImpostos R$ {impostos:N2}\n================================\nTotal R$ {CustoFabrica+distribuidor+impostos:N2}\n");


    }

}
