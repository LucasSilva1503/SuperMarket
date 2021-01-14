using System;

namespace Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionarios staff = new Funcionarios();

            /*Funcionario f1 = new Funcionario("Lucas Silva", 1503, "15-03-2000");


            staff.listaDeFuncionarios.Add(f1);

            Console.WriteLine(staff.listaDeFuncionarios[0].codFuncionário);
            Console.WriteLine(staff.listaDeFuncionarios[0].nome);

            staff.saveFuncionario();*/
            staff.leituraFuncionario();


        }
    }
}
