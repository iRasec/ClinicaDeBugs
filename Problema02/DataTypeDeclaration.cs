/**
 * @file DataTypeDeclaration.cs
 * @author Luan Costa
 * @date 02/09/2025
 * @brief Demonstração da correta declaração e inicialização de tipos de dados primitivos.
 *
 * @section DESCRIÇÃO_DETALHADA
 * Este script serve como um exemplo prático da sintaxe de declaração de variáveis
 * em C#. São inicializadas cinco variáveis com tipos de dados distintos (inteiro, 
 * string, booleano, decimal e caractere) com valores literais fixos (hard-coded).
 * O objetivo é validar a correta atribuição de tipos e, subsequentemente,
 * imprimir cada um dos valores no console para verificação. Não há interação
 * com o usuário.
 *
 * @section ESPECIFICAÇÕES
 * ENTRADAS:
 * - Nenhuma. Os valores são definidos estaticamente no código-fonte.
 * SAÍDA:
 * - Cinco linhas distintas no console, cada uma exibindo o valor de uma das 
 * variáveis declaradas.
 *
 * @section LOG_DE_REVISÃO
 * * v1.0 (02/09/2025) - Correção de Violações de Tipo e Sintaxe
 * ----------------------------------------------------------------
 * - Resolução de 'type mismatch' (incompatibilidade de tipos) em múltiplas declarações, 
 * garantindo que os literais atribuídos correspondam ao tipo de dado da variável 
 * (ex: 'int' recebendo um literal numérico em vez de 'string').
 * - Adequação da sintaxe de literais de string para o uso de aspas duplas (" "), conforme
 * a especificação da linguagem C#.
 * - Substituição de uma 'string' "false" pelo literal booleano 'false' para a correta 
 * atribuição a uma variável do tipo 'bool'.
 * - Correção da atribuição de um literal de caractere para usar aspas simples (' '), 
 * distinguindo-o de uma 'string'.
 * - Ajuste de 'case-sensitivity' na referência a uma variável ('nomeCurso') durante a 
 * chamada ao método 'Console.WriteLine'.
 *
 */

using System;

class Program
{
    static void Main()
    {
        float notaProva = 8.5f;                  // nota com casas decimais -> float
        int quantidadeAlunos = 42;               // quantidade inteira -> int
        string nomeCurso = "Fundamentos de C#";  // texto -> string
        bool pagamentoEfetuado = false;          // status lógico -> bool
        char digitoVerificador = '7';            // único caractere -> char

        // Exibindo os valores
        Console.WriteLine($"Nota da prova: {notaProva}");
        Console.WriteLine($"Quantidade de alunos: {quantidadeAlunos}");
        Console.WriteLine($"Nome do curso: {nomeCurso}");
        Console.WriteLine($"Pagamento efetuado: {pagamentoEfetuado}");
        Console.WriteLine($"Dígito verificador: {digitoVerificador}");
    }
}
