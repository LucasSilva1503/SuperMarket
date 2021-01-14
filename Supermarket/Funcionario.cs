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
        Repositor
    }

    [Serializable]
    class Funcionario
    {
        //===============|Declaração de Variáveis|===============
        public string nome;
        public int codFuncionario;
        public string dataNascimento;

        #region Construtores
        public Funcionario(string nome, int codFuncionario, string dataNascimento)
        {
            this.nome = nome;
            this.codFuncionario = codFuncionario;
            this.dataNascimento = dataNascimento;
        }
        #endregion

        #region Metodo ToString
        
        public override string ToString()
        {
            return "| Funcionário: " + nome + " | |Número: " 
                + codFuncionario + " | |Data Nascimento: " 
                + dataNascimento + " |";
        }
        #endregion

    }
}
