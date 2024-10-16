namespace Ex_21_Heranca;

public class Pessoa
{

    private string nome, sobrenome;

    public Pessoa(){}

    public Pessoa(string nome, string sobrenome){
        this.Nome=nome;
        this.Sobrenome=sobrenome;

    }

    public string Nome{get;set;}
    public string Sobrenome{get;set;}

    public virtual void LerDados(){
        Console.WriteLine("Digite o nome da pessoa: ");
        this.Nome=Console.ReadLine();
        Console.WriteLine("Digite o sobrenome da pessoa: ");
        this.Sobrenome=Console.ReadLine();
    }

}
