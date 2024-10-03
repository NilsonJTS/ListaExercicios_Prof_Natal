using System.Runtime.InteropServices;

namespace Ex12_NadadorCategoria;

public class CategoriaNadador
{

    private int idade;

    public CategoriaNadador(){}


    public int AgeClass{
        get{ return idade; }
        set{ idade = value; }
    }


    public int LerDados(){

        char opcao='a';

        while(opcao != 'S'){
        Console.Write("Qual é a idade do competidor? ");
        AgeClass=Convert.ToInt16(Console.ReadLine());
        Console.Write(Classificador(AgeClass));

        
        Console.Write("Digite (C) para continuar, ou, (S) para sair ");
        opcao= char.ToUpper(Console.ReadLine()[0]);
        }


        return 0;
    }

    public string Classificador(int idade){
        int classe=idade;
        if(idade < 5){
            return "\nNão tem idade para competir.\n";
        }else if(idade >= 5 && idade <=7){
            return "\nCategoria infantil A.\n";
        }else if(idade >= 8 && idade <=10){
            return "\nCategoria infantil B.\n";
        }else if(idade >= 11 && idade <=13){
            return "\nCategoria juvenil A.\n";
        }else if(idade >= 14 && idade <=17){
            return "\nCategoria infantil B.\n";
        }else{
            return "\nCategoria adulto\n";
        }
        
    }


}
