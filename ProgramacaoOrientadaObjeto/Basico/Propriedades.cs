using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ProgramacaoOrientadaObjetos.Basico
{
    class Propriedades
    {
        private string _nome;
        private double _preco;
        private int _quantidade;

        public Propriedades()
        {

        }

        public Propriedades(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }
        /// <summary>
        /// Propriedade Nome, Implementação de uma Propertie definindo as 
        /// operações Get e Set.
        /// </summary>
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        /// <summary>
        /// Implementação de Propertie definindo as operações Get e Set
        /// </summary>
      public double Preco
        {
            get { return _preco; }
        }

        /// <summary>
        /// Implementação de Propertie definindo as operações Get e Set
        /// </summary>
        public int Quantidade
        {
            get { return _quantidade; }
        }

        
        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
            + ", $ "
            + _preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + _quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }



}
