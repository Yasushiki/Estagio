# Desafio técnico para o Processo Seletivo estágio do LabTIME 2026

Este repositório contém a implementação de três tickets focados na aplicação de Padrões de Projeto (Design Patterns) para resolver problemas arquiteturais em um sistema de jogo espacial. O arquivo principal `Program.cs` atua como um cliente central para todos os tickets, fornecendo uma interface de console para testar e validar o comportamento de cada implementação.

## Ticket 1 - Sistema de Contingência do Núcleo da Nave
#### Requisito
> O núcleo de energia da nave sofre variações constantes durante o combate. Precisamos que, ao atingir um nível crítico de energia (testável ao receber comandos no terminal como tomar_dano ou reduzir_energia), os escudos mudem o foco de defesa, as luzes das salas se apaguem e os painéis de navegação exibam alertas automaticamente.
#### Restrição Arquitetural
> A classe do Núcleo não pode conhecer, referenciar ou chamar diretamente as classes de Escudo, Luzes ou Painéis. A infraestrutura deve ser montada de uma forma que, se amanhã o design pedir para o "Suporte de Vida" também desligar durante a crise, nós possamos adicionar essa reação sem precisar alterar absolutamente nenhuma linha de código dentro da classe do Núcleo.
### Padrão utilizado: Facade
#### Justificativa - Facade
Para respeitar a restrição de manter a classe `Nucleo` completamente isolada e desacoplada dos subsistemas, eu apliquei o padrão **Facade** por meio da classe `OrquestradorCritico`. O **Facade** fornece uma interface unificada para um subsistema. O cliente (`Program.cs`) consegue monitorar se o núcleo entrou no estado crítico e ativar o modo crítico de todos os subsistemas, simultaneamente, por meio do orquestrador. Caso outros subsistemas sejam incluídos, não é necessário alterar nem o cliente e nem o núcleo, apenas o orquestrador.
#### Papéis do código - Facade
- **Facade**: `OrquestradorCritico` - Oferece o método `AtivarEstadoCritico` para acionar todos os subsistemas.
- **Subsystems**: `Escudo`, `Luz` e `Painel` - Classes independentes que fazem o trabalho real.
- **Client**: `Program` - Verifica o `Nucleo` e utiliza o **Facade** para alterar os modos da nave.


## Ticket 2 - Comportamento Dinâmico da Tripulação
#### Requisito
> Os NPCs da tripulação precisam alternar entre diferentes funções durante o gameplay. O avaliador deve conseguir usar o console para trocar a função de um NPC vivo (ex: mudar de 'operador de canhões' para 'mecânico do motor') e, em seguida, mandar um comando de trabalhar. A função atual deve ditar o que ele vai imprimir no terminal ao tentar executar a tarefa.
#### Restrição Arquitetural
> É proibido destruir a entidade/objeto do tripulante e instanciar um novo NPC na cena apenas para mudar sua função. Além disso, a classe principal do Tripulante não deve conter blocos gigantes de if/else ou switch cases para decidir qual lógica rodar. As regras de cada comportamento devem ser isoladas, modulares e intercambiáveis em tempo de execução.
### Padrões utilizados: State e Flyweight
#### Justificativa - State
Para que a classe `NPC` pudesse alterar seus comportamentos internos sem a necessidade da destruição e reinstanciação de um novo objeto, e sem depender de blocos condicionais enormes, o padrão **State** foi implementado. A classe `NPC` possui apenas um método genérico de trabalho, delegando a ação real para a interface `ITrabalho`, que monitora a função atual do objeto e altera sua ação com base nisso.
#### Justificativa - Flyweight
Embora não tenha sido imposto pelas restrições, uma variação do padrão **Flyweight** foi implementado para evitar gasto indevido de memória. Como todos os NPCs compartilham os mesmos estados possíveis e que são imutáveis, todos os estados são instanciados de forma estática na própria classe `NPC`. Desta forma, mesmo com vários NPCs, todos irão compartilhar os mesmos estados na memória.
#### Papéis do código - State
- **Context**: `NPC` - Mantém a referência para o trabalho atual e expõe a interface para alterá-lo.
- **State**: `ITrabalho` - Define a interface comum, modularizando os comportamentos de cada profissão.
- **Concrete States**: `TrabalhoDesempregado`, `TrabalhoMecanicoMotor` e `TrabalhoOperadorCanhao` - Implementam de forma isolada as lógicas de cada profissão.
#### Papéis do código - Flyweight
- **Instrisic States** - `TrabalhoDesempregado`, `TrabalhoMecanicoMotor` e `TrabalhoOperadorCanhao` - A lógica de cada trabalho é imutável e não depende do contexto. Todos os trabalhos são instanciados de forma estática, se tornando fixos na memória.
- **Extrinsinc State**: `NPC.TrabalhoAtual` - Esta variável muda de acordo com o contexto (qual é o trabalho ativo no momento), sendo a responsável por alterar a lógica que será delegada para a interface `ITrabalho`.
- **Flyweight Factory**: `NPC` - Esta classe guarda a pool/cache de todos os objetos **Flyweight**, garantindo que eles estão sendo reusados, em vez de recriados ou duplicados.


## Ticket 3 - Armamento Modular e Modificadores Piratas
#### Requisito
> A nave precisa conseguir atirar usando diferentes tipos de armas base (Láser [sic] Contínuo, Enxame de Mísseis, etc). O console deve aceitar comandos como equipar_arma e atirar. Além disso, o usuário deve poder rodar um comando como adicionar_modificador para acoplar efeitos extras e cumulativos ao tiro (ex: colocar Dano de Fogo e, em seguida, adicionar Perfuração de Blindagem na mesma arma antes de atirar de novo).
#### Restrição Arquitetural
> A classe da Nave deve apenas emitir o comando genérico de "Atirar", sem precisar entender a lógica ou a física de disparo de cada arma fabricante. Para os modificadores, a estrutura deve permitir o empilhamento desses efeitos extras no momento do disparo de forma dinâmica. Não podemos recorrer à criação de uma classe nova para cada combinação possível de atributos.
### Padrões utilizados: State, Decorator e Factory
#### Justificativa - State
Para a criação de várias armas base diferentes de forma escalável, o padrão **State** foi implementado. A classe `Nave` não precisa ser alterada para a criação de armas base novas, e possui apenas o método genérico `Atirar`, de forma que cada arma defina como irá atirar, assim como estipulado pela restrição.
#### Justificativa - Decorator
O padrão **Decorator** foi implementado para atender à restrição arquitetural de permitir o empilhamento de efeitos extras nas armas sem a criação de novas classes para cada combinação possível. Todas as armas base podem ou não ter efeitos específicos, e esses efeitos podem ser alterados sem alterar a arma base.
#### Justificativa - Factory
O padrão **Factory** foi utilizado para que a classe `Nave` não ficasse responsável pela criação e instanciação dos efeitos e das armas. Este papel foi delegado para `ArmaFactory`, que conversa com o cliente diretamente, de forma que a nave possua apenas métodos genéricos como `EquiparArma` e `AdicionarRemoverEfeito`.
#### Papéis no código - State
- **Context**: `Nave` - Mantém a referência para a arma base atual e expõe a interface para alterá-la.
- **State**: `IArma` - Define a interface comum, modularizando os comportamentos de cada arma.
- **Concrete States**: `Desarmado`, `Laser` e `Missil` - Implementam de forma isolada as lógicas de cada arma, como elas irão atirar e como calcular o dano total da arma.
#### Papéis no código - Decorator
- **Component Interface**: `IArma` - Define a interface comum dos objetos que serão encapsulados (armas) e de seus decoradores (efeitos).
- **Concrete Component**: `Desarmado`, `Laser` e `Missil` - As armas base que podem ser estendidas com efeitos. Embora `Desarmado` não tenha nenhum efeito, ele também poderia ser expandido caso necessário.
- **Decorator**: `ArmaDecorator` - A classe abstrata que implementa os decoradores. Ela guarda uma referência para o objeto que será encapsulado.
- **Concrete Decorator**: `LaserDuplo`, `LaserHelicoidal`, `MissilMultiplo` e `MissilNanite` - São as classes responsáveis por encapsular as armas, podendo encapsular tanto uma arma base quanto uma arma que já foi encapsulada por outro decorador. Elas alteram o nome completo da arma e suas especificações de dano, dando bônus ou multiplicadores para a arma.
#### Papéis no código - Factory
- **Product**: `IArma` - É a inteface geral que todos os objetos criados irão implementar.
- **Concrete Product**: Todas as armas base e seus respectivos decoradores - Todas as armas base e seus respectivos decoradores são criados, sob demanda, pela Factory.
- **Factory**: `ArmaFactory` - É a classe responsável por receber pedidos do cliente para a criação de novas armas e pela decoração dessas respectivas armas. Possui um dicionário com todas as relações Arma-Efeitos, de forma a facilitar a impressão dinâmica de efeitos no console de acordo com a arma atual.


## Instruções de Execução
O seguinte tutorial funciona para Windows, Linux e MacOS.

### Passo 1 - Download do Framework .NET
Para rodar o projeto, é necessária a instalação do Framework .NET. Como o programa utiliza funcionalidades e padrões recentes, é recomendada a instalação da versão `.NET 10.0`, que pode ser encontrada no [Site Oficial do Framework](https://dotnet.microsoft.com/download). O download é simples e direto ao ponto. Você pode conferir a versão instalada rodando:
```
dotnet --version
```
O terminal deverá imprimir algo como: `10.0.xxx`.

### Passo 2 - Clonagem do repositório
Após a instalação do Framework, é necessário clonar este repositório:
```
git clone git@github.com:Yasushiki/Estagio.git
```

### Passo 3 - Rodar o projeto
Com o repositório clonado, você apenas precisa entrar na pasta do repositório e rodá-lo:
```
cd Estagio
dotnet run
```

### Passo 4 - Testar
O programa irá apresentar um menu principal baseado em números. Você deverá escolher o número correspondente ao que você deseja fazer.
