/**
 * @file PersonalDataCollector.cs
 * @author Luan Costa
 * @date 02/09/2025
 * @brief Módulo para coleta e exibição de dados pessoais do usuário.
 *
 * @section DESCRIÇÃO_DETALHADA
 * O programa solicita interativamente ao usuário que forneça seu nome completo,
 * idade e altura em metros. As entradas, recebidas como strings, são 
 * submetidas a um processo de parsing para os tipos de dados alvo: String, 
 * Int32 e Float/Double. Após a validação e conversão bem-sucedidas, 
 * os dados são concatenados e exibidos em uma única linha no console.
 *
 * @section ESPECIFICAÇÕES
 * ENTRADAS:
 * - Nome (string): Nome civil do usuário.
 * - Idade (string -> int): Idade em anos inteiros.
 * - Altura (string -> float): Altura em metros, com separador decimal.
 * SAÍDA:
 * - Uma string formatada no padrão: "Nome: [nome], Idade: [idade], Altura: [altura]m."
 *
 * @section LOG_DE_REVISÃO
 * * v1.0 (02/09/2025) - Correções Iniciais e Funcionalidade Base
 * ----------------------------------------------------------------
 * - Adição de terminadores de instrução (ponto e vírgula) ausentes em chamadas a 'Console.WriteLine'.
 * - Implementação de conversão explícita de tipos (parsing) para as variáveis 'idade' e 'altura' 
 * utilizando 'int.Parse' e 'float.Parse' para prevenir 'InvalidCastException'.
 * - Correção de 'case-sensitivity' em chamadas de método ('Console.WriteLine').
 * - Padronização da nomenclatura de variáveis para 'camelCase' (ex: 'primeiroNome').
 *
 */

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Por favor, digite seu primeiro nome:");
        string primeiroNome = Console.ReadLine();

        Console.WriteLine("Agora, digite sua idade:");
        int idade = int.Parse(Console.ReadLine()); // conversão de string para inteiro

        Console.WriteLine("Por fim, digite sua altura em metros (ex: 1,80):");
        float altura = float.Parse(Console.ReadLine()); // conversão para float

        // Exibindo todas as informações em uma única linha
        Console.WriteLine($"Resumo do Cadastro: Nome: {primeiroNome}, Idade: {idade} anos, Altura: {altura}m.");
    }
}
