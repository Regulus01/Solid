# Princípios Solid
***

![Solid](./Solid.png)

*******
Conteúdo
1. [SRP - Single responsability principle](#srp)
2. [OCP - Open-Closed Principle?](#ocp)
3. [LSP - Liskov Substitution Principle](#lsp)
4. [ISP - Interface Segregation Principle](#isp)
5. [DIP - Dependency Inversion Principle](#dip)
*******

Este repositório tem como objetivo fornecer exemplos práticos e claros que ilustram os princípios do **SOLID**


### Referências:
https://medium.com/desenvolvendo-com-paixao/o-que-%C3%A9-solid-o-guia-completo-para-voc%C3%AA-entender-os-5-princ%C3%ADpios-da-poo-2b937b3fc530

<div id='srp'></div>

## SRP - Single responsability principle (Principio de responsabilidade única)
*******
O principio de **responsabilidade única** se refere a que uma classe só deve ter uma unica responsabilidade.

Por exemplo uma classe especializada em N coisas chamado comumente de **god class**
pode gerar os seguintes problemas.

* Falta de coesão — uma classe não deve assumir responsabilidades que não são suas
* Alto acoplamento — Mais responsabilidades geram um maior nível de dependências 
  deixando o sistema engessado e frágil para alterações
* Dificuldades na implementação de testes automatizados — É difícil de **“mockar”** esse tipo de classe
* Dificuldades para reaproveitar o código

Um exemplo visto no código é a classe **PedidoGodClass** onda ela pode salvar no banco, exibir, 
enviar notificação de email.

Seguindo o principo seus métodos foram divididos em 4 classes onde cara uma tem sua responsabilidade

* **Pedido** - Responsável pela criação do pedido
* **PedidoViewer** - Responsável por exibir informações sobre o pedido
* **PedidoRepository** - Responsável por fazer interações com o banco de dados.
* **EmailService** -  Responsável por Operações referentes a email.

## Observação 
  O SRP não se limita somente as classes, ele também pode
ser aplicado em métodos e funções, ou seja tudo aquilo que é
responsável por executar uma ação deve ser responsável por 
  apenas aquilo.

<div id='ocp'></div>

## OCP - Open-Closed Principle (Principo Aberto-Fechado) 
*****

O principio de aberto fechado prega que objetos ou entidades, devem
estar abertos para extensão mas fechados para modificação.

No codigo há um exemplo com folha de pagamento onde, é criado uma interface **(IRemuneravel)**
onde todas as classes que implementarem a mesma irão calcular sua remuneração.

A classe fechada para modificação nesse ponto é a folha de pagamento
que que irá calcular o saldo de um funcionario desde que o mesmo implemente a 
interface.

Com esse principio é muito mais facil adicionar novos requisitos pois o que
está funcionando não precisrá ser modificado já que o novo comportamento fica isolado.

### Observação 
* Esse padrão é base para o padrão de projeto **(IRemuneravel)**

<div id='lsp'></div>

## LSP - Liskov Substitution Principle (Princípio da substituição de Liskov) 
*****
<div id='isp'></div>

## ISP - Interface Segregation Principle (Princípio da Segregação da Interface) 
*****

<div id='dip'></div>

## DIP - Dependency Inversion Principle (Princípio da Inversão de Dependência)
*****
