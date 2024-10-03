namespace Ex5_MediaPondAluno;

public class MediaPonderadaAluno
{

    public double nota1, nota2, nota3;

    public MediaPonderadaAluno(){}

    public void lerDados(){
        Console.WriteLine("Digite a 1ª nota:");
        this.nota1=Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite a 2ª nota:");
        this.nota2=Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite a 3ª nota:");
        this.nota3=Convert.ToDouble(Console.ReadLine());

        MediaPonderada ();
    }

    public void MediaPonderada(){
        double media = (((this.nota1*2) + (this.nota2*3) + (this.nota3*5))/10);
        Console.WriteLine($"\nSua média ponderada é: {media}\n");

    }

}
