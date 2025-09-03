/**
 * @file DayOfWeekMapper.cs
 * @author Nicolas Brunismann
 * @date 02/09/2025
 * @brief Módulo que mapeia um valor numérico (1-7) ao dia da semana correspondente.
 *
 * @section DESCRIÇÃO_DETALHADA
 * O script solicita ao usuário a inserção de um número inteiro que representa um
 * dia da semana. Uma estrutura de controle de seleção múltipla (switch-case) é
 * utilizada para avaliar o valor de entrada. Cada 'case' corresponde a um número
 * de 1 a 7, associando-o ao nome do respectivo dia. A cláusula 'break' é
 * utilizada para garantir a saída da estrutura após a execução do bloco de código
 * correspondente. Caso o número de entrada esteja fora do intervalo válido [1, 7],
 * o fluxo é direcionado para a cláusula 'default', que informa ao usuário que a
 * entrada é inválida.
 *
 * @section ESPECIFICAÇÕES
 * ENTRADA:
 * - Dia (string -> int): Número inteiro de 1 a 7.
 * SAÍDA:
 * - Uma string contendo o nome do dia da semana (ex: "Domingo").
 * - Uma string de erro ("Dia inválido.") para entradas fora do intervalo esperado.
 *
 * @section LOG_DE_REVISÃO
 * * v1.0 (02/09/2025) - Correção de Lógica e Sintaxe da Estrutura Switch-Case
 * ----------------------------------------------------------------
 * - Corrigido erro de referência de variável (typo), ajustando o nome da variável
 * utilizada na expressão do 'switch' para corresponder à declarada.
 * - Padronização dos literais nos rótulos 'case' para o tipo 'int', resolvendo a
 * incompatibilidade de tipos (type mismatch) com a variável de controle.
 * - Inserção de instruções 'break' ausentes ao final de cada bloco 'case' para
 * prevenir o comportamento de "fall-through" (passagem direta para o próximo caso),
 * garantindo a execução exclusiva do bloco correspondente.
 * - Adição de terminadores de instrução (ponto e vírgula) faltantes nas chamadas
 * de método dentro dos blocos 'case'.
 * - Correção da sintaxe da cláusula 'default', assegurando seu correto funcionamento
 * como o manipulador de casos padrão.
 *
 */

using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número de 1 a 7: ");
        int dia = int.Parse(Console.ReadLine());

        switch (dia)
        {
            case 1:
                Console.WriteLine("Domingo");
                break;
            case 2:
                Console.WriteLine("Segunda-feira");
                break;
            case 3:
                Console.WriteLine("Terça-feira");
                break;
            case 4:
                Console.WriteLine("Quarta-feira");
                break;
            case 5:
                Console.WriteLine("Quinta-feira");
                break;
            case 6:
                Console.WriteLine("Sexta-feira");
                break;
            case 7:
                Console.WriteLine("Sábado");
                break;
            default:
                Console.WriteLine("Número inválido.");
                break;
        }
    }
}
