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

<br/><br/>
## Tipos de valor e referências
<br/><br/>

### Tipo de valor: Uma variável de um tipo de valor contém uma instância do tipo.
##### Os tipos de valores recebem variáveis simples, como INT, Bool, Double, String...
##### Eles recebem o nome de tipos primitivos!

<br/>

### Tipo de referência: Uma variável de um tipo de referência contém uma referência a uma instância do tipo.
##### A referência somente armazena o nome da variável na **Stack**, e faz uma ligação com o objeto/valor que fica na memória **Heap**.

<br/>

#### **Lembrete: Quando uma instância chama outra instância não é criado outro objeto, os dois fazem referência para o mesmo na Heap** 

<br/>

![Preview image](/Arquivos/sameref.png)
###### Imagem retirada do curso de .Net da DIO, de Leonardo Buta

<br/><br/>

## **Orientação a objetos**

<br/><br/>

### **Abstração**
Abstração na orientação a objetos, é o conceito de você abstrair um sistema, isso é, você inserir apenas o que é necessário no contexto do seu sistema, por exemplo:

Um sistema de babearia não precisa do grau de escolaridade nem data de nascimento do cliente.</br>
Já o sistema de uma escola precisa.

### **Encapsulamento**
Consiste em esconder o que ocorre no seu código, por motivos de segurança e organização.<br/>
Isso ocorre geralmente ocultando uma função ou modificando algo na própria classe.
![Preview image](/Arquivos/encapsulamentoexemplo.png)
###### Imagem retirada do curso de .Net da DIO, de Leonardo Buta