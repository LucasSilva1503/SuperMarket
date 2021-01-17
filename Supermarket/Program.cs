﻿using System;

namespace Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {

            int escolha = -1;
            int escolhaGerente = -1;

            Funcionarios staff = new Funcionarios();
            string nomeTemporario, codTemporario, nascTemp;
            int enumTp;


            while (escolha != 0)
            {
                Console.WriteLine("==========|Menu Principal|==========");
                Console.WriteLine("| 1 - Login                        |");
                Console.WriteLine("| 2 - Criar Funcionario            |");
                Console.WriteLine("| 0 - Sair                         |");
                Console.WriteLine("|__________________________________|");
                Console.WriteLine("|Opcao: ");

                escolha = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (escolha)
                {
                    //============================================================|Fazer Login|============================================
                    case 1:
                        TipoFuncionarios funcionarioSistema = staff.login(Console.ReadLine(), Console.ReadLine());

                        if (funcionarioSistema == TipoFuncionarios.Indefenido)
                        {
                            Console.WriteLine("================================================================");
                            Console.WriteLine("|Usuário ou Password esta incorreto, por favor tente novamente.|");
                            Console.WriteLine("|______________________________________________________________|");
                        }
                        else if (funcionarioSistema == TipoFuncionarios.Gerente)
                        {
                            while (escolhaGerente != 0)
                            {
                                Console.WriteLine("=========================================");
                                Console.WriteLine("|Seja bem-vindo, fez login como Gerente.|");
                                Console.WriteLine("| 1 - Ver todos os Funcionarios         |");
                                Console.WriteLine("| 2 - Apagar Funcionario                |");
                                Console.WriteLine("| 3 - Efetuar uma venda                 |");
                                Console.WriteLine("| 0 - Sair                              |");
                                Console.WriteLine("|_______________________________________|");
                                Console.WriteLine("|Opcao: ");

                                escolhaGerente = int.Parse(Console.ReadLine());

                                Console.Clear();

                                switch (escolhaGerente)
                                {
                                    case 1://=========================|Ver todos os funcionarios|=========================
                                        Console.WriteLine("|= Ver todos os Funcionarios =|");
                                        Console.WriteLine("_______________________________");
                                        Console.WriteLine(staff.ToString());

                                        break;
                                    
                                    case 2://=========================|Apagar um funcionario|=========================

                                        Console.Write("Indique o funcionario que quer apagar: ");
                                        string funcionarioAApagar = Console.ReadLine();
                                        bool resultado = staff.apagarFuncionario(funcionarioAApagar);

                                        if (resultado)
                                        {
                                            Console.WriteLine("===================================");
                                            Console.WriteLine("|Funcionario apagado com sucesso! |");
                                            Console.WriteLine("|_________________________________|");
                                        }
                                        else
                                        {
                                            Console.WriteLine("===============================================");
                                            Console.WriteLine("|Algo correu mal, por favor tentar novamente! |");
                                            Console.WriteLine("|_____________________________________________|");
                                        }

                                        break;
                                }

                            }

                        }//=========================|fim if Gerente|=========================
                        else if (funcionarioSistema == TipoFuncionarios.Caixa)
                        {

                        }
                        else if (funcionarioSistema == TipoFuncionarios.Repositor)
                        {

                        }
                        else
                        {
                            Console.WriteLine("==========================================================");
                            Console.WriteLine("|Algo inesperado aconteceu, por favor contacte o suporte.|");
                            Console.WriteLine("|________________________________________________________|");
                        }




                        break;
                    //==============================================================|Fim Case 1|==============================================================
                    case 2:
                        Console.Write("Introduzir Nome do Funcionario: ");
                        nomeTemporario = Console.ReadLine();

                        Console.Write("Introduzir Codigo do Funcionario: ");
                        codTemporario = Console.ReadLine();

                        Console.Write("Introduzir Data de Nascimento do Funcionario: ");
                        nascTemp = Console.ReadLine();

                        Console.WriteLine("|1 - Gerente |2 - Caixa |3 - Repositor| ");
                        Console.Write("Introduzir Cargo do Funcionario: ");
                        enumTp = int.Parse(Console.ReadLine());

                        switch (enumTp)
                        {
                            case 1:
                                staff.listaDeFuncionarios.Add(new Funcionario(nomeTemporario, int.Parse(codTemporario), nascTemp, TipoFuncionarios.Gerente));
                                break;
                            case 2:
                                staff.listaDeFuncionarios.Add(new Funcionario(nomeTemporario, int.Parse(codTemporario), nascTemp, TipoFuncionarios.Caixa));
                                break;
                            case 3:
                                staff.listaDeFuncionarios.Add(new Funcionario(nomeTemporario, int.Parse(codTemporario), nascTemp, TipoFuncionarios.Repositor));
                                break;
                        }
                        staff.saveFuncionario();
                        break;

                    case 15: //Opcao "secreta" para ver lista de Funcionarios sem ser gerente, shhhh
                        Console.WriteLine(staff.ToString());
                        break;
                }
            }
        }
    }
}
