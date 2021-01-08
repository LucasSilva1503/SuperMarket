using System;

namespace Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionarios staff = new Funcionarios();

            Funcionario f1 = new Funcionario("Lucas Silva", 1503, "15-03-2000");
            Funcionario f2 = new Funcionario("Juliana Cruz", 1504, "02-05-2002");

            staff.listaDeFuncionarios.Add(f1);

            //staff.saveFuncionario();
            staff.leituraFuncionario();


        }
    }
}
