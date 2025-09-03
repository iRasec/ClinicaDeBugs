/**
 * @file ExitConfirmationLoop.cs
 * @author Gustavo Hnerique
 * @date 02/09/2025
 * @brief Implementa um loop de confirmação que persiste até que o usuário forneça uma entrada específica.
 *
 * @section DESCRIÇÃO_DETALHADA
 * Este script utiliza uma estrutura de repetição 'do-while' para criar um prompt
 * de confirmação. O programa solicita repetidamente que o usuário insira uma
 * resposta ('S' para sair, 'N' para continuar). A entrada do usuário é
 * capturada, convertida para maiúscula para garantir a consistência da
 * validação (case-insensitivity), e então avaliada. O loop continua sua
 * execução enquanto a resposta do usuário for diferente da condição de
 * término designada ("S"). Ao receber a entrada correta, o loop é encerrado
 * e uma mensagem de finalização é exibida no console.
 *
 * @section ESPECIFICAÇÕES
 * ENTRADA:
 * - Resposta (string): Caractere ('S' ou 'N') inserido pelo usuário a cada iteração.
 * SAÍDA:
 * - Uma string final ("Programa encerrado.") exibida após a conclusão do loop.
 *
 * @section LOG_DE_REVISÃO
 * * v1.0 (02/09/2025) - Correção de Lógica de Loop e Manipulação de String
 * ----------------------------------------------------------------
 * - Ajustada a invocação do método de manipulação de string para 'ToUpper()' para
 * padronizar a entrada do usuário, garantindo uma comparação case-insensitive
 * confiável.
 * - Reformulada a expressão booleana na condição de terminação do loop 'while'.
 * A lógica original (resposta != "S" || resposta != "N") resultava em uma
 * condição perpetuamente verdadeira (tautologia), causando um loop infinito. A
 * condição foi simplificada para 'resposta != "S"'.
 * - Correção de 'case-sensitivity' na chamada do método 'Console.WriteLine' para
 * adequação à sintaxe da biblioteca .NET.
 *
 */

using System;

class Program
{
    static void Main()
    {
        string resposta;

        do
        {
            Console.Write("Deseja sair? (S/N): ");
            resposta = Console.ReadLine().Trim().ToUpper();
        }
        while (resposta != "S");

        Console.WriteLine("Programa encerrado.");
    }
}
