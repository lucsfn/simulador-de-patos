# Simulador de Patos - POO 2025/1 - SI
## Grupo 05
- Allef
- Arthur Marques
- Bruno Xavier
- Eduardo Versiani
- Lucas Fernandes

## Visão Geral

O Simulador de Patos é uma aplicação de console que implementa princípios de Programação Orientada a Objetos, permitindo ao usuário criar e interagir com diferentes tipos de patos. O sistema demonstra o uso de herança, polimorfismo e interfaces para modelar comportamentos específicos de cada tipo de pato.

## Estrutura do Projeto

```
SimuladorDePatos/
├── Controller/
│   ├── DuckController.cs
│   └── Entities/
│       ├── Duck.cs
│       ├── MallardDuck.cs
│       ├── RedHatDuck.cs
│       ├── RubberDuck.cs
│       └── Interfaces/
│           ├── IFlyable.cs
│           └── IQuackable.cs
├── View/
│   ├── GameView.cs
│   └── Menu.cs
├── Utils/
│   └── Validate.cs
├── Program.cs
└── SimuladorDePatos.csproj
```

## Entidades

### Duck (Classe Abstrata)

A classe base para todos os tipos de patos que define propriedades comuns e comportamentos gerais.

**Propriedades:**
- `_name`: Nome do pato
- `_age`: Idade do pato
- `_color`: Cor do pato
- `_size`: Tamanho do pato em centímetros

**Métodos:**
- `setName(string)`: Define o nome do pato
- `setAge(int)`: Define a idade do pato
- `setColor(string)`: Define a cor do pato
- `setSize(double)`: Define o tamanho do pato
- `getName()`: Retorna o nome do pato
- `getAge()`: Retorna a idade do pato
- `getColor()`: Retorna a cor do pato
- `getSize()`: Retorna o tamanho do pato
- `Display()`: Exibe informações sobre o pato

### Tipos Específicos de Patos

#### MallardDuck (Marreco)
- Implementa `IFlyable` e `IQuackable`
- Pode voar e grasnar
- Tem som específico "Quack! Quack!"

#### RedHatDuck (Pato de Chapéu Vermelho)
- Implementa `IFlyable` e `IQuackable`
- Pode voar e grasnar
- Tem comportamento elegante ao voar e grasnar

#### RubberDuck (Pato de Borracha)
- Implementa apenas `IQuackable`
- Não pode voar
- Produz som "Squeak! Squeak!"

## Interfaces

### IFlyable
Define o comportamento de voo para patos que podem voar.

**Métodos:**
- `bool CanFly()`: Verifica se o pato pode voar atualmente
- `void Fly()`: Implementa o comportamento de voo específico

### IQuackable
Define o comportamento de grasnido para patos que podem grasnar.

**Métodos:**
- `void Quack()`: Implementa o comportamento de grasnido específico

## Controladores

### DuckController
Gerencia a criação e exibição de detalhes dos patos.

**Métodos:**
- `DuckController(int duckType)`: Construtor que cria um tipo específico de pato baseado no parâmetro
- `displayDuckDetails(Duck)`: Exibe detalhes e habilidades do pato

## Views

### GameView
Controla o fluxo principal do jogo e a interação com o pato selecionado.

**Métodos:**
- `StartGame()`: Inicia o jogo exibindo o menu inicial
- `CreateDuck(int)`: Cria um novo pato do tipo especificado
- `DisplayDuckActionMenu()`: Exibe o menu de ações possíveis para o pato

### Menu
Gerencia a exibição dos diferentes menus do jogo.

**Métodos:**
- `displayInitialMenu()`: Exibe o menu inicial do jogo
- `displayDuckList()`: Exibe a lista de tipos de patos disponíveis
- `displayDuckAbilities(int)`: Exibe as habilidades de um tipo específico de pato

## Utils

### Validate
Contém métodos para validação de entrada do usuário.

**Métodos:**
- `validatedataIfEmpty(string)`: Valida se a entrada não está vazia
- `validateInputNumber(string)`: Valida se a entrada é um número válido

## Fluxo de Execução

1. O programa inicia em `Program.cs` criando uma instância de `GameView` e chamando `StartGame()`
2. O usuário é apresentado ao menu inicial
3. O usuário pode escolher ver a lista de patos ou sair
4. Na lista de patos, o usuário pode:
   - Ver as habilidades de um tipo específico de pato
   - Criar diretamente um pato (usando o comando "C" + número do pato)
   - Voltar ao menu inicial
5. Ao ver as habilidades, o usuário pode criar o pato ou voltar à lista
6. Ao criar um pato, o usuário configura suas características (nome, idade, cor, tamanho)
7. Após a criação, o usuário pode:
   - Ver detalhes do pato
   - Fazer o pato grasnar (se implementa IQuackable)
   - Tentar fazer o pato voar (se implementa IFlyable)
   - Voltar à lista de patos
   - Voltar ao menu inicial

## Padrões de Design Utilizados

### Herança
- A classe abstrata `Duck` define comportamento básico herdado por todas as subclasses

### Polimorfismo
- Métodos como `Display()` são sobrescritos pelos tipos específicos de patos
- Métodos de interface como `Fly()` e `Quack()` têm implementações específicas para cada tipo

### Interfaces
- `IFlyable` e `IQuackable` definem contratos para comportamentos específicos
- Implementação seletiva (nem todos os patos implementam todas as interfaces)

### MVC (Model-View-Controller)
- Model: Classes em `Entities`
- View: `GameView` e `Menu`
- Controller: `DuckController`

## Considerações sobre o Design

O uso de interfaces permite uma separação clara de responsabilidades e implementação seletiva de comportamentos:

1. Cada tipo de pato implementa apenas as interfaces relevantes às suas capacidades
2. As verificações de tipo (usando o operador `is`) permitem operações seguras
3. O código é facilmente extensível para adicionar novos tipos de patos ou comportamentos
