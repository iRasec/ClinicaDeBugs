/**
 * @file MultiplicationTable.cs
 * @author Diego Matias
 * @date 02/09/2025
 * @brief Módulo que gera e exibe a tabuada de um número fornecido pelo usuário.
 *
 * @section DESCRIÇÃO_DETALHADA
 * O script solicita ao usuário a entrada de um número inteiro base para o cálculo.
 * Em seguida, uma estrutura de repetição com contador ('for' loop) é utilizada para
 * iterar dez vezes, com a variável de controle do laço ('i') variando de 1 a 10.
 * A cada iteração, é calculada a multiplicação do número base pela variável de
 * controle atual. O resultado é então exibido em uma linha formatada, mostrando
 * a operação completa (ex: "5 x 1 = 5"). Ao final das dez iterações, a tabuada
 * completa foi impressa no console.
 *
 * @section ESPECIFICAÇÕES
 * ENTRADA:
 * - num (string -> int): Número inteiro base para a tabuada.
 * SAÍDA:
 * - Dez linhas de texto, cada uma representando uma operação da tabuada, no formato
 * "n x i = resultado".
 *
 * @section LOG_DE_REVISÃO
 * * v1.0 (02/09/2025) - Correção da Lógica de Iteração e Referência de Variáveis
 * ----------------------------------------------------------------
 * - Corrigida a lógica de incremento da variável de controle do loop. O operador
 * de decremento ('i--') foi substituído pelo operador de incremento ('i++') para
 * garantir que o laço itere na sequência ascendente correta de 1 a 10.
 * - Resolvido um erro de referência de variável na expressão de cálculo. A
 * multiplicação foi ajustada para utilizar a variável de controle do loop ('i'),
 * em vez de uma variável inexistente ('j'), assegurando que o cálculo correto
 * seja performado a cada iteração.
 *
 */
using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número para ver a tabuada: ");
        int num = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{num} x {i} = {num * i}");
        }
    }
}
