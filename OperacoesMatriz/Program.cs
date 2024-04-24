/*
    Faça um programa que execute as 4 operações básicas entre duas matrizes e armazene em uma nova matriz
 */

Console.WriteLine("=====Manipulando Matrizes=====");

int qntlinhas = 5;
int qntColunas = 5;
Random random = new Random();

int[,] matriz1 = new int[qntlinhas, qntColunas];
int[,] matriz2 = new int[qntlinhas, qntColunas];
int[,] resultado = new int[qntlinhas, qntColunas];


// Criacao das matrizes 1 e 2
for (int l = 0; l < qntlinhas; l++)
{
    for (int c = 0; c < qntColunas; c++)
    {
        matriz1[l, c] = random.Next(1, 10);
        matriz2[l, c] = random.Next(1, 10);
    }
}

Console.WriteLine("Matriz 1:");
for (int l = 0; l < qntlinhas; l++)
{
    for (int c = 0; c < qntColunas; c++)
    {
        Console.Write($"{matriz1[l, c]} ");
    }
    Console.WriteLine();
}
Console.WriteLine("=============================");


Console.WriteLine("Matriz 2:");
for (int l = 0; l < qntlinhas; l++)
{
    for (int c = 0; c < qntColunas; c++)
    {
        Console.Write($"{matriz2[l, c]} ");
    }
    Console.WriteLine();
}
Console.WriteLine("=============================");


// Soma das matrizes
for (int l = 0; l < qntlinhas; l++)
{
    for (int c = 0; c < qntColunas; c++)
    {
        resultado[l, c] = matriz1[l, c] + matriz2[l, c];
    }
}

Console.WriteLine("Soma:");
for (int l = 0; l < qntlinhas; l++)
{
    for (int c = 0; c < qntColunas; c++)
    {
        Console.Write($"{resultado[l, c]} ");
    }
    Console.WriteLine();
}
Console.WriteLine("=============================");


// subtracao das matrizes
for (int l = 0; l < qntlinhas; l++)
{
    for (int c = 0; c < qntColunas; c++)
    {
        resultado[l, c] = matriz1[l, c] - matriz2[l, c];
    }
}

Console.WriteLine("Subtração:");
for (int l = 0; l < qntlinhas; l++)
{
    for (int c = 0; c < qntColunas; c++)
    {
        Console.Write($"{resultado[l, c]} ");
    }
    Console.WriteLine();
}
Console.WriteLine("=============================");


// multiplicacao das matrizes
for (int l = 0; l < qntlinhas; l++)
{
    for (int c = 0; c < qntColunas; c++)
    {
        resultado[l, c] = matriz1[l, c] * matriz2[l, c];
    }
}

Console.WriteLine("Multiplicação:");
for (int l = 0; l < qntlinhas; l++)
{
    for (int c = 0; c < qntColunas; c++)
    {
        Console.Write($"{resultado[l, c]} ");
    }
    Console.WriteLine();
}
Console.WriteLine("=============================");


// divisao das matrizes
for (int l = 0; l < qntlinhas; l++)
{
    for (int c = 0; c < qntColunas; c++)
    {
        resultado[l, c] = matriz1[l, c] / matriz2[l, c];
    }
}

Console.WriteLine("Divisão:");
for (int l = 0; l < qntlinhas; l++)
{
    for (int c = 0; c < qntColunas; c++)
    {
        Console.Write($"{resultado[l, c]} ");
    }
    Console.WriteLine();
}
Console.WriteLine("=============================");


Console.Write("\nDigite qualquer tecla para sair: ");
Console.ReadKey();