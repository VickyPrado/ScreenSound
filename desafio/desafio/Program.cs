﻿//Criar uma variável chamada notaMedia e atribua um valor inteiro a ela. Caso seu valor seja maior
//ou igual a 5, escreva na tela "Nota suficiente para aprovação".

do
{
    Console.Write("Digite sua nota: ");
    int media = int.Parse(Console.ReadLine());
    if (media >= 5)
    {
        Console.WriteLine("Nota suficiente para aprovação");
        break;
    } else {
        Console.WriteLine("Nota insuficiente");
        break;
    }
} while (true);




//Criar uma lista de linguagens de programação, com as linguagens C#, Java e JavaScript.

List<string> linguagens = { "C#", "Java", "JavaScript" };




//Exibir o valor "C#" no console, utilizando a lista criada no exercício anterior.

Console.WriteLine(linguagens[0]);



//Criar um programa que, dado a entrada de dados de um número n inteiro, a partir do teclado, exibir a n-ésima posição de uma lista.

int posicao = int(Console.read());
Console.WriteLine(lista[posicao]);