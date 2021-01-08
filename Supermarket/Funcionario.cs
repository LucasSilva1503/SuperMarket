using System;
using System.Collections.Generic;
using System.Text;

namespace Supermarket
{
    class Funcionario
    {
        public string nome;
        public int codFuncionário;
        public string dataNascimento;

        public Funcionario(string nome, int codFuncionário, string dataNascimento)
        {
            this.nome = nome;
            this.codFuncionário = codFuncionário;
            this.dataNascimento = dataNascimento;
        }

        public override string ToString()
        {
            return "| Funcionário: " + nome + " | |Número: " 
                + codFuncionário + " | |Data Nascimento: " 
                + dataNascimento + " |";
        }
    }
}
