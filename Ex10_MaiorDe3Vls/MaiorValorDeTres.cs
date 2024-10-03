namespace Ex10_MaiorDe3Vls;

public class MaiorValorDeTres{

    public double a,b,c;

    public MaiorValorDeTres(){}

    public double LerValores(){
        Console.WriteLine("Digite o primeiro valor:");
        a=Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Digite o segundo valor:");
        b=Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o terceiro valor:");
        c=Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"\nDentre os valores {a}, {b} e {c}.\n");
        encontraValor(this.a, this.b, this.c);
        return 0;
    }

    public double encontraValor(double a, double b, double c){
        double vl1 = a;
        double vl2 = b;
        double vl3 = c;
        if (vl1 > vl2 && vl1 > vl3 ){
            return vl1;
        }else if(vl2 > vl1 && vl2 > vl3 ){
            return vl2;
        }else if(vl3 > vl2 && vl3 > vl1 ){
            return vl3;
        }
       
        return 0;
    }

}
