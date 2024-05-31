# RPG-MOCHILA

# Documentação do Código

## Descrição
Este programa em C# implementa um simples sistema de menu que simula a interação com uma mochila de itens. O usuário é apresentado com um menu onde pode optar por abrir a mochila para visualizar os itens contidos nela ou sair do programa.

## Funcionalidades
- **Menu**: Exibe um menu para o usuário com opções disponíveis.
- **Abrir a Mochila**: Permite que o usuário visualize os itens contidos na mochila.
- **Sair do Programa**: Oferece a opção de encerrar a execução do programa.


![rpg](https://github.com/devjoaolimaw/RPG-MOCHILA/assets/167019869/d2d52022-7464-4129-b467-61e23ce92701)


![rpg2](https://github.com/devjoaolimaw/RPG-MOCHILA/assets/167019869/9bed2355-0cd9-41df-aae7-912b8bf93ad1)


## Funcionamento
1. O programa começa executando o método `Main`.
2. No método `Main`, o método `Menu` é chamado para exibir o menu inicial.
3. No método `Menu`, o usuário é solicitado a digitar uma opção.
4. Com base na opção fornecida pelo usuário, o programa chama o método correspondente (`Mochila` ou `Environment.Exit` para sair).

5. Se o usuário escolher abrir a mochila, o método `Mochila` é chamado.
6. O método `Mochila` limpa a tela do console, exibe uma lista de itens predefinidos e solicita ao usuário que pressione qualquer tecla para voltar ao menu.
7. O programa continua executando até que o usuário escolha sair.

## Estrutura do Código
- O código está contido em um único arquivo chamado `Program.cs`.
- O método `Main` é o ponto de entrada do programa.
- O método `Menu` exibe o menu e gerencia as opções do usuário.
- O método `Mochila` é responsável por exibir os itens da mochila.

## Bibliotecas Utilizadas
- `System`: Biblioteca padrão do C#.
- `System.Collections.Generic`: Utilizada para trabalhar com coleções genéricas.
- `System.ComponentModel.Design`: Utilizada para acessar tipos relacionados ao design.

## Como Usar
1. Compile o código-fonte usando um compilador C# compatível.
2. Execute o programa resultante (geralmente um arquivo com extensão `.exe`).
3. Siga as instruções exibidas no console para interagir com o programa.

Este documento fornece uma visão geral do funcionamento e estrutura do código, juntamente com instruções básicas sobre como utilizá-lo.
