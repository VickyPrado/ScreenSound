//1. Escrever um programa que faça uam requisição para a API de games CheapShark e mostre na tela a lista de promoções cadastrada na ferramenta (Você pode utilizar o endpoint: https://www.cheapshark.com/api/1.0/deals).

/*
using (HttpClient client = new HttpClient())
{
    string resposta = await client.GetStringAsync("https://www.cheapshark.com/api/1.0/deals");
    Console.WriteLine(resposta);
}
*/




//2. Escrever um programa que solicite dois números a e b lidos do teclado e realize a divisão de a por b. Caso essa operação não seja possível, mostrar uma mensagem no console que deixe claro o erro ocorrido.

/*
 {   try
    {
        Console.Write("Digite o numerador: ");
        int numeradorA = int.Parse(Console.ReadLine());

        Console.Write("Digite o denominador: ");
        int numeradorB = int.Parse(Console.ReadLine());

        int operacao = numeradorA / numeradorB;
        Console.WriteLine(operacao);

    }
    catch (Exception ex)
    {
        Console.WriteLine($"Ocorreu um erro: {ex.Message}");
    }
    
 }
*/




//3. Declarar uma lista de inteiros e tente acessar um elemento em um índice inexistente. Tratar a exceção apropriada.

/*
{
    try
    {
        List<int> num = new List<int>{1, 2, 3};
        Console.WriteLine($"Elemento no índice 0: {num[0]}");
        Console.WriteLine($"Elemento no índice 1: {num[1]}");
        Console.WriteLine($"Elemento no índice 2: {num[2]}");
        Console.WriteLine($"Elemento no índice 5: {num[5]}");    
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Ocorreu um erro: {ex.Message}");
    }
}
*/




//4. Criar uma classe simples com um método e chame esse método em um objeto nulo. Tratar a exceção de método em objeto nulo.

/*
 try
    {
        MinhaClasse objetoNulo = null;
        objetoNulo.MeuMetodo();
    }
    catch (NullReferenceException ex)
    {
        Console.WriteLine($"Ocorreu um erro: {ex.Message}");
    }
*/