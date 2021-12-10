using System;
using System.Collections.Generic;

namespace DNDIO
{
    class Program
    {
        public static List<Aluno> _allAlunos = new List<Aluno>();
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
                Console.WriteLine("Erro, tente novamente");
            }
            else
            {
                Console.WriteLine();
            }

            Console.WriteLine("Informe a Opção Desejada!!");
            Console.WriteLine();
            Console.WriteLine("1) Inserir novo aluno");
            Console.WriteLine("2) Listar alunos");
            Console.WriteLine("3) Calcular média geral");
            Console.WriteLine("X) Sair");
            Console.WriteLine();

            _result = Console.ReadLine();

            ShowResult();
        }

        static void ShowResult()
        {
            switch (_result.ToUpper())
            {
                case "1":
                    InsereAluno();
                    break;
                case "2":
                    ListaAluno();
                    break;
                case "3":
                    MediaGeral();
                    break;
                case "X":
                    break;
                default:
                    GetResult(2);
                    break;
            }
        }

        static void InsereAluno()
        {
            Console.Clear();

            Aluno _aluno = new Aluno();

            Console.WriteLine("Informe o Nome do Aluno");
            Console.WriteLine();
            _aluno.Nome = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Informe a Nota do Aluno");

            if (float.TryParse(Console.ReadLine(), out float _nota))
            {
                _aluno.Note = _nota;                
            }

            _allAlunos.Add(_aluno);

            Console.Clear();
            Console.WriteLine("Aluno Adicionado!!");
            GetResult(0);
        }

        static void ListaAluno()
        {
            if (_allAlunos.Count > 0)
            {
                Console.Clear();
                
                foreach (Aluno _a in _allAlunos)
                {
                    Console.WriteLine($"Aluno: {_a.Nome}, Nota: {_a.Note.ToString("F2")}");
                }

                GetResult(0);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Ainda não tem alunos cadastrados!!");
                GetResult(0);
            }
        }

        static void MediaGeral()
        {
            if (_allAlunos.Count > 0)
            {
                Console.Clear();
                float _temp = 0;
                
                foreach (Aluno _a in _allAlunos)
                {
                    _temp += _a.Note;
                }

                float _media = _temp/_allAlunos.Count;
                Console.WriteLine($"A média geral é: {_media.ToString("F2")}");

                GetResult(0);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Ainda não tem alunos cadastrados!!");
                GetResult(0);
            }
        }
    }
}