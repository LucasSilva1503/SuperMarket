﻿using System;
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
            BinaryFormatter binaryFormatter = new BinaryFormatter();

            foreach (Funcionario funcionarioASerLido in listaDeFuncionarios)
            {
                binaryFormatter.Serialize(filestream, funcionarioASerLido);
            }
            binaryFormatter.Serialize(filestream, listaDeFuncionarios);

            filestream.Close();

        }

        //===============|Leitura de Funcionário Ficheiro|===============
        public void leituraFuncionario()
        {
            string nomeFicheiro = "funcionariosGuardados.txt";

            if (File.Exists(nomeFicheiro))
            {
                FileStream fileStream = File.OpenRead(nomeFicheiro);
                BinaryFormatter binaryFormatter = new BinaryFormatter();


                while (fileStream.Position < fileStream.Length)
                {
                    Funcionario funcionarioLido = binaryFormatter.Deserialize(fileStream) as Funcionario;
                    listaDeFuncionarios.Add(funcionarioLido);
                }

                fileStream.Close();
            }
            else
            {
                Console.WriteLine("__________________________________________________________");
                Console.WriteLine("|O ficheiro não foi encontrado, por favor crie um ficheiro|");
                Console.WriteLine("|_________________________________________________________|");
            }
        }
    }
}
