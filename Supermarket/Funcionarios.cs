using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace Supermarket
{
    class Funcionarios
    {
        public List<Funcionario> listaDeFuncionarios;

        public Funcionarios()
        {
            listaDeFuncionarios = new List<Funcionario>();
        }

        //===============|Guardar Funcionário em Ficheiro|===============
        public void saveFuncionario()
        {
            string localizacaoFicheiro = Directory.GetCurrentDirectory();
            string nomeFicheiro = "funcionariosGuardados.txt";

            //Validação da existencia do ficheiro
            if (File.Exists(nomeFicheiro))
            {
                Console.WriteLine("_______________________________________________________________________");
                Console.WriteLine("|O ficheiro antigo foi apagado e substituido por um Ficheiro atualizado|");
                Console.WriteLine("|______________________________________________________________________|");

                File.Delete(nomeFicheiro);
            }

            FileStream filestream = File.Create(nomeFicheiro);
            BinaryFormatter binnaryFormatter = new BinaryFormatter();



        }
    }
}
