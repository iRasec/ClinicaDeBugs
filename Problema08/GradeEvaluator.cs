/**
 * @file GradeEvaluator.cs
 * @author Diego Matias
 * @date 02/09/2025
 * @brief Módulo para armazenar e avaliar um conjunto de notas, determinando a situação de cada uma.
 *
 * @section DESCRIÇÃO_DETALHADA
 * O script é projetado para processar um lote de cinco notas. Ele utiliza uma
 * estrutura de dados do tipo array para armazenar as notas inseridas pelo usuário.
 * Após o preenchimento do array, o programa itera sobre cada um de seus elementos
 * utilizando um laço 'for'. Para cada nota, uma estrutura condicional avalia se o
 * valor é maior ou igual ao critério de aprovação (nota 7). Com base nessa
 * avaliação, o programa exibe a nota original seguida de sua situação ("Aprovado"
 * ou "Reprovado").
 *
 * @section ESPECIFICAÇÕES
 * ENTRADA:
 * - 5 valores do tipo inteiro (notas), armazenados em um array.
 * SAÍDA:
 * - 5 linhas de texto formatadas, cada uma contendo a nota e a situação
 * correspondente (ex: "Nota 8: Aprovado").
 *
 * @section LOG_DE_REVISÃO
 * * v1.0 (02/09/2025) - Correção de Acesso a Índice de Array e Lógica de Comparação
 * ----------------------------------------------------------------
 * - Ajustada a condição de terminação do loop para 'i < notas.Length'. A condição
 * anterior ('i <= notas.Length') configurava um "erro off-by-one", que tentava
 * acessar um índice fora dos limites do array, resultando em uma exceção do tipo
 * 'IndexOutOfRangeException'.
 * - Substituído o operador de atribuição ('=') pelo operador relacional de "maior ou
 * igual a" ('>=') dentro da estrutura condicional. O uso incorreto do operador de
 * atribuição impedia a avaliação lógica da nota e, em vez disso, tentava
- * modificar o valor no array, gerando um comportamento incorreto.
 *
 */

using System;

class Program
{
    static void Main()
    {
        int[] notas = new int[5];

        for (int i = 0; i < notas.Length; i++)
        {
            Console.Write($"Digite a nota {i + 1}: ");
            notas[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < notas.Length; i++)
        {
            string situacao = (notas[i] >= 7) ? "Aprovado" : "Reprovado";
            Console.WriteLine($"Nota {i + 1}: {notas[i]} - {situacao}");
        }
    }
}
