/**
 * @file MatrixSearch.cs
 * @author Shara Palharini
 * @date 02/09/2025
 * @brief Módulo para buscar um número específico em uma matriz 3x3 e reportar sua posição.
 *
 * @section DESCRIÇÃO_DETALHADA
 * O script primeiro popula uma matriz bidimensional de 3x3 com valores inteiros
 * fornecidos pelo usuário. Em seguida, solicita um número alvo para a busca.
 * Um algoritmo de busca linear é implementado por meio de laços 'for' aninhados,
 * que percorrem cada elemento da matriz. Durante a varredura, o valor de cada
 * célula é comparado com o número alvo. Se uma correspondência for encontrada,
 * uma variável de controle booleana ('flag') é acionada, os índices da linha e
 * coluna são armazenados, e o loop é interrompido para otimização. Ao final da
 * busca, o estado da flag determina se a saída será a posição do número
 * encontrado ou uma mensagem indicando que o número não pertence à matriz.
 *
 * @section ESPECIFICAções
 * ENTRADA:
 * - 9 valores do tipo inteiro para popular a matriz 3x3.
 * - 1 valor do tipo inteiro representando o número a ser buscado.
 * SAÍDA:
 * - Uma string formatada ("Encontrado na posição ([linha], [coluna])") se o número for localizado.
 * - Uma string ("Número não encontrado.") caso contrário.
 *
 * @section LOG_DE_REVISÃO
 * * v1.0 (02/09/2025) - Correções em Estrutura de Dados, Lógica de Busca e Controle de Estado
 * ----------------------------------------------------------------
 * - Corrigida a sintaxe de declaração e instanciação da matriz multidimensional 'int[,]',
 * garantindo a alocação de memória apropriada para uma grade de 3x3.
 * - Substituído o operador de atribuição ('=') pelo operador de igualdade ('==') na
 * estrutura condicional, o que é fundamental para a correta avaliação lógica
 * da correspondência de valores.
 * - Assegurada a inicialização explícita da variável de controle booleana ('encontrado')
 * com o valor 'false'. Esta prática previne o uso de um valor indefinido e estabelece
 * um estado inicial conhecido para o algoritmo de busca.
 * - Ajustadas as condições de contorno dos laços de iteração para usar o operador '<' em
 * vez de '<=', prevenindo um "erro off-by-one" e a consequente 'IndexOutOfRangeException'.
 *
 */

using System;

class Program
{
    static void Main()
    {
        int[,] matriz = new int[3, 3];

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Valor [{i},{j}]: ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.Write("Número a buscar: ");
        int buscado = int.Parse(Console.ReadLine());

        bool encontrado = false;
        int linha = -1, coluna = -1;

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (matriz[i, j] == buscado)
                {
                    encontrado = true;
                    linha = i;
                    coluna = j;
                    break;
                }
            }
            if (encontrado) break;
        }

        if (encontrado)
        {
            Console.WriteLine($"Encontrado em ({linha + 1}, {coluna + 1})");
        }
        else
        {
            Console.WriteLine($"Número não encontrado: {buscado}");
        }
    }
}
