/**
 * @file AgeValidator.cs
 * @author Nicolas Brunismann
 * @date 02/09/2025
 * @brief Módulo que verifica se um usuário é maior de idade com base na entrada fornecida.
 *
 * @section DESCRIÇÃO_DETALHADA
 * O script implementa uma lógica de verificação de maioridade. Ele solicita ao
 * usuário que insira sua idade como um número inteiro. O valor de entrada é então
 * avaliado por uma estrutura de controle condicional (if-else) para determinar
 * se a idade é igual ou superior ao limiar de maioridade legal (18 anos).
 * Com base no resultado dessa avaliação, uma mensagem apropriada é exibida
 * no console, informando se o usuário é "Maior de idade" ou "Menor de idade".
 *
 * @section ESPECIFICAÇÕES
 * ENTRADA:
 * - Idade (string -> int): Idade do usuário, que será convertida para um tipo inteiro.
 * SAÍDA:
 * - Uma string ("Maior de idade." ou "Menor de idade.") indicando o resultado da
 * verificação condicional.
 *
 * @section LOG_DE_REVISÃO
 * * v1.0 (02/09/2025) - Correção de Lógica Condicional e Sintaxe
 * ----------------------------------------------------------------
 * - Corrigida a sintaxe do operador relacional de "maior ou igual a", alterando 
 * o operador inválido '=>' (lambda) para o operador de comparação correto '>='.
 * - Removido um terminador de instrução (ponto e vírgula) espúrio localizado
 * imediatamente após a expressão condicional 'if'. Este erro causava o
 * término prematuro do bloco 'if', desassociando-o da cláusula 'else' e
 * resultando em comportamento lógico incorreto.
 *
 */

using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite sua idade: ");
        int idade = int.Parse(Console.ReadLine());

        if (idade >= 18) // operador de comparação correto
        {
            Console.WriteLine("Você é maior de idade.");
        }
        else
        {
            Console.WriteLine("Você é menor de idade.");
        }
    }
}
