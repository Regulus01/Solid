// SRP - Uma classe só deve ter um e somente um motivo para mudar
/*
                  Principio de responsabilidade única
    Esse principio declara que uma classe só deve ser especializada em um assunto,
    assim evitandos as God class, que são classes especializadas em tudo.
    
                Sua violação pode causa os seguintes problemas
    * Falta de coesão — uma classe não deve assumir responsabilidades que não são suas;
    * Alto acoplamento — Mais responsabilidades geram um maior nível de dependências,
      deixando o sistema engessado e frágil para alterações;
    * Dificuldades na implementação de testes automatizados — É difícil de “mockar” esse tipo de classe;
    * Dificuldades para reaproveitar o código;
 
 */

var podeTudo = new PedidoGodClass();
podeTudo.AdicionarPedidoAoBancoDeDados(podeTudo);
podeTudo.ExibirPedido();
podeTudo.EnviarConfirmacaoDeEmail();

//SRP - Cada classe com sua responsibilidade
var pedido = new Pedido();

var viewer = new PedidoViewer();
viewer.ExibirPedido(pedido);

var repository = new PedidoRepository();
repository.AdicionarPedidoAoBancoDeDados(pedido);

var emailService = new EmailService();
emailService.EnviarConfirmacaoDeEmail();



// Nesse exemplo temos a god class onde o produto é responsavel por tudo
class PedidoGodClass
{
    public int Numero { get; set; }
    public DateTime Data { get; set; }
    public double Valor { get; set; }

    public void ExibirPedido()
    {
        Console.WriteLine("Exibindo produto: " + Numero);
    }
    public void AdicionarPedidoAoBancoDeDados(PedidoGodClass produto)
    {
        Console.WriteLine("Pedido adicionado ao banco de dados: " + produto.Numero);
    }
    
    public void EnviarConfirmacaoDeEmail()
    {
        Console.WriteLine("E-mail de confirmação enviado");
    }
}

// Utilizando o principio de responsabilidade unica, teriamos a divisão em 3 classes
// Pedido, PedidoRepository, EmailService e PedidoViewer

class Pedido
{
    public int Numero { get; set; }
    public DateTime Data { get; set; }
    public double Valor { get; set; }
}

class PedidoViewer
{
    public void ExibirPedido(Pedido pedido)
    {
        Console.WriteLine("Exibindo produto: " + pedido);
    }
}

class PedidoRepository
{
    public void AdicionarPedidoAoBancoDeDados(Pedido pedido)
    {
        Console.WriteLine("Pedido adicionado ao banco de dados: " + pedido.Numero);
    }
}

class EmailService
{
    public void EnviarConfirmacaoDeEmail()
    {
        Console.WriteLine("E-mail de confirmação enviado");
    }
}