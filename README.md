# dotnet-DIO anotações

## **Gerenciamento de memória em C Sharp**
<br/><br/>

## Entendendo a Stack e Heap

<br>

Dependendo do tipo de variável, ela será alocada em diferentes tipos de memória, por exemplo:

**Essas vão para o tipo Stack**

int a = 5;<br/>
int b = 10;

**Essa vai para a Stack e Heap**

Pessoa p1 = new Pessoa();

### Mas o que é Stack e Heap?

Stack(Pilha) assim como a estrutura de dado, segue o padrão LIFO (Last In, First Out).
O último que entra é o primeiro a sair! E assim alocando na memória ram.

Heap armazena os tipos complexos, como os objetos, classes interfaces e etc...


No caso de um objeto, o nome e a referência ficam na **Stack**, enquanto o objeto por inteiro fica na **Heap**, então a Stack apenas redireciona o caminho para a variável dentro do Heap

![Preview image](/Arquivos/stackeheap.png)
###### Imagem retirada do curso de .Net da DIO, de Leonardo Buta

<br/><br/>
## Limpeza de memória em C Sharp
<br/><br/>
Quando um método é encerrado, o gerenciamento do C# "mata" os processos de variáveis em memória stack, assim contribuindo para que o sistema não seja tão poluído e pesado.

<br/>

### Garbage collector (GC)
O Garbage collector encerra os processos no heap quando não recebem referências da stack
