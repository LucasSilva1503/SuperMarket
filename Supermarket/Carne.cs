using System;
using System.Collections.Generic;
using System.Text;

namespace Supermarket
{
    class Carne : Produto
    {


        #region Construtor

        public Carne(string marca, float preco, bool disponibilidade, int quantidade, bool vegan) : base(marca, preco, disponibilidade, quantidade, vegan)
        {
            
            this.Marca = marca;
            this.Preco = preco;
            Disponibilidade = true;
            this.Quantidade = quantidade;
            Vegan = false;
        }

        #endregion


    }
}
