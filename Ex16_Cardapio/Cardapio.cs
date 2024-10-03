namespace Ex16_Cardapio;

public class Cardapio
{

    public double valor, numeroPedido, produto;
    public int quantidade;

    public Cardapio(){}

    public void Pedido(){
        Console.Write("Digite o número do pedido: ");
        numeroPedido=Convert.ToDouble(Console.ReadLine());
        
        string atualiza = "S";
        
        while (atualiza != "N"){
            menu();
            Console.Write("Digite o codigo do produto: ");
            produto=Convert.ToDouble(Console.ReadLine());

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
                    Console.Write("\nCachorro quente\n");
                    Console.Write("Digite a quantidade: ");
                    quantidade= Convert.ToInt16(Console.ReadLine());
                    valor += 1.2*quantidade;
                    break;
                default:
                    Console.Write("\nCódigo inválido, tente novamente.");
                    break;

            }


            Console.Write("Fechar o pedido? (S/N): ");
            atualiza=Console.ReadLine().ToUpper();
        }

    }

    public void menu(){
        Console.Write("\n======================================\n");
        Console.Write("| Produto          | Cod  |   Preço   |\n");
        Console.Write("| Cachorro quente  | 100  |   1.20    |\n");
        Console.Write("| Bauru            | 101  |   1.50    |\n");
        Console.Write("| Hamburguer       | 103  |   1.20    |\n");
        Console.Write("| Refrigerante     | 105  |   1.00    |\n");
        Console.Write("======================================\n");
      
    }

}
