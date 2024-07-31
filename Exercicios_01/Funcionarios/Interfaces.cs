namespace Funcionarios;

public class Interfaces {
    public void SolicitaFuncionario(ref string nome, ref int idade, ref char sexo, ref string matricula, ref double salarioBase, ref double gratificacaoProdutividade,
        ref int numeroDependentes) {
        Console.WriteLine("Digite o nome: ");
        nome = Console.ReadLine() ?? "";

        Console.WriteLine("Digite a idade: ");
        idade = Convert.ToInt32(Console.ReadLine() ?? "0");

        Console.WriteLine("Digite o sexo (M/F): ");
        sexo = Convert.ToChar(Console.ReadLine()?.ToUpper() ?? "");

        Console.WriteLine("Digite a matrícula: ");
        matricula = Console.ReadLine() ?? "";

        Console.WriteLine("Digite o salário base: ");
        salarioBase = Convert.ToDouble(Console.ReadLine() ?? "0");

        Console.WriteLine("Digite a gratificação por produtividade: ");
        gratificacaoProdutividade = Convert.ToDouble(Console.ReadLine() ?? "0");

        Console.WriteLine("Digite o número de dependentes: ");
        numeroDependentes = Convert.ToInt32(Console.ReadLine() ?? "0");
    }
}