namespace Ex6_DeSegundosParaHoras;

public class Tempo
{

    public int Segundos;

    public Tempo(){}

    public void contaTempo(){
                
        Console.WriteLine("Digite o tempo em segundos:");
        this.Segundos=Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine($"\n{Segundos} segundos, equivalem a:\n{Segundos/86400:F0} dias\n{Segundos/3600:F0} horas\n{Segundos/60} minutos\n");
        
    }






}

