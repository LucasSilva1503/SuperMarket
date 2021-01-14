using System;
using System.Collections.Generic;
using System.Text;

namespace Supermarket
{
    class Gerente : Funcionario
    {
        //Class Filho de Funcionario

        public Gerente(string nome, int codFuncionario, string dataNascimento) : base(nome, codFuncionario, dataNascimento)
        {
            string tipoFuncionario;

        }

        public override string ToString()
        {
            return "|Nome do Funcionario: " + nome + " |Codigo do Funcionario: " + codFuncionario + " |Data de Nascimento: " + dataNascimento + 
                " |Tipo de Funcionario: " + tipoFuncionario;
        }


    }
}
