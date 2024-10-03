namespace Ex17_PesoIdeal;

public class PesoIdeal
{

    public string sexo = "M";
    public double altura=0;


    public PesoIdeal(){}

    public void CauculaPeso(){
        int cont =1;

        while(cont == 1){

        Console.WriteLine("Digite o sexo (M/F): ");
        string sexo = Console.ReadLine() ?? "M" ;  

        Console.WriteLine("Digite a altura: ");
        altura =Convert.ToDouble(Console.ReadLine());  

        switch(sexo.ToUpper()){
            case "M":
                Console.WriteLine($"Para um homem com {altura:n2} de altura. O peso ideal é: {(72.7 * altura)-58:n2}");
                break;
            
            case "F":
                Console.WriteLine($"Para uma mulher com {altura:n2} de altura. O peso ideal é: {(62.1 * altura)-44.7:n2}");
                break;
            default:
                Console.WriteLine("Valor inválido, tente novamente");
                break;
        }
                     
        Console.WriteLine("Continuar(1) | Sair(2)");
        string inputCont = Console.ReadLine() ;
            // Usa TryParse para evitar erro de conversão
            if (inputCont =="1" ||inputCont=="2"){
                cont = int.Parse(inputCont);
            }else{
                Console.WriteLine("Entrada inválida");
                cont=1;
            }
    }
    }


}
