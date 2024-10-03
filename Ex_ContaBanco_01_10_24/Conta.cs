namespace ExercicioNatal24_09_24;

public class Conta
{
    //atribuindo atributos
    public int numero; 
    private double saldo;
    public Cliente cliente;
/*
    //getters e setters
    //==================================
    public double getSaldo(){
        return this.saldo;
    }

    public void setSaldo(double saldo){
        this.saldo=saldo;
    }
    //===================================
*/

    //métodos

    public Conta(int numero, double saldo, Cliente cli){
        this.numero=numero;
        Saldo=saldo;
        this.cliente=cli;
    }

    public double Saldo{get;set;}

    //métodos
    public void Creditar(double valor){
        Saldo+=valor;
        Console.WriteLine($"Saldo Atual R$ {Saldo:n2}");
    }

    public void Debitar(double valor){
        
       
    }


    public Boolean verificarSaldoNegativo(double saque){
        double R=Saldo - saque;
        if(R<0)             //quando tem uma só condição, não precisa de {}
            return false;
        else
            return true;
    }


    public void MostrarSaldo(){
         Console.WriteLine($"O saldo atual é: R$ {Saldo:n2}");
    }

    public void Menu(){
         int contador=0;
         int opcao = 0;

        do{
            Console.WriteLine("\n=================================");
            Console.WriteLine("Digite 1 para Creditar");
            Console.WriteLine("Digite 2 para Debitar");
            Console.WriteLine("Digite 3 para Mostrar Saldo");
            Console.WriteLine("Digite 0 para sair");
            Console.WriteLine("=================================");
            Console.WriteLine($"Saldo Atual R$ {Saldo:n2}\n");
            opcao=Convert.ToInt16(Console.ReadLine());

            switch(opcao){
                case 1 : 
                Console.WriteLine("Digite o valor a ser creditado:");
                this.Creditar(Convert.ToDouble(Console.ReadLine()));
                break;
                
                case 2 :
                Console.WriteLine("Digite o valor a ser debitado");
                double saque=Convert.ToDouble(Console.ReadLine());
                if(this.verificarSaldoNegativo(saque))
                    this.Debitar(saque);
                else
                    Console.WriteLine($"Saldo insuficiente. Máximo permitido R$ {Saldo:n2}");
                break;

                case 3 :
                this.MostrarSaldo();
                break;
                case 0 :
                contador=1;
                break;
                default:
                Console.WriteLine("Valor inválido");
                break;
            }
        }while(contador==0);
    }

}
