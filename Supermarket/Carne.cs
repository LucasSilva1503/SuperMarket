using System;
using System.Collections.Generic;
using System.Text;

namespace Supermarket
{
    [Serializable]
    enum TipoDeCarne
    {
       Vaca,
       Coelho,
       Frango
    }
    [Serializable]
    class Carne : Produto
    {
        public TipoDeCarne tCarne;

        #region Construtor

        public Carne(string marca, float preco, bool disponibilidade, int quantidade, bool Vegan, TipoDeCarne tCarne) : base(marca, preco, disponibilidade, quantidade, Vegan)
        {
            
            this.Marca = marca;
            this.Preco = preco;
            Disponibilidade = true;
            this.Quantidade = quantidade;
            Vegan = false;
            this.tCarne = tCarne;
        }

        #endregion


    }
}
