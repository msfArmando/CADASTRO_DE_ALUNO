﻿using crud_aluno;
using System;

class program
{
    public static void Main()
    {
        int op;
        bool ciclo = true;
        int ID = 0;
        string nome;
        long cpf;
        int idade;

        Console.WriteLine("Bem-vindo ao cadastro de aluno!");
        Console.WriteLine("-------------------------------");
        Console.WriteLine("1 - Create");
        Console.WriteLine("2 - Read");
        Console.WriteLine("3 - Update");
        Console.WriteLine("4 - Delete");
        Console.WriteLine("6 - Sair");
        Console.WriteLine("-------------------------------");

        List<Aluno> alunosCadastrados = new List<Aluno>();

        while (ciclo)
        {
            Console.WriteLine("O que deseja fazer a seguir?");

            op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.WriteLine("Iniciando cadastro de aluno...");
                    Console.WriteLine("Qual o nome do aluno? ");
                    nome = Console.ReadLine();

                    Console.WriteLine("Quantos anos o aluno tem? ");
                    idade = int.Parse(Console.ReadLine());
                    
                    Console.WriteLine("Digite o CPF do aluno(APENAS NÚMEROS): ");
                    cpf = long.Parse(Console.ReadLine());

                    ID++;

                    Aluno aluno = new Aluno(ID, nome, cpf, idade);

                    alunosCadastrados.Add(aluno);
                    break;
                case 2:
                    Console.WriteLine("Digite o ID do aluno que deseja exibir as informações: ");
                    int idsearch = int.Parse(Console.ReadLine());

                    foreach (Aluno Aluno in alunosCadastrados)
                    {
                        if(Aluno.ID == idsearch)
                        {
                            Console.WriteLine(Aluno.Nome);
                        }
                        else
                        {
                            Console.WriteLine("Loading...");
                        }
                    }

                    break;
                case 3:
                    Console.WriteLine("u");
                    break;
                case 4:
                    Console.WriteLine("d");
                    break;
                case 6:
                    Console.WriteLine("Aplicação finalizada!");
                    ciclo = false;
                    break;
            }
        }
    }
}