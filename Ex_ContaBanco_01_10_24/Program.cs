using ExercicioNatal24_09_24;

internal class Program
{
    private static void Main(string[] args)
    {
        Cliente objCli = new Cliente("Natal", 123);
        Conta objCon = new Conta(1001, 100, objCli);

        objCon.Menu();
    }    
}

/*
O sistema funciona da seguinte forma:
aqui no program eu só instancio duas classes e já passo alguns parametros.
Chamo o método menu, que contém em si, um laço de repetição para que o usuário
possa usar repetidamente até que decida sair, e tem ainda uma opção de valor
inválido no default do switch case.
*/