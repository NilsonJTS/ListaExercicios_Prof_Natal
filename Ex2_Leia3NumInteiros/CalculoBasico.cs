using System.Security.Cryptography.X509Certificates;

namespace Ex2_Leia3NumInteiros;

public class CalculoBasico
{
    public double a=0;
    public double b=0;
    public double c=0;


    public CalculoBasico(){
    }

    public void LeituraDados(){
        Console.WriteLine("Digite o valor de A:");
        a=Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o valor de B:");
        b=Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o valor de C:");
        c=Convert.ToDouble(Console.ReadLine());
        
        Calc();
    }

    public void Calc(){
        double R = Math.Pow(this.a + this.b , 2);
        double S = Math.Pow(this.b + this.c , 2);
        double D = (R+S)/2;

        Console.WriteLine($"O Resultado é: {D:F2}");
    }
}
