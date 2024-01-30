# testeCrud

Este projeto em C# (linguagem C#) é uma solução que implementa operações CRUD (Create, Read, Update, Delete) básicas. A estrutura do projeto está organizada em várias pastas para manter uma organização eficiente.

## Estrutura de Pastas

### Data
- Pasta destinada à criação dos repositórios.
  
### Domain
- Contém as regras de negócio e serviços do projeto.

### Models
- Armazena as entidades utilizadas no projeto, representando as informações que são manipuladas no banco de dados e expostas pela aplicação web.
ps: Data está no formato de Current Milliseconds
### Web
- Contém os controladores e APIs expostas para interação com o sistema.

## Scripts do Banco de Dados

Os scripts para a criação do banco de dados e tabelas estão disponíveis no arquivo `scripts.txt`. Para executar esses scripts, você pode usar o Docker para criar um contêiner do banco de dados.

### Executando o Banco de Dados via Docker

Certifique-se de ter o Docker instalado em sua máquina.

```bash
# Crie um contêiner do banco de dados utilizando o script no arquivo 'scripts.txt'
