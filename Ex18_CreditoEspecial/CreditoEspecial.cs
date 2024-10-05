using System.Security.Cryptography.X509Certificates;

namespace Ex18_CreditoEspecial;

public class CreditoEspecial
{      
    private double saldo;

    public void SetSaldo(double saldo){
        this.saldo=saldo;
    }

    public double GetSaldo(){
        return this.saldo;
    }
    
    public CreditoEspecial(double saldo){
        this.saldo=saldo;
        Classifica(this.saldo);
    }


    public void Classifica(double saldo){
        double saldoMedio=saldo;
        double porcentagem=0;
        
        if(saldoMedio<=200){
            Console.WriteLine("Seu saldo não lhe dá direito a nenhum crédio.");
        }else if(saldoMedio>=201 && saldoMedio<=400){
            porcentagem=1.2;
            CalculaCredito(porcentagem);
        }else if(saldoMedio>=401 && saldoMedio<=600){
            porcentagem=1.3;
            CalculaCredito(porcentagem);
        }else{
            porcentagem=1.4;
            CalculaCredito(porcentagem);
        }
    }


    public void CalculaCredito(double porcentagem){
        double indiceCalculo=porcentagem;
        double total = saldo*indiceCalculo;
            Console.WriteLine($"Seu saldo é de R${saldo:n2}.\nSeu crédito é de {(indiceCalculo-1)*100:0}% R${saldo*(indiceCalculo-1):n2}");
            Console.WriteLine($"Total de R${total:n2}");
        }
    



}
