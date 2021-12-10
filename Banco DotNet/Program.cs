using System;
using System.Collections.Generic;

namespace BancoDN
{
    class Program
    {
        static List<Account> _allAccounts = new List<Account>();
        public static string _result;

        static void Main(string[] args)
        {
            GetResult(1);
        }

        static void GetResult(int _num)
        {
            if (_num == 1)
            {
                Console.Clear();                
            }
            else if (_num == 2)
            {
                Console.Clear();
                Msg("Erro, tente novamente");
            }
            else
            {
                Console.WriteLine();
            }

            Msg(1, "Bem vindo ao Banco DIO!!");
            Msg(1, "Informe a Opção Desejada!!");
            Msg("1) Inserir nova Conta");
            Msg("2) Listar Contas");
            Msg("3) Sacar");
            Msg("4) Depositar");
            Msg("5) Transferir");
            Msg(1, "X) Sair");

            _result = Console.ReadLine();

            ShowResult();
        }

        static void ShowResult()
        {
            switch (_result.ToUpper())
            {
                case "1":
                    CreateAccount();
                break;
                case "2":
                    ListAccount();
                break;
                case "3":
                    Draw();
                break;
                case "4":
                    Deposit();
                break;
                case "5":
                    Transfer();
                break;
                case "X":
                break;
                default:
                    GetResult(2);
                break;
            }
        }

        static void Msg(string _msg)
        {
            Console.WriteLine(_msg);
        }

        static void Msg(int _id, string _msg)
        {
            if (_id == 0)
            {
                Console.Clear();
                Console.Clear();
                Console.WriteLine(_msg);                
                Console.WriteLine();
            }
            else if (_id == 1)
            {
                Console.WriteLine(_msg);                
                Console.WriteLine();
            }
            else if (_id == 2)
            {
                Console.WriteLine();
                Console.WriteLine(_msg);
                Console.WriteLine();
            }
        }

        static void CreateAccount()
        {
            Msg(0, "- Criando nova Conta -");
            Msg(1, "Digite o nome do Cliente");
            string _name = Console.ReadLine();

            Msg(2, "Digite 1 para Conta Poupança e 2 para Conta Corrente");
            int _type = int.Parse(Console.ReadLine());

            Msg(2, "Digite o saldo da Conta");
            double _money = double.Parse(Console.ReadLine());
            
            Account _account = new Account(_allAccounts.Count + 1, (TypeA)_type, _money, 0, _name);
            _allAccounts.Add(_account);

            Msg(0, "Conta Cadastrada!!");
            GetResult(0);
        }

        static void ListAccount()
        {
            if (_allAccounts.Count > 0)
            {
                Console.Clear();
                
                foreach (Account _a in _allAccounts)
                {
                    Console.WriteLine(_a);
                }

                GetResult(0);
            }
            else
            {
                Msg(0, "Ainda não tem contas cadastradas!!");
                GetResult(0);
            }
        }

        static void Draw()
        {
            if (_allAccounts.Count > 0)
            {
                Msg(0, "Digite o número da Conta");
                int _id = int.Parse(Console.ReadLine());

                Msg(2, "Digite o valor a ser sacado");
                double _value = double.Parse(Console.ReadLine());

                Msg(2, _allAccounts[_id].Draw(_value));
                GetResult(0);
            }
            else
            {
                Msg(0, "Ainda não tem contas cadastradas!!");
                GetResult(0);
            }
        }

        static void Deposit()
        {
            if (_allAccounts.Count > 0)
            {
                Msg(0, "Digite o número da Conta");
                int _id = int.Parse(Console.ReadLine());

                Msg(2, "Digite o valor a ser depositado");
                double _value = double.Parse(Console.ReadLine());

                if (_allAccounts.Count > _id && _allAccounts.Count > _id2)
                {
                    Msg(0, _allAccounts[_id].Deposit(_value));
                    GetResult(0);                                       
                }
                else
                {
                    Msg(0, "Erro tente novamente!!");
                    Deposit();
                }
            }
            else
            {
                Msg(0, "Ainda não tem contas cadastradas!!");
                GetResult(0);
            }
        }

        static void Transfer()
        {
            if (_allAccounts.Count > 0)
            {
                Msg(0, "Digite o número da Conta");
                int _id = int.Parse(Console.ReadLine());

                Msg(2, "Digite o número da Conta para Transferir");
                int _id2 = int.Parse(Console.ReadLine());

                Msg(2, "Digite o valor a ser depositado");
                double _value = double.Parse(Console.ReadLine());

                if (_allAccounts.Count > _id && _allAccounts.Count > _id2)
                {
                    Msg(0, _allAccounts[_id].Transfer(_value, _allAccounts[_id2]));
                    GetResult(0);                    
                }
                else
                {
                    Msg(0, "Erro tente novamente!!");
                    Transfer();
                }
            }
            else
            {
                Msg(0, "Ainda não tem contas cadastradas!!");
                GetResult(0);
            }
        }
    }
}