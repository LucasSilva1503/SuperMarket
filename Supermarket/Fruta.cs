using System;
using System.Collections.Generic;
using System.Text;

namespace Supermarket
{
    enum TipoDeFruta
    {
        Maca,
        Banana,
        Pessego,
        Ananas,
        Malancia
    }
    class Fruta : Produto
    {
        public TipoDeFruta tFruta;

        #region construtor
        public Fruta(string marca, float preco, bool disponibilidade, int quantidade, bool vegan, TipoDeFruta tFruta) : base(marca, preco, disponibilidade, quantidade, vegan)
        {

            this.Marca = marca;
            this.Preco = preco;
            Disponibilidade = true;
            this.Quantidade = quantidade;
            Vegan = true;
            this.tFruta = tFruta;
        }
        #endregion
    }
}
