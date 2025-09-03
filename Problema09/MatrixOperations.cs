/**
 * @file MatrixOperations.cs
 * @author Shara Palharini
 * @date 02/09/2025
 * @brief Módulo para realizar múltiplas operações em uma matriz 3x3 de inteiros.
 *
 * @section DESCRIÇÃO_DETALHADA
 * O script gerencia uma matriz bidimensional de 3x3. Inicialmente, ele solicita
 * ao usuário que popule a matriz com 9 valores inteiros. Após a entrada de dados,
 * o programa executa quatro operações distintas:
 * 1.  Cálculo da Soma Total: Itera sobre todos os elementos da matriz e acumula seus valores.
 * 2.  Soma da Diagonal Principal: Itera sobre os elementos onde o índice da linha é
 * igual ao índice da coluna (i == j) e soma seus valores.
 * 3.  Maiores Valores por Linha: Para cada linha, identifica e armazena o maior elemento.
 * 4.  Matriz Transposta: Gera e exibe uma nova matriz onde as linhas da matriz original
 * se tornam as colunas e vice-versa (A[i,j] -> A_t[j,i]).
 * Os resultados de cada operação são exibidos sequencialmente no console.
 *
 * @section ESPECIFICAÇÕES
 * ENTRADA:
 * - 9 valores do tipo inteiro para popular a matriz 3x3.
 * SAÍDA:
 * - Valor da soma total dos elementos.
 * - Valor da soma da diagonal principal.
 * - Três valores correspondentes aos maiores elementos de cada linha.
 * - A exibição formatada da matriz transposta 3x3.
 *
 * @section LOG_DE_REVISÃO
 * * v1.0 (02/09/2025) - Correções Estruturais e Algorítmicas em Matrizes
 * ----------------------------------------------------------------
 * - Ajustadas as condições de contorno nos laços 'for' aninhados para 'i < 3' e 'j < 3',
 * corrigindo um "erro off-by-one" que causava 'IndexOutOfRangeException' ao
 * tentar acessar índices inexistentes.
 * - Retificada a declaração da matriz para 'int[,]', especificando uma matriz
 * multidimensional (retangular), em oposição à sintaxe para um array irregular
 * (jagged array, 'int[][]'), garantindo a alocação de memória contígua e a
 * estrutura correta para uma grade de tamanho fixo.
 * - Refinamento do algoritmo de soma da diagonal principal para iterar corretamente
 * sobre os índices onde 'i == j'.
 * - Garantida a inicialização apropriada de variáveis acumuladoras e de controle
 * antes do início dos loops para evitar o uso de valores indefinidos nos cálculos.
 * - Implementado e validado o algoritmo de transposição de matriz, assegurando a
 * correta troca de índices entre a matriz de origem e a de destino.
 *
 */

using System;

class Program
{
    static void Main()
    {
        int[,] matriz = new int[3, 3];
        int somaTotal = 0;
        int somaDiagonal = 0;
        int[] maiores = new int[3];

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Valor [{i},{j}]: ");
                int valor = int.Parse(Console.ReadLine());
                matriz[i, j] = valor;

                somaTotal += valor;

                if (i == j)
                    somaDiagonal += valor;

                if (j == 0 || valor > maiores[i])
                    maiores[i] = valor;
            }
        }

        Console.WriteLine($"Soma total: {somaTotal}");
        Console.WriteLine($"Soma diagonal principal: {somaDiagonal}");

        Console.WriteLine("Maiores por linha:");
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(maiores[i]);
        }

        Console.WriteLine("Matriz transposta:");
        for (int j = 0; j < 3; j++)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
