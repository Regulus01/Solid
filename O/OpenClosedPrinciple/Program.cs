/*
    OCP - Open-closed principle
    Objetos ou entidades devem estar abertos para extensão, mas fechados para modificação 
*/

var folha = new FolhaDePagamentoErrado();
var funcionario = new EstagioErrado();
folha.calcular(funcionario);

class ContratoCltErrado
{
    public double Salario { get; set; }
    public void salario()
    {
        Console.WriteLine("calculando salario" + Salario);
    }
}

class EstagioErrado
{
    public double Salario { get; set; }
    public void Auxilo()
    {
        Console.WriteLine("calculando auxilio" + Salario);
    }
}

//Dessa forma pode ocorrer de modificar a classe, adicionando cada vez mais logica
// ao criar um novo tipo de funcionario.
class FolhaDePagamentoErrado
{
    public double Saldo { get; set; }

    public void calcular(object funcionario)
    {
        if (funcionario is EstagioErrado)
        {
            Saldo = ((EstagioErrado)funcionario).Salario;
        }

        if (funcionario is ContratoCltErrado)
        {
            Saldo = ((ContratoCltErrado)funcionario).Salario;
        }
    }
}

// O correto seria criar uma interface e cada classe implementar essa interface
// com a sua regra para a remuneração, dessa forma classe folha de pagamento não
// iria precisar de qualquer modificação em seu código fonte.

interface IRemuneravel
{
    public double remuneracao();
}
class ContratoClt : IRemuneravel
{
    public double Salario { get; set; }
    public void salario()
    {
        Console.WriteLine("calculando salario" + Salario);
    }

    public double remuneracao()
    {
        return Salario;
    }
}

class Estagio : IRemuneravel
{
    public double Salario { get; set; }
    public void Auxilo()
    {
        Console.WriteLine("calculando auxilio" + Salario);
    }

    public double remuneracao()
    {
        return Salario;
    }
}

class FolhaDePagamento
{
    public double Saldo { get; set; }

    public void Calcular(IRemuneravel funcionario)
    {
        Saldo = funcionario.remuneracao();
    }
}