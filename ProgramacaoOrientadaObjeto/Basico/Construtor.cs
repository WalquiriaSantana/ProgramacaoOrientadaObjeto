using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ProgramacaoOrientadaObjetos.Basico
{

    /// <summary>
    /// É uma operação especial da classe, que executa no momento da instanciação do objeto
    /// Usos comuns: Iniciar valores dos atributos - Permitir ou obrigar que o objeto receba dados / dependências no momento de sua
    /// instanciação(injeção de dependência)
    /// Se um construtor customizado não for especificado, a classe disponibiliza o construtor padrão:
    /// Construtor p = new Construtor();
    /// É possível especificar mais de um construtor na mesma classe(sobrecarga)
    /// </summary>
    public class Construtor
    {
        public string Nome;
        public double Preco;
        public int Quantidade;
        public Construtor(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return Nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

      

    }
}
