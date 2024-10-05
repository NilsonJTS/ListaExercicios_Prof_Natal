using System.ComponentModel.Design;
using System.Diagnostics.Metrics;

namespace Ex19_EscolheTipodeMedia;

public class EscolheMedia
{
    private double nota1, nota2, nota3;

    public double GetNota1(){return this.nota1;}
    public void SetNota1(double RecebeNota1){this.nota1=RecebeNota1;}
    public double GetNota2(){return this.nota2;}
    public void SetNota2(double RecebeNota2){this.nota2=RecebeNota2;}
    public double GetNota3(){return this.nota3;}
    public void SetNota3(double RecebeNota3){this.nota3=RecebeNota3;}

    public EscolheMedia(){}


    public void MenuOpcao(){
        
        int option=0;
        while (option != 3){
            Console.WriteLine("(1)inserir notas | (2)Escolher Tipo de Média | (3)sair");
            option=Convert.ToInt16(Console.ReadLine());
            switch(option){
                case 1:
                    LerDados();
                    break;
                case 2:
                    EscolheTipoMedia();
                    break;
                default:
                    Console.WriteLine("Valor inválido, tente novamente:");
                break;
            }
            
        }
    }

    public void EscolheTipoMedia(){
        int Counter=1;
        int option=0;
        do{
            Console.WriteLine("(1) Aritmetica | (2)Ponderada 3,3,4 | (3)harmônica | (4)Sair");
            option=Convert.ToInt16(Console.ReadLine());
            switch(option){
            case 1:
                Console.WriteLine(MAritmetica(this.nota1, this.nota2, this.nota3));
                break;
            case 2:
                Console.WriteLine(MPonderada(this.nota1, this.nota2, this.nota3));
                break;
            case 3:
                Console.WriteLine(MHarmonica(this.nota1, this.nota2, this.nota3));
                break;
            case 4:
                Counter=2;
                break;
            default:
                Console.WriteLine("Valor inválido, tente novamente:");
                break;
            }
        }while (Counter==1);
        MenuOpcao();
    }

    public double MAritmetica(double a, double b, double c){
        return Math.Round((a+b+c)/3,2);
    }

    public double MPonderada(double a, double b, double c){
        return Math.Round((a * 3 + b * 3 + c * 4) / (3 + 3 + 4),2);
    }

    public double MHarmonica(double a, double b, double c){
        return Math.Round(3 / ((1 / nota1) + (1 / nota2) + (1 / nota3)),2);
    }

    public void LerDados(){
        Console.WriteLine("Digite a 1ª nota: ");
        SetNota1(Convert.ToDouble(Console.ReadLine()));

        Console.WriteLine("Digite a 2ª nota: ");
        SetNota2(Convert.ToDouble(Console.ReadLine()));

        Console.WriteLine("Digite a 3ª nota: ");
        SetNota3(Convert.ToDouble(Console.ReadLine()));
        MenuOpcao();
    }
}
