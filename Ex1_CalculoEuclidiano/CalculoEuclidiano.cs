namespace Ex1_CalculoEuclidiano;

public class CalculoEuclidiano
{
    public double x1=0;
    public double x2=0;
    public double y1=0;
    public double y2=0;

    public CalculoEuclidiano(){
    }

    public void leituraDados(){
        Console.WriteLine("Digite o valor de x1:");
        x1=Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o valor de y1:");
        y1=Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o valor de x2:");
        x2=Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o valor de y2");
        y2=Convert.ToDouble(Console.ReadLine());

        Calculo();
    }

    public void Calculo(){
        Console.WriteLine(Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2)));
    }
}
