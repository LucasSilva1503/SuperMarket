using System;
using System.Collections.Generic;
using System.Text;

namespace Supermarket
{
    class Fruta : Produto
    {
        #region construtor
        public Fruta(string marca, float preco, bool disponibilidade, int quantidade, bool vegan) : base(marca, preco, disponibilidade, quantidade, vegan)
        {

            this.Marca = marca;
            this.Preco = preco;
            Disponibilidade = true;
            this.Quantidade = quantidade;
            Vegan = true;

            
        }
        #endregion
    }
}
