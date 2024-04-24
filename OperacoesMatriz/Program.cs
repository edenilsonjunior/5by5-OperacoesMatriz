/*
    Faça um programa que execute as 4 operações básicas entre duas matrizes e armazene em uma nova matriz

    **UPDATE**
    Implemente no programa as seguintes funcoes:
    A) Menu de selecao que retorna a operacao escolhida pelo usuario
    B) Funcao que popula a matriz atraves de sorteio
    C) Funcao que vai informar o tamanho da criacao da minha matriz(passar dois parametros int, linha e coluna)
 
 */

/*Funcoes*/
void popularMatriz(float[,] matriz, int sizeLinhas, int sizeColunas)
{
    Random random = new Random();

    for(int linha = 0; linha < sizeLinhas; linha++)
    {
        for(int coluna = 0; coluna < sizeColunas; coluna++)
        {
            matriz[linha, coluna] = random.Next(1, 10);
        }
    }
}


void ImprimirMatriz(float[,] matriz, string titulo, int linhas, int colunas)
{
    ImprimirLinha();
    Console.WriteLine(titulo);
    for (int l = 0; l < linhas; l++)
    {
        for (int c = 0; c < colunas; c++)
        {
            Console.Write($"{matriz[l, c]} ");
        }
        Console.WriteLine();
    }
}

int Menu() {

    int operacao;
    do
    {
        Console.WriteLine("Digite o numero da operacao");
        Console.WriteLine("1- Adição");
        Console.WriteLine("2- Subtracao");
        Console.WriteLine("3- Multiplicacao");
        Console.WriteLine("4- Divisão");
        Console.WriteLine("5- Sair");
        Console.Write("Digite sua escolha: ");
        operacao = int.Parse(Console.ReadLine());

    } while (operacao < 0 || operacao > 4);

    return operacao;
}

void Operacoes(float[,] matriz1, float[,] matriz2, int linhas, int colunas, int escolha)
{
    float[,] resultado = new float[linhas, colunas];

    for (int l = 0; l < linhas; l++)
    {
        for (int c = 0; c < colunas; c++)
        {
            switch (escolha)
            {
                case 1:
                    resultado[l, c] = matriz1[l, c] + matriz2[l, c];
                    break;
                case 2:
                    resultado[l, c] = matriz1[l, c] - matriz2[l, c];
                    break;
                case 3:
                    resultado[l, c] = matriz1[l, c] * matriz2[l, c];
                    break;
                case 4:
                    if (matriz2[l, c] != 0)
                        resultado[l, c] = matriz1[l, c] / matriz2[l, c];
                    else
                        resultado[l, c] = float.NaN;
                    break;
                default:
                    Console.WriteLine("Operação inválida");
                    break;
            }
        }
    }

    string titulo = "";
    switch (escolha)
    {
        case 1:
            titulo = "Adição";
            break;
        case 2:
            titulo = "Subtração";
            break;
        case 3:
            titulo = "Multiplicação";
            break;
        case 4:
            titulo = "Divisão";
            break;
        default:
            Console.WriteLine("Valor inválido");
            break;
    }

    ImprimirMatriz(resultado, titulo, linhas, colunas);
}

int LerInt(string titulo)
{
    Console.Write(titulo);
    return int.Parse(Console.ReadLine());
}

void ImprimirLinha()
{
    Console.WriteLine("=============================");
}

float[,] InstanciarMatriz(int linhas, int colunas)
{
    return new float[linhas, colunas];    
}

/*----------Main----------*/

int escolha, linhas, colunas;

do
{
    Console.Clear();
    Console.WriteLine("=====Manipulando Matrizes=====");

    do
    {
        linhas = LerInt("Digite o numero de linhas: ");
        colunas = LerInt("Digite o numero de colunas: ");

        if(linhas != colunas) Console.WriteLine("Os numeros nao podem ser diferentes!");

    } while (linhas <= 0 && colunas <= 0 || linhas != colunas);

    float[,] matriz1 = InstanciarMatriz(linhas, colunas);
    float[,] matriz2 = InstanciarMatriz(linhas, colunas);

    popularMatriz(matriz1, linhas, colunas);
    popularMatriz(matriz2, linhas, colunas);

    ImprimirMatriz(matriz1, "Matriz 1:", linhas, colunas);
    ImprimirMatriz(matriz2, "Matriz 2:", linhas, colunas);

    ImprimirLinha();
    escolha = Menu();

    if (escolha != 0)
    {
        Operacoes(matriz1, matriz2, linhas, colunas, escolha);
        Console.WriteLine("\nDigite qualquer tecla para continuar...");
        Console.ReadKey();
    }

} while (escolha != 0);
