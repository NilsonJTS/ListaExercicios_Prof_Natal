using System.Diagnostics.Metrics;

namespace Ex20_TotalDeVendas;

public class TotalVendas
{
    private double total;
    
    //Getter Setter
    public void SetTotal(double total){this.total = total;}
    public double GetTotal(){return total;}
    
    public TotalVendas(){}

    public void menu(){
        int count=1;
        int quant;
        double resposta;
        while (count==1){
            Console.WriteLine($"\nTotal= {GetTotal()}");
            Produtos();
            Console.WriteLine("digite: (1) Continuar Soma | (2) Sair");
            count=Convert.ToInt16(Console.ReadLine());
            resposta=Codigo();
            if(resposta !=0){
                Console.WriteLine("Digite a quantidade:");
                quant=Convert.ToInt16(Console.ReadLine());
                SetTotal(quant*resposta);

            }else{
                Console.WriteLine("Resposta inválida, tente novamente.");
            }
        }
    }

    public double Codigo(){
        int cod;
        double valor=0;
        Console.WriteLine("Digite o código do produto:");
        cod=Convert.ToInt16(Console.ReadLine());
        switch (cod){
            case 1001:
                valor=5.32;
                return valor; 
                

            case 1324:
                valor=6.45;
                return valor; 
                

            case 6548:
                valor=2.37;
                return valor; 
                

            case 0987:
                valor=5.32;
                return valor; 
                

            default:
                return 0;
                
        }
    }

    public void Produtos(){
        Console.WriteLine("\n==============================\n");
        Console.WriteLine("código produto | Preço unitário \n");
        Console.WriteLine("------------------------------\n");
        Console.WriteLine(" 1001          | 5.32\n");
        Console.WriteLine(" 1324          | 6.45\n");
        Console.WriteLine(" 6548          | 2.37\n");
        Console.WriteLine(" 0987          | 5.32\n");
        Console.WriteLine("==============================\n");
    }

}
