using System;

namespace Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {

            int escolha = -1;

            Funcionarios staff = new Funcionarios();
            string nomeTemporario, codTemporario, nascTemp;
            int enumTp;

            while (escolha != 0)
            {
                Console.WriteLine("==========|Menu Principal|==========");
                Console.WriteLine("| 1 - Login                        |");
                Console.WriteLine("| 2 - Criar Funcionario            |");
                Console.WriteLine("====================================");

                escolha = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (escolha)
                {
                    case 1:
                        TipoFuncionarios funcionarioSistema = staff.login(Console.ReadLine(), Console.ReadLine());

                        if (funcionarioSistema == TipoFuncionarios.Indefenido)
                        {
                            Console.WriteLine("Falhou");
                        }
                        else Console.WriteLine( "Entrou");
                        break;

                    case 2:
                        nomeTemporario = Console.ReadLine();
                        codTemporario = Console.ReadLine();
                        nascTemp = Console.ReadLine();
                        enumTp = int.Parse(Console.ReadLine());
                        switch (enumTp)
                        {
                            case 1:
                                staff.listaDeFuncionarios.Add(new Funcionario(nomeTemporario, int.Parse(codTemporario), nascTemp, TipoFuncionarios.Repositor));
                                break;
                            case 2:
                                staff.listaDeFuncionarios.Add(new Funcionario(nomeTemporario, int.Parse(codTemporario), nascTemp, TipoFuncionarios.Caixa));
                                break;
                            case 3:
                                staff.listaDeFuncionarios.Add(new Funcionario(nomeTemporario, int.Parse(codTemporario), nascTemp, TipoFuncionarios.Gerente));
                                break;
                        }
                        staff.saveFuncionario();
                        break;
                }
            }




            /*staff.leituraFuncionario();
            Console.WriteLine(staff.listaDeFuncionarios[0]);*/


            /*Funcionario f1 = new Funcionario("Lucas Silva", 1503, "15-03-2000");


            staff.listaDeFuncionarios.Add(f1);

            Console.WriteLine(staff.listaDeFuncionarios[0].codFuncionário);
            Console.WriteLine(staff.listaDeFuncionarios[0].nome);

            staff.saveFuncionario();*/
            staff.leituraFuncionario();


        }
    }
}
