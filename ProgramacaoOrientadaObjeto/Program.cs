using ProgramacaoOrientadaObjetos;
using ProgramacaoOrientadaObjetos.Basico;
using ProgramacaoOrientadaObjetos.OOP;
using System;
using System.Globalization;

namespace ProgramacaoOrientadaObjetos
{
    class Program
    {



        static void Main(string[] args)
        {
            Encapsulamento();
        }

        /// <summary>
        /// Entre os dados do produto:, Nome: TV, Preço: 900.00, Quantidade no estoque: 10
        /// Imprimir dados na tela. Adicionar 5 produtos e imprimir atualização e 
        /// remover 3 produtos e mostrar os dadoa atualizados.
        /// </summary>
        public static void Construtor()
        {
            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");

            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());
            Construtor p = new Construtor(nome, preco, quantidade);

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            Console.WriteLine();

            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
        }

        /// <summary>
        /// Criar um construtor opcional, o qual recebe apenas nome e 
        /// preço do produto.A quantidade em estoque deste novo produto, por
        /// padrão, deverá então ser iniciada com o valor zero.
        /// Nota: é possível também incluir um construtor padrão(sem parâmetros - linha 66)
        /// </summary>
        public static void Sobrecarga()
        {
            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Sobrecarga p = new Sobrecarga(nome, preco);

            Sobrecarga p2 = new Sobrecarga();


            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
        }

        public static void Encapsulamento()
        {
            Encapsulamento p = new Encapsulamento("TV", 500.00, 10);

            p.SetNome("TV 4K");

            Console.WriteLine(p.GetNome());
            Console.WriteLine(p.GetPreco());
        }

    }
}

