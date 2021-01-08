using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Supermarket
{
    [Serializable]
    class Funcionario
    {
        //===============|Declaração de Variáveis|===============
        public string nome;
        public int codFuncionário;
        public string dataNascimento;

        //===============|Construtores|===============
        public Funcionario(string nome, int codFuncionário, string dataNascimento)
        {
            this.nome = nome;
            this.codFuncionário = codFuncionário;
            this.dataNascimento = dataNascimento;
        }

        //===============|Método ToString|===============
        public override string ToString()
        {
            return "| Funcionário: " + nome + " | |Número: " 
                + codFuncionário + " | |Data Nascimento: " 
                + dataNascimento + " |";
        }

       
    }
}
