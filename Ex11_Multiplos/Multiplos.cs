namespace Ex11_Multiplos;

public class Multiplos
{

    private int Vl1,Vl2;
    
    public Multiplos(){}

    public void RecebeValor(){
        Console.WriteLine("Digite o primeiro valor:");
        Val1=Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Digite o primeiro valor:");
        Val2=Convert.ToInt16(Console.ReadLine());

        multResult();
    }

    public void multResult(){
        double resto= Val1%Val2;
        if(resto==0)
            Console.WriteLine($"{Val1} é multiplo de {Val2}.");
        else
            Console.WriteLine($"{Val1} e {Val2} não são multiplos.");
    }

    public int Val1{get;set;}
    public int Val2{get;set;}


}
