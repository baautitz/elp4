namespace Funcionarios;

public class Pessoa {
    protected string nome;
    protected int idade;
    protected char sexo;

    public Pessoa() {
        nome = "";
        idade = 0;
        sexo = ' ';
    }

    public Pessoa(string nome, int idade, char sexo) {
        this.nome = nome;
        this.idade = idade;
        this.sexo = sexo;
    }

    public string Nome {
        get => nome;
        set => nome = value;
    }

    public int Idade {
        get => idade;
        set => idade = value;
    }

    public char Sexo {
        get => sexo;
        set => sexo = value;
    }
}