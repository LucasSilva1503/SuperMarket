using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;


namespace Supermarket
{
    [Serializable]
    class Stock
    {
        //lista de Produtos
        public List<Peixe> listaPeixes;
        public List<Carne> listaCarne;
        public List<Fruta> listaFruta;

        public Stock()
        {
            listaPeixes= new List<Peixe>();
            listaCarne = new List<Carne>();
            listaFruta = new List<Fruta>();
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

            
            binaryFormatter.Serialize(filestream, this);

            filestream.Close();
        }
        #endregion


        static public Stock leituraProdutos()
        {
            string nomeFicheiro = "produtosGuardados.txt";
            Stock s = new Stock();

            if (File.Exists(nomeFicheiro))
            {
                FileStream fileStream = File.OpenRead(nomeFicheiro);
                BinaryFormatter binaryFormatter = new BinaryFormatter();


                s = binaryFormatter.Deserialize(fileStream) as Stock;

                return s;

                fileStream.Close();
            }
            else
            {
                Console.WriteLine("__________________________________________________________");
                Console.WriteLine("|O ficheiro não foi encontrado, por favor crie um ficheiro|");
                Console.WriteLine("|_________________________________________________________|");
                return null;

            }


        }

        public bool apagarLista(string nome)
        {
            
            }

            return false;

        }

        public override string ToString()
        {
            string result = "";
            foreach(Stock st in Stock())
            {
                //string marca, float preco, bool disponibilidade, int quantidade, bool Vegan, TipoDeCarne tCarne
                result += "|Marca: " + st.
            }
            return base.ToString();
        }
    }
}
