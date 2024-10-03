using System.Reflection.Metadata.Ecma335;

namespace Ex9_MediaAr_AprovadoReprovado;

public class MediaNotas
{
    public double nota1,nota2,nota3,media;

    public MediaNotas(){}

    public double LerDados(){
        Console.WriteLine("Digite a 1ª nota:");
        nota1=Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite a 2ª nota:");
        nota2=Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite a 3ª nota:");
        nota3=Convert.ToDouble(Console.ReadLine());

        double mediaAritmetica=(this.nota1+this.nota2+this.nota3)/3;
        return mediaAritmetica;
        AprovadoReprovado(mediaAritmetica);
    }

    public void AprovadoReprovado(double media){
        this.media=media;
        Console.WriteLine($"\nMédia do aluno: {media}\n");
        if (media >= 6){
            Console.WriteLine("APROVADO");
        }else{
            Console.WriteLine("REPROVADO");
        }
    }
    
}
