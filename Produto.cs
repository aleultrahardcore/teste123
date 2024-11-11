// Pergunta: Crie uma classe Produto com Nome, Preco, QuantidadeEmEstoque e métodos Vender, AdicionarEstoque, ExibirDetalhes
using System;

class Produto
{
    // Propriedades da classe
    public string Nome { get; set; }
    public decimal Preco { get; set; }
    public int QuantidadeEmEstoque { get; set; }

    // Método para vender produtos, diminuindo o estoque
    public void Vender(int quantidade)
    {
        if (QuantidadeEmEstoque >= quantidade)
        {
            QuantidadeEmEstoque -= quantidade;
            Console.WriteLine($"{quantidade} unidades de {Nome} vendidas.");
        }
        else
        {
            Console.WriteLine("Estoque insuficiente.");
        }
    }

    // Método para adicionar ao estoque
    public void AdicionarEstoque(int quantidade)
    {
        QuantidadeEmEstoque += quantidade;
        Console.WriteLine($"{quantidade} unidades adicionadas ao estoque de {Nome}.");
    }

    // Método para exibir os detalhes do produto
    public void ExibirDetalhes()
    {
        Console.WriteLine($"Produto: {Nome}, Preço: {Preco}, Estoque: {QuantidadeEmEstoque}");
    }
}

class Program
{
    static void Main()
    {
        // Criando um objeto Produto
        Produto p = new Produto();
        p.Nome = "Cadeira";
        p.Preco = 150.00m;
        p.QuantidadeEmEstoque = 10;

        // Exibindo os detalhes
        p.ExibirDetalhes();

        // Vendendo 3 unidades e exibindo o estoque atualizado
        p.Vender(3);
        p.ExibirDetalhes();

        // Adicionando 5 unidades ao estoque e exibindo o estoque atualizado
        p.AdicionarEstoque(5);
        p.ExibirDetalhes();

        //---------------- parte strings ---------------


        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("Parte das strings: ");
        Console.WriteLine("");

        // Array de produtos
        string[] produtos = { "Mesa", "Cadeira", "Sofá", "Armário" };

        // Ordenando o array
        Array.Sort(produtos);
        Console.WriteLine("Produtos em ordem alfabética:");
        foreach (string produto in produtos)
        {
            Console.WriteLine(produto);
        }

        // Verificando se um produto específico está no array
        string busca = "Sofá";
        if (Array.Exists(produtos, produto => produto == busca))
        {
            Console.WriteLine($"{busca} está na lista de produtos.");
        }
        else
        {
            Console.WriteLine($"{busca} não está na lista de produtos.");
        }

        //---------------- parte Logica ---------------


        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("Parte Logica: ");
        Console.WriteLine("");

        Console.WriteLine("Números ímpares entre 1 e 50:");
        for (int i = 1; i <= 50; i++)
        {
            if (i % 2 != 0)
            {
                Console.WriteLine(i);
            }
        }


        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("Parte recursiva: ");
        Console.WriteLine("");

        // Função recursiva para calcular o fatorial
        static int Fatorial(int n)
        {
            if (n <= 1)
            {
                return 1;
            }
            return n * Fatorial(n - 1);
        }

        int numero = 5;
        int resultado = Fatorial(numero);
        Console.WriteLine($"O fatorial de {numero} é {resultado}");


    }
}
