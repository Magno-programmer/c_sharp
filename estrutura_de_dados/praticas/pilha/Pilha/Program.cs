using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Pilha
{
    internal class Program
    {
        static void Main()
        {
            /*A string vai receber o valor numérico
              para tratar erro do usuário digitar letra
              espaço ou somente pressionar enter*/
            string tamanhoPilha;
            string numerico;
            
            //Variáveis para receber os valores das strings
            int numero;
            int tamanhoPilhaNumerico;

            // Mostra a quantia de espaços restantes na pilha
            int numeroDeEspaços;

            //Variável booleana para while da pilha
            bool validar = true;        

            //Ditando o tamanho da pilha
            Console.Write("Primeiro digite o tamanho da pilha que deseja usar: ");
            tamanhoPilha = Console.ReadLine();

            while (!tamanhoPilha.All(char.IsDigit) || tamanhoPilha == " " || tamanhoPilha == "")
            {
                // Looping para tratar erro de caracter inesperado
                Console.Clear();
                Console.Write("Por favor digite um valor numérico para ser o tamanho da pilha: ");
                tamanhoPilha = Console.ReadLine();
            }

            tamanhoPilhaNumerico = int.Parse(tamanhoPilha);
            Pilha p = new Pilha(tamanhoPilhaNumerico);
            Console.Clear();

            numeroDeEspaços = tamanhoPilhaNumerico;
            Console.WriteLine($"Você tem {numeroDeEspaços} de {tamanhoPilhaNumerico} espaços na sua pilha!");
            while (validar)
            {
                Opcoes();
                numerico = Console.ReadLine();

                while(!numerico.All(char.IsDigit) || numerico == " " || numerico == "")
                {
                    // Looping para tratar erro de caracter inesperado
                    Console.Clear();
                    Console.WriteLine("Linha de comando não encontrada.\nPor favor, digite uma das opções abaixo: \n");
                    Opcoes();
                    numerico = Console.ReadLine();
                }

                numero = int.Parse(numerico);
                
                if(numero >= 0 && numero <= 3)
                {
                    
                    // Empilhar valor se não tiver cheia
                    if (numero == 1)
                    {
                        if (!p.Cheia())
                        {
                            Console.Clear();
                            int ValorEmpilhar;
                            Console.WriteLine("Digite o valor a ser empilhado: ");
                            ValorEmpilhar = Convert.ToInt32(Console.ReadLine());
                            p.Empilhar(ValorEmpilhar);

                            Console.Clear();
                            Console.WriteLine($"Você empilhou o valor {p.Desempilhar()}!");
                            p.Empilhar(ValorEmpilhar);

                            Console.WriteLine($"Você tem {numeroDeEspaços = numeroDeEspaços-1} de {tamanhoPilhaNumerico} espaços na sua pilha!");
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine($"Você tem {numeroDeEspaços} de {tamanhoPilhaNumerico} espaços na sua pilha!");
                            Console.WriteLine("Desempilhe um valor para empilhar novamente!");
                        }
                    }
                    else if (numero == 2) //Desempilha um único valor e mostra na tela
                    {
                        if (p.Vazia())
                        {
                            Console.Clear();
                            Console.WriteLine($"Você tem {numeroDeEspaços} de {tamanhoPilhaNumerico} espaços na sua pilha!");
                            Console.WriteLine("Por favor, coloque um valor!");
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine($"Você desempilhou o valor {p.Desempilhar()} !");
                            Console.Write("\n\nPressione qualquer tecla para continuar...");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine($"Você tem {numeroDeEspaços = numeroDeEspaços+1} de {tamanhoPilhaNumerico} espaços na sua pilha!");
                        }

                    }
                    else if (numero == 3) //Desempilha e imprime todos valores
                    {
                        if (!p.Cheia())
                        {
                            Console.Clear();
                            Console.WriteLine("Desempilhar Tudo: ");
                            for (int i = 0; i < tamanhoPilhaNumerico - numeroDeEspaços; i++)
                            {
                                Console.WriteLine(p.Desempilhar());
                            }
                            Console.WriteLine($"\n***Você imprimiu todos os {numeroDeEspaços = tamanhoPilhaNumerico - numeroDeEspaços} valores empilhados!***");
                            Console.Write("\n\nPressione qualquer tecla para continuar...");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine($"Você tem {numeroDeEspaços = tamanhoPilhaNumerico} de {tamanhoPilhaNumerico} espaços na sua pilha!");
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Desempilhar Tudo: ");
                            for (int i = 0; i < tamanhoPilhaNumerico; i++)
                            {
                                Console.WriteLine(p.Desempilhar());
                            }
                            Console.WriteLine("\n***Você imprimiu todos os valores empilhados!***");
                            Console.Write("\n\nPressione qualquer tecla para continuar...");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine($"Você tem {numeroDeEspaços = tamanhoPilhaNumerico} de {tamanhoPilhaNumerico} espaços na sua pilha!");
                        }

                    }
                    else if (numero == 0) //Sai do programa
                    {
                        Console.Clear();
                        Console.WriteLine("Você finalizou o programa!");
                        validar = false;
                    }

                }else
                {
                    Console.Clear();
                    Console.WriteLine("Opção inválida/Inexistente!");
                }

            }
            Console.WriteLine("\n\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }

        static void Opcoes()
        {
            Console.WriteLine("Escolha uma opção: \n");
            Console.WriteLine("1 - Empilhar");
            Console.WriteLine("2 - Desempilhar e Imprimir um valor");
            Console.WriteLine("3 - Desempilhar e Imprimir tudo");
            Console.WriteLine("0 - Sair");
            Console.Write("Digite aqui: ");
        }

    }
}
