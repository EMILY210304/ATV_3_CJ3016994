using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATV_3_CJ3016994
{
    internal class Program
    {
        static void Main(string[] args)
        }
    //ex1
    //     Console.WriteLine("Por favor, digite um número:");

    //string input = Console.ReadLine();
    //int numero = int.Parse(input);

    //if (numero % 2 == 0)
    //{
    //    Console.WriteLine($"O número {numero} é par.");
    //}
    //else
    //{
    //    Console.WriteLine($"O número {numero} é ímpar.");
    //        Console.ReadKey();
    //}
    //{ 
    //ex2
    //        Console.WriteLine("Por favor, digite o comprimento do primeiro lado do triângulo:");
    //        double lado1 = double.Parse(Console.ReadLine());

    //        Console.WriteLine("Por favor, digite o comprimento do segundo lado do triângulo:");
    //        double lado2 = double.Parse(Console.ReadLine());

    //        Console.WriteLine("Por favor, digite o comprimento do terceiro lado do triângulo:");
    //        double lado3 = double.Parse(Console.ReadLine());

    //        if (VerificarTriangulo(lado1, lado2, lado3))
    //        {

    //            if (lado1 == lado2 && lado2 == lado3)
    //            {
    //                Console.WriteLine("É um triângulo equilátero (três lados iguais).");
    //            }
    //            else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
    //            {
    //                Console.WriteLine("É um triângulo isósceles (dois lados iguais).");
    //            }
    //            else
    //{ }
    //    Console.WriteLine("É um triângulo escaleno (três lados diferentes).");

    //        else

    //        Console.WriteLine("Não é possível formar um triângulo com os comprimentos dos lados fornecidos.");
    //        Console.ReadKey();

    //ex3
    //        Random random = new Random();
    //        int numeroAleatorio = random.Next(1, 101);

    //        Console.WriteLine("Bem-vindo ao jogo de adivinhação!");
    //        Console.WriteLine("Tente adivinhar o número entre 1 e 100. Você tem 3 chances.");

    //        for (int tentativa = 1; tentativa <= 3; tentativa++)
    //        {
    //            Console.Write($"\nTentativa {tentativa}: Digite sua suposição: ");
    //            int suposicao = int.Parse(Console.ReadLine());

    //            if (suposicao == numeroAleatorio)
    //            {
    //                Console.WriteLine("Parabéns! Você adivinhou o número corretamente!");
    //                return; 
    //            }
    //            else if (suposicao<numeroAleatorio)
    //            {
    //                Console.WriteLine("O número que você digitou é menor.");
    //            }
    //            else
    //{
    //    Console.WriteLine("O número que você digitou é maior.");

    //}

    //        Console.WriteLine("\nSuas tentativas acabaram. O número correto era: " + numeroAleatorio);
    //       Console.ReadKey();
    //ex4
    //       Console.WriteLine("Sistema de Autenticação");

    //        Console.Write("Nome de usuário: ");
    //        string nomeUsuario = Console.ReadLine();

    //    Console.Write("Senha: ");
    //        string senha = Console.ReadLine();

    //        if (nomeUsuario == "admin" && senha == "admin123")
    //        {
    //            Console.WriteLine("Acesso concedido");
    //        }
    //        else
    //{
    //    Console.WriteLine("Acesso negado");
    //    Console.ReadKey();
    //}
    //    }
    //ex5
    //    Console.WriteLine("Conversão de nota para conceito");

    //        Console.Write("Digite a nota (0-100): ");
    //        int nota = int.Parse(Console.ReadLine());

    //    char conceito;

    //        if (nota >= 90)
    //            conceito = 'A';
    //        else if (nota >= 80)
    //            conceito = 'B';
    //        else if (nota >= 70)
    //            conceito = 'C';
    //        else if (nota >= 60)
    //            conceito = 'D';
    //        else
    //            conceito = 'F';

    //        Console.WriteLine($"Conceito: {conceito}");
    //Console.Readkey();
    //    }
    //}
    //ex6
    //    Console.WriteLine("Jogo Pedra, Papel ou Tesoura");

    //        string[] opcoes = { "Pedra", "Papel", "Tesoura" };

    //    Random random = new Random();
    //    int indiceComputador = random.Next(0, 3);
    //    string escolhaComputador = opcoes[indiceComputador];

    //    Console.Write("Escolha (Pedra, Papel ou Tesoura): ");
    //        string escolhaUsuario = Console.ReadLine();

    //    Console.WriteLine($"Computador escolheu: {escolhaComputador}");

    //        if (escolhaUsuario == escolhaComputador)
    //        {
    //            Console.WriteLine("Empate!");
    //        }
    //        else if ((escolhaUsuario == "Pedra" && escolhaComputador == "Tesoura") ||
    //                 (escolhaUsuario == "Papel" && escolhaComputador == "Pedra") ||
    //                 (escolhaUsuario == "Tesoura" && escolhaComputador == "Papel"))
    //{
    //    Console.WriteLine("Você venceu!");
    //}
    //else
    //{
    //    Console.WriteLine("Computador venceu!");
    //    Console.ReadKey();
    //}
    //    }
    //ex7
    //    Console.WriteLine("Calculadora de descontos");

    //        Console.Write("Valor total da compra: ");
    //        double valorTotal = double.Parse(Console.ReadLine());

    //    double desconto = 0;

    //        if (valorTotal > 100)
    //        {
    //            desconto = 0.1;
    //        }
    //        else if (valorTotal > 200)
    //{
    //    desconto = 0.2;
    //}
    //// Adicione mais condições conforme necessário para descontos adicionais

    //double valorComDesconto = valorTotal * (1 - desconto);
    //Console.WriteLine($"Valor com desconto: {valorComDesconto:C}");
    //Console.ReadKey();
    //    }

    //ex8
    //Console.WriteLine("Calculadora de IMC");

    //    Console.Write("Digite o peso (kg): ");
    //    double peso = double.Parse(Console.ReadLine());

    //Console.Write("Digite a altura (m): ");
    //    double altura = double.Parse(Console.ReadLine());

    //double imc = peso / (altura * altura);
    //Console.WriteLine($"Seu IMC é: {imc:F1}");

    //    string categoria;

    //    if (imc< 18.5)
    //    {
    //        categoria = "Abaixo do peso";
    //    Console.Radkey();