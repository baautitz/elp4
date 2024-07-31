namespace Funcionarios;

public static class Program {
    public static void Main(string[] args) {
        Aplicacao aplicacao = new Aplicacao();
        aplicacao.Executar();
    }
}

public class Aplicacao {
    protected Funcionario? funcionario;
    protected Interfaces interfaces;

    public Aplicacao() {
        interfaces = new Interfaces();
    }

    public void Executar() {
        string nome = "", matricula = "";
        char sexo = ' ';
        int idade = 0, numeroDependentes = 0;
        double salarioBase = 0, gratificacaoProdutividade = 0;

        interfaces.SolicitaFuncionario(ref nome, ref idade, ref sexo, ref matricula, ref salarioBase, ref gratificacaoProdutividade, ref numeroDependentes);
        funcionario = new Funcionario(nome, idade, sexo, matricula, salarioBase, gratificacaoProdutividade, numeroDependentes);
    }
}