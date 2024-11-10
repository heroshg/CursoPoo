// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var pessoa = new Pessoa
{
    Nome = "Heros",
    Profissao = "Desenvolvedor",
    Telefone = "1231231232"
};

var pessoa2 = new Pessoa("Heros Hlatki 2", "Desenvolvedor de Software", "1231231232");

//var pessoa = new Pessoa();
//pessoa.Nome = "Heros";
//pessoa.Profissao = "Desenvolvedor";
//pessoa.Telefone = "1231231232";

pessoa.Apresentar();
pessoa.Apresentar("Fulano");
//var funcionario = new Funcionario();
//funcionario.Nome = "Heros";
//funcionario.Profissao = "Desenvolvedor";
//funcionario.Telefone = "1231231232";
//funcionario.Salario = 15000;

var funcionario = new Funcionario("Heros Hlatki 3", "Desenvolvedor de Software", "1231231232", 15000);
funcionario.Apresentar();

Pessoa[] pessoas = { pessoa, funcionario };

foreach(var p in pessoas)
{
    p.Apresentar();
}

//public abstract  class Pessoa
public class Pessoa
{
    
    public Pessoa()
    {

    }
    public Pessoa(string nome, string profissao, string telefone)
    {
        Nome = nome;
        Profissao = profissao;
        Telefone = telefone;
    }

    public string Nome { get;  set; }
    public string Profissao { get; set; }
    public string Telefone { get; set; }
    public virtual void Apresentar()
    {
        Console.WriteLine(FormatarMensagem());
    }
    // Overload
    public void Apresentar(string nome)
    {
        Console.WriteLine($"Olá, {nome}: {FormatarMensagem()}");
    }
    private string FormatarMensagem()
    {
        return $"{Nome}, {Profissao}, {Telefone}";
    }

   // public abstract void Comprar();
}

public class Funcionario : Pessoa
{
    public Funcionario(string nome, string profissao, string telefone, int salario) : base(nome, profissao, telefone)
    {
        Salario = salario;
    }

    public override void Apresentar()
    {
        base.Apresentar();
        Console.WriteLine($"$Salario: {Salario}");
    }
    public int Salario { get; set; }

//    public override void Comprar()
//    {
//        throw new NotImplementedException();
//    }
}

public interface IPagante
{
    void Pagar();
}

public interface IPessoa
{
    void Apresentar();
}

public class Cliente : IPessoa, IPagante
{
    public void Apresentar()
    {
        throw new NotImplementedException();
    }

    public void Pagar()
    {
        throw new NotImplementedException();
    }
}
