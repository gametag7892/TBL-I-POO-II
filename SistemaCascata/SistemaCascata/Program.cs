using System;
using System.Runtime.CompilerServices;

class Cliente
{
    public string addCliente()
    {
        Console.WriteLine("Nome do cliente:");
        string cliente = Console.ReadLine();

        return cliente;
    }
}

class Produto
{
    public string Nome { get; set; }
    public decimal Preco { get; set; }



}

class Pedido
{
    public string retornarPedido(string cliente, string nome, decimal preco)
    {
        return $"Cliente {cliente} comprou o produto {nome} pelo preço de R$ {preco}.";
    }

    public decimal total(params decimal[] p)
    {
        decimal total = 0;

        foreach (decimal c in p)
        {
            total += c;
        }

        return total;
    }

}

class Program
{
    public static void Main()
    {
        Cliente cliente1 = new Cliente();
        Produto produto1 = new Produto();
        Produto produto2 = new Produto();
        Pedido pedido = new Pedido();

        string pessoa = cliente1.addCliente();
        produto1.Nome = "Maça";
        produto1.Preco = 4.90M;
        produto2.Nome = "AR-15";
        produto2.Preco = 1000.00M;

        decimal total = pedido.total(produto1.Preco, produto2.Preco);

        string pedido1 = pedido.retornarPedido(pessoa, produto1.Nome, produto1.Preco);
        string pedido2 = pedido.retornarPedido(pessoa, produto2.Nome, produto2.Preco);

        Console.WriteLine(pedido1);
        Console.WriteLine(pedido2);
        Console.WriteLine($"Total: {total}");
    }
}

/*
    6. Responder

        a) Descrevam exatamente a ordem em que vocês trabalharam no projeto.

           R: Primeiramente, foi realizado a definição de cada Classe e metodo dentro do projeto, em sequencia, 
           foi realizado a codificação do projeto e por fim, a entrega do projeto ao cliente.

        b) Explique como foi garantido que uma fase estava concluída antes de iniciar a
        próxima.

            R: Após conversar com o cliente e definir o projeto, foi o momento de começar o código,
            após finalizar o código, foi onde o software estava completo.


        c) Caso o cliente solicitasse alteração após a implementação, qual seria o
        procedimento correto dentro do modelo Cascata?

            R: Recomeçar o projeto do zero certificando-se de completar todas as etapas e solicitações realizadas pelo cliente


     PERGUNTAS COMPARATIVAS – CASCATA × INCREMENTAL

        a) Em qual modelo o sistema começou a gerar valor mais rapidamente?

            R: O Incremental

        b) Em qual modelo o risco é identificado mais cedo?

            R: O Incremental

        c) O que é mais importante: seguir o modelo rigorosamente ou entregar valor?

            R: Entregar valor

 */