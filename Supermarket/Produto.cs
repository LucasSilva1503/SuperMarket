using System;
using System.Collections.Generic;
using System.Text;

namespace Supermarket
{
    class Produto
    {
        private string nome;
        private string marca;
        private float preco;
        private bool disponibilidade;
        private int quantidade;
        private bool vegan;

       
        #region Get e Sets

        public string Nome { get; set; }
        public string Marca { get; set; } 
        public float Preco { get; set; }
        public bool Disponibilidade { get; set; }
        public int Quantidade { get; set; }
        public bool Vegan { get; set; }



        #endregion



        #region Construtor

        public Produto(string nome, string marca, float preco, bool disponibilidade, int quantidade, bool vegan)
        {
            Nome = nome;
            Marca = marca;
            Preco = preco;
            Disponibilidade = disponibilidade;
            Quantidade = quantidade;
            Vegan = vegan;
        }

        #endregion






    }
}
