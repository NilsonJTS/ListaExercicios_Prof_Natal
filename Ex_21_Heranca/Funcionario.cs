namespace Ex_21_Heranca;

public class Funcionario : Pessoa
{

    private int matricula;
    private double salario;

    
    public Funcionario(){
    }

    public Funcionario(string nome, string sobrenome, int matricula, double salario) : base(nome, sobrenome){
        this.Matricula=matricula;
        this.Salario=salario;
    }

    public int Matricula {get;set;}
    public double Salario {get;set;}

    public override void LerDados(){

        base.LerDados();
        
        Console.WriteLine("Digite sua matricula: ");
        this.Matricula=Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Digite seu salário: ");
        this.Salario=Convert.ToDouble(Console.ReadLine());

        
    }

    public void ImprimeDados(){
        
        Console.WriteLine($"Funcionário: {this.Nome} {this.Sobrenome}\nMatrícula: {this.Matricula}\nSalário: R${this.Salario:n}");
        
    }

}
