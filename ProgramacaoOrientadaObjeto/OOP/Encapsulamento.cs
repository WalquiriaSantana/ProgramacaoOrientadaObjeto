﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ProgramacaoOrientadaObjetos.OOP
{
    //Implementação de encapsulamento Manual//
    class Encapsulamento
    {
        private string _nome;
        private double _preco;
        private int _quantidade;
       

        public Encapsulamento()
        {

        }
        public Encapsulamento(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

       
        //encapsulamento da classe acima para que ela não exponha para outro//
        //arquivo algum atributo ou operação que possa prejudicar a integridade do meu produto// 
        public string GetNome()
        {
            return _nome;
        }
        public void SetNome(string nome)
        {
            if (nome != null && nome.Length > 1)
            {
                _nome = nome;
            }
        }
        public double GetPreco()
        {
            return _preco;
        }
        public int GetQuantidade()
        {
            return _quantidade;
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
