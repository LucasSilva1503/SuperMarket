using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Supermarket
{
    enum TipoFuncionarios
    {
        Gerente, 
        Caixa,
        Repositor, 
        Indefenido
    }

    [Serializable]
    class Funcionario
    {
        //===============|Declaração de Variáveis|===============
        public string nome;
        public int codFuncionario;
        public string dataNascimento;
        public TipoFuncionarios tFuncionarios;

        #region Construtores
        public Funcionario(string nome, int codFuncionario, string dataNascimento, TipoFuncionarios tFuncionarios)
        {
            this.nome = nome;
            this.codFuncionario = codFuncionario;
            this.dataNascimento = dataNascimento;
            this.tFuncionarios = tFuncionarios;
        }
        #endregion

        #region ToString
        public override string ToString()
        {
            return "|Nome do Funcionario: " + nome + " |Codigo do Funcionario: " + codFuncionario + " |Data de Nascimento: " + dataNascimento +
                " |Tipo de Funcionario: " + tFuncionarios;
        }
        #endregion


    }
}
