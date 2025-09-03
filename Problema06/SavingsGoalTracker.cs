/**
 * @file SavingsGoalTracker.cs
 * @author Gustavo Henrique
 * @date 02/09/2025
 * @brief Módulo que acumula valores monetários inseridos pelo usuário até que uma meta pré-definida seja atingida.
 *
 * @section DESCRIÇÃO_DETALHADA
 * Este script implementa um "acumulador" financeiro utilizando um laço de repetição
 * 'do-while'. O programa inicializa uma variável de controle ('total') e, a cada
 * iteração, solicita ao usuário um valor monetário (tipo 'double'). Esse valor
 * é somado ao total acumulado através de um operador de atribuição composta.
 * O loop persiste enquanto o montante total for inferior à meta de R$50,00.
 * Ao atingir ou superar a meta, o loop é encerrado e o programa exibe o valor
 * final consolidado, devidamente formatado como moeda.
 *
 * @section ESPECIFIFCAÇÕES
 * ENTRADA:
 * - Valor (string -> double): Valor monetário a ser adicionado ao total em cada iteração.
 * SAÍDA:
 * - Uma string final formatada ("Total economizado: R$ [total]"), exibida ao
 * término do loop.
 *
 * @section LOG_DE_REVISÃO
 * * v1.0 (02/09/2025) - Correção de Inicialização de Variável e Lógica de Acumulação
 * ----------------------------------------------------------------
 * - Corrigida a incompatibilidade de tipo ('type mismatch') na inicialização da
 * variável acumuladora 'total', alterando o literal de 'string' "0" para o
 * literal numérico '0.0', compatível com o tipo 'double'.
 * - Ajustado o operador de atribuição para a forma composta correta ('+='). O uso
 * anterior ('=+') era interpretado como um operador de atribuição simples de um
 * valor positivo, o que não produzia o efeito de acumulação desejado.
 * - Refinada a chamada ao método 'Console.WriteLine' para utilizar a sintaxe de
 * interpolação de string ('$'), permitindo a formatação correta e a exibição
 * da variável 'total' dentro da mensagem de saída.
 *
 */

using System;

class Program
{
    static void Main()
    {
        double total = 0.0;

        while (total < 50)
        {
            Console.Write("Digite o valor a ser guardado: ");
            double valor = double.Parse(Console.ReadLine());
            total += valor;
        }

        Console.WriteLine($"Meta atingida! Total economizado: R$ {total:F2}");
    }
}
