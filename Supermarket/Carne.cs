using System;
using System.Collections.Generic;
using System.Text;

namespace Supermarket
{
    class Carne : Produto
    {

        string tipoCarne;
        //era top ter uma varieavel tipo 1- congelado, 2- outra coisa 


        #region Construtor

        public Carne( string tipoCarne, string marca, float preco, bool disponibilidade, int quantidade, bool vegan) : base(marca, preco, disponibilidade, quantidade, vegan)
        {
            this.tipoCarne = tipoCarne;
            this.Marca = marca;
            this.Preco = preco;
            Disponibilidade = true;
            this.Quantidade = quantidade;
            Vegan = false;
        }

        #endregion


    }
}
