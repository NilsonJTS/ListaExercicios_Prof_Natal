namespace Ex16_Cardapio;

public class Cardapio
{
    
    
    public double valor;
    public int quantidade , numeroPedido, produto;

    public Cardapio(){}

    public void Pedido(){
        Console.Write("Digite o número do pedido: ");
        numeroPedido=Convert.ToInt16(Console.ReadLine());
        
        int Op = 0;
        string atualiza = "S";
        char cont2 = 'A' ;
        
        while (atualiza.ToUpper() == "S"){
            
            Menu();
            Console.Write("Digite o codigo do produto: ");
            produto=Convert.ToInt16(Console.ReadLine());

            switch(produto){
                case 100:
                    Console.Write("\nCachorro quente\n");
                    Console.Write("Digite a quantidade: ");
                    quantidade= Convert.ToInt16(Console.ReadLine());
                    valor += 1.2*quantidade;
                    break;
                case 101:
                    Console.Write("\nBauru\n");
                    Console.Write("Digite a quantidade: ");
                    quantidade= Convert.ToInt16(Console.ReadLine());
                    valor += 1.5*quantidade;
                    break;
                case 103:
                    Console.Write("\nHamburguer\n");
                    Console.Write("Digite a quantidade: ");
                    quantidade= Convert.ToInt16(Console.ReadLine());
                    valor += 1.2*quantidade;
                    break;
                case 105:
                    Console.Write("\nRefrigerante\n");
                    Console.Write("Digite a quantidade: ");
                    quantidade= Convert.ToInt16(Console.ReadLine());
                    valor += 1.0*quantidade;
                    break;
                default:
                    Console.Write("\nCódigo inválido, tente novamente.");
                    break;
          
            }

            do{
            
            Console.WriteLine("Total (1) | Continuar pedindo (2) | Sair (3)");
            Op=Convert.ToInt16(Console.ReadLine());

            switch(Op){
                case 1:
                    Console.WriteLine($"Total R${valor}");
                    break;

                case 2:
                    cont2='N';
                    break;

                case 3:
                    atualiza = "S";
                    break;

                default:
                    Console.WriteLine("Opção inválida, tente novamente");
                    break;
            }  
 
            }while(cont2 == 'A');              
            
        }

    }


      public void Menu(){

  
        Console.Write("\n======================================\n");
        Console.Write("| Produto          | Cod  |   Preço   |\n");
        Console.Write("| Cachorro quente  | 100  |   1.20    |\n");
        Console.Write("| Bauru            | 101  |   1.50    |\n");
        Console.Write("| Hamburguer       | 103  |   1.20    |\n");
        Console.Write("| Refrigerante     | 105  |   1.00    |\n");
        Console.Write("======================================\n");
      
    }

}
