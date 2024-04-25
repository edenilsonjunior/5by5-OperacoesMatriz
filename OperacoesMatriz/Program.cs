/*
    Faça um programa que execute as 4 operações básicas entre duas matrizes e armazene em uma nova matriz

    **UPDATE**
    Implemente no programa as seguintes funcoes:
    A) Menu de selecao que retorna a operacao escolhida pelo usuario
    B) Funcao que popula a matriz atraves de sorteio
    C) Funcao que vai informar o tamanho da criacao da minha matriz(passar dois parametros int, linha e coluna)
 */

/*Functions*/

int Menu()
{
    int option;
    do
    {
        PrintLine();
        Console.WriteLine("Enter your operation option");
        Console.WriteLine("1- Addition");
        Console.WriteLine("2- Subtraction");
        Console.WriteLine("3- Multiplication");
        Console.WriteLine("4- Division");
        Console.WriteLine("5- Exit");
        Console.Write("Your choice: ");
        option = int.Parse(Console.ReadLine());

    } while (option < 0 || option > 4);

    return option;
}

void SortMatrix(float[,] matrix, int lines, int columns)
{
    Random random = new();

    for(int l = 0; l < lines; l++)
    {
        for(int c = 0; c < columns; c++)
        {
            matrix[l, c] = random.Next(1, 10);
        }
    }
}

void PrintMatrix(float[,] matrix, int lines, int columns, string title)
{
    PrintLine();
    Console.WriteLine(title);
    for (int l = 0; l < lines; l++)
    {
        for (int c = 0; c < columns; c++)
        {
            Console.Write($"{matrix[l, c]} ");
        }
        Console.WriteLine();
    }
}

void DoOperations(float[,] m1, float[,] m2, int lines, int columns, int option)
{
    float[,] result = CreateMatrix(lines, columns);

    for (int l = 0; l < lines; l++)
    {
        for (int c = 0; c < columns; c++)
        {
            switch (option)
            {
                case 1:
                    result[l, c] = m1[l, c] + m2[l, c];
                break;
                case 2:
                    result[l, c] = m1[l, c] - m2[l, c];
                    break;
                case 3:
                    result[l, c] = m1[l, c] * m2[l, c];
                    break;
                case 4:
                    if (m2[l, c] != 0)
                        result[l, c] = m1[l, c] / m2[l, c];
                    else
                        result[l, c] = float.NaN;
                    break;
                default:
                    Console.WriteLine("Invalid operation");
                    break;
            }
        }
    }

    string title = "";
    switch (option)
    {
        case 1:
            title = "Addition";
            break;
        case 2:
            title = "Subtraction";
            break;
        case 3:
            title = "Multiplication";
            break;
        case 4:
            title = "Division";
            break;
        default:
            Console.WriteLine("Invalid operation");
            break;
    }

    PrintMatrix(result, lines, columns, title);
}

int ReadInt(string title)
{
    Console.Write(title);
    return int.Parse(Console.ReadLine());
}

void PrintLine()
{
    Console.WriteLine("=============================");
}

float[,] CreateMatrix(int linhas, int colunas)
{
    return new float[linhas, colunas];    
}

/*----------Main----------*/
int option, lines = 3, columns = 3;

do
{
    Console.Clear();
    Console.WriteLine("=====Manipulating Matrixes=====");

    float[,] matrix1 = CreateMatrix(lines, columns);
    float[,] matrix2 = CreateMatrix(lines, columns);

    SortMatrix(matrix1, lines, columns);
    PrintMatrix(matrix1, lines, columns, "Matrix 1:");

    SortMatrix(matrix2, lines, columns);
    PrintMatrix(matrix2, lines, columns, "Matrix 2:");

    option = Menu();

    if (option != 0)
    {
        DoOperations(matrix1, matrix2, lines, columns, option);
        Console.Write("\nPress any key to continue...");
        Console.ReadKey();
    }

} while (option != 0);
