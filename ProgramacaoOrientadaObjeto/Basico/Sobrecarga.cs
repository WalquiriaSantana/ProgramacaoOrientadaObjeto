using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ProgramacaoOrientadaObjetos.Basico
{

    /// <summary>
    /// É um recurso que uma classe possui de oferecer mais de uma 
    /// operação com o mesmo nome, porém com diferentes listas de parâmetros.
    /// </summary>
    public class Sobrecarga
    {

        public string Nome;
        public double Preco;
        public int Quantidade;

        //sobrecarga da classe para ser utilizada como construtor padrão//
        public Sobrecarga()
        {

        }
        public Sobrecarga(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        // Por padrão os atributos numéricos já recebem o valor zero //
        // logo, a linha 28 é dispensável//
        public Sobrecarga(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = 0;
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
