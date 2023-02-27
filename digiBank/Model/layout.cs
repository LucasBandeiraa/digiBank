using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace digiBank.Model
{
    public class layout
    {
        private static List<Pessoa> pessoas = new List<Pessoa>();
        private static int opc = 0;
        public static void telaPrincipal()
        {
            Console.BackgroundColor= ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Blue;

            Console.Clear();

            Console.WriteLine("                                                                     ");
            Console.WriteLine("                               Digite a opção deseja :               ");
            Console.WriteLine("                               ==========================            ");
            Console.WriteLine("                               1 - Criar Conta                       ");
            Console.WriteLine("                               ==========================            ");
            Console.WriteLine("                               2 - Entrar com CPF e Senha            ");
            Console.WriteLine("                               ==========================            ");

            opc = int.Parse(Console.ReadLine());

            switch(opc)
            {
                case 1:
                    TelaCriarConta();
                    break;
                case 2:
                    telaDeLogin();
                    break;
                default:
                    Console.WriteLine("Opção Inválida! ");
                    break;
            }
        }
        private static void TelaCriarConta()
        {
            Console.Clear();

            Console.WriteLine("                                                                     ");
            Console.WriteLine("                               Digite seu nome :                     ");
            string nome = Console.ReadLine();
            Console.WriteLine("                               ==========================            ");
            Console.WriteLine("                               Digite seu cpf  :                     ");
            string cpf = Console.ReadLine();
            Console.WriteLine("                               ==========================            ");
            Console.WriteLine("                               Digite sua senha :                    ");
            string senha = Console.ReadLine();
            Console.WriteLine("                               ==========================            ");

            ContaCorrente contaCorrente = new ContaCorrente();
            Pessoa pessoa = new Pessoa();

            pessoa.SetNome(nome);
            pessoa.SetCPF(cpf);
            pessoa.SetSenha(senha);
            pessoa.Conta = contaCorrente;

            pessoas.Add(pessoa);

            Console.Clear();
            Console.WriteLine("                            Conta cadastrada com sucesso          ");
            Console.WriteLine("                            ==========================            ");

            Thread.Sleep(1000);

            TelaContaLogada(pessoa);
        }
        private static void telaDeLogin()
        {
            Console.Clear();

            Console.WriteLine("                                                                     ");
            Console.WriteLine("                               Digite o CPF :                        ");
            string cpf = Console.ReadLine();
            Console.WriteLine("                               ==========================            ");
            Console.WriteLine("                               Digite sua senha                      ");
            string senha = Console.ReadLine();
            Console.WriteLine("                               ==========================            ");

            Pessoa pessoa = pessoas.FirstOrDefault(x => x.CPF == cpf && x.Senha == senha);

            if(pessoa != null)
            {
                TelaDeBoasVindas(pessoa);
                TelaContaLogada(pessoa);
            }
            else
            {
                Console.Clear();

                Console.WriteLine(                                "Pessoas não cadastrada"               );
                Console.WriteLine("                               ==========================            ");

                Console.WriteLine();
                Console.WriteLine();
            }
        }
        private static void TelaDeBoasVindas(Pessoa pessoa)
        {
            Console.WriteLine("");
            Console.WriteLine($"Seja Bem Vindo {pessoa.Nome}");
            Console.WriteLine("");
        }
        private static void TelaContaLogada(Pessoa pessoa)
        {
            Console.Clear();

            TelaDeBoasVindas(pessoa);

            Console.WriteLine("                             Digite a opção desejada                      ");
            Console.WriteLine("                             ==========================                   ");
            Console.WriteLine("                             1 - Realizar um deposito                     ");
            Console.WriteLine("                             ==========================                   ");
            Console.WriteLine("                             2 - Realizar um saque                        ");
            Console.WriteLine("                             ==========================                   ");
            Console.WriteLine("                             3 - Consultar Saldo                          ");
            Console.WriteLine("                             ==========================                   ");
            Console.WriteLine("                             4 - Extrato                                  ");
            Console.WriteLine("                             ==========================                   ");
            Console.WriteLine("                             5 - Sair                                     ");
            Console.WriteLine("                             ==========================                   ");

            opc = int.Parse(Console.ReadLine());

            switch(opc)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    telaPrincipal();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("                             Opção Inválida                               ");
                    Console.WriteLine("                             ==========================                   ");
                    break;
            }
        }
        
    }
}
