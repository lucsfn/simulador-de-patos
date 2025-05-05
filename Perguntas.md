### 2 - Explique quais os principais ganhos desta estratégia?
**- Desacoplamento:** Permite que o código seja menos dependente de implementações específicas, e se precisar alterar algum comportamento, apenas as classes que herdem as interfaces que implementem o comportamento específico serão afetadas, facilitando a manutenabilidade.

**- Flexibilidade:** Diferentes classes podem implementar o mesmo contrato, fazendo com que objetos diferentes sejam tratados da mesma forma.

**- Reutilização de código:** O mesmo bloco de código pode ser implementado por várias classes, além disso, manutenções futuras atualizam em escopo global.

**- Testabildiade:** Facilitam a criação de testes unitários.

### 3 - Você é capaz de ver alguma desvantagem nesta estratégia?
A manutenção das interfaces pode se tornar um problema no sentido de afetar todas as classes que a implementem, sendo assim, tem que ser estrategicamente pensadas, mas depende muito do contexto de aplicação. Acredito que num balanço geral possuem mais vantagens que desvantagens.

