namespace Funcionarios;

public class Funcionario : Pessoa {
    protected string matricula;
    protected double salarioBase;
    protected double gratificacaoProdutividade;
    protected int numeroDependentes;

    public Funcionario() {
        matricula = "";
        salarioBase = 0;
        gratificacaoProdutividade = 0;
        numeroDependentes = 0;
    }
    
    public Funcionario(string nome, int idade, char sexo, string matricula, double salarioBase, double gratificacaoProdutividade, int numeroDependentes)
        : base(nome, idade, sexo) {
        this.matricula = matricula;
        this.salarioBase = salarioBase;
        this.gratificacaoProdutividade = gratificacaoProdutividade;
        this.numeroDependentes = numeroDependentes;
    }

    public string Matricula {
        get => matricula;
        set => matricula = value;
    }

    public double SalarioBase {
        get => salarioBase;
        set => salarioBase = value;
    }

    public double GratificacaoProdutividade {
        get => gratificacaoProdutividade;
        set => gratificacaoProdutividade = value;
    }

    public int NumeroDependentes {
        get => numeroDependentes;
        set => numeroDependentes = value;
    }

    public double CalculaSalarioBruto() {
        return salarioBase + gratificacaoProdutividade;
    }
}