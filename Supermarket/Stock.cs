/*using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace Supermarket
{
    class Stock
    {
        //lista de Produtos
        public List<Stock> listaStock;

        public Stock()
        {
            listaStock = new List<Stock>();
        }

        //============================================================|Guardar Produto|================================================

        #region saveProduto
        public void saveProduto()
        {
            string localizacaoFicheiro = Directory.GetCurrentDirectory();
            string nomeFicheiro = "produtosGuardados.txt";

            //Validação da existencia do ficheiro
            if (File.Exists(nomeFicheiro))
            {
                Console.WriteLine("_______________________________________________________________________");
                Console.WriteLine("|O ficheiro antigo foi apagado e substituido por um Ficheiro atualizado|");
                Console.WriteLine("|______________________________________________________________________|");

                File.Delete(nomeFicheiro);
            }

            //Criacao do ficheiro
            FileStream filestream = File.Create(nomeFicheiro);
            BinaryFormatter binaryFormatter = new BinaryFormatter();

            foreach (Produto produtoASerLido in listaStock)
            {
                binaryFormatter.Serialize(filestream, produtoASerLido);
            }
            binaryFormatter.Serialize(filestream, produtoASerLido);

            filestream.Close();
        }
        #endregion
    }
}*/
