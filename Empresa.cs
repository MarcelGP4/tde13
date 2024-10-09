public class Empresa
{
    private List<Funcionario> funcionarios;

    public Empresa ()
    {
        funcionarios = new List<Funcionario>();

    }
    public void AdicionarFuncionario(Funcionario funcionario)
    {
        funcionarios.Add(funcionario);
    }

    public void ListarFuncionario()
    {
    foreach(var funcionario in funcionarios)
    {
        Console.WriteLine($"Nome : {funcionario.Nome}");
        Console.WriteLine($"Salário :{funcionario.CalcularSalario()}");
    }
    }
}