# dotnet-DIO anotações

## **Estrutura de Projeto**
<br/>

### **.CJPROJ**
Arquivos CSPROJ (C Sharp Project) são arquivos de informações e configurações para cada projeto em C Sharp, também conhecido como Metadados, sua estrutura é em XML.

**Exemplo de referência de um projeto para outro em C#**

![referência](Arquivos/referenci.png)

### **Arquivo Solution**
Os arquivos Solution (Solução) tem como finalidade interligar diferentes projetos.
Exemplo:<br/>
>``Projeto1``</br>
>``Projeto2``</br>
>**``Projetos.sln``**</br>

A conexão entre o projeto1 e o projeto2 é realizada através da Solução, assim organizando e separando funcionalidades de seu software.

### **Commons**
Projetos que recebem a nomenclatura de Commons são os que podem ser utilizados em mais de um projeto, isso é, ele recebe códigos que podem servir como uma base.

Exemplo de uma estrutura que recebe uma Solution que vincula 3 projetos, sendo um deles uma common
![Exemplo](Arquivos/estrutura.png)
###### Imagem retirada do curso de .Net da DIO, de Leonardo Buta

<br/><br/>

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
<br/>

### **Herança**
O conceito de herança consiste em criar uma classe(classe mãe) com atributos e métodos que podem ser passados para outras classes(classes filhas), assim evitando repetição de código.

**Por exemplo:** Aluno e Professor possuem os atributos Nome:string, Idade:int e o método apresentar.<br/>
Então pode ser criado uma classe chamada Pessoa, que recebe Nome:string, Idade:int e o apresentar(), E assim herdando para as classes filhas (Aluno e Professor) os atributos e métodos, apenas inserindo em cada classe o que for necessário.

Para realizar uma herança se utiliza dois pontos

public class Pessoa{
    Nome;
    Idade;

    Apresentar();
}

### **A classe Aluno herda de Pessoa** <br/>
public class Aluno : Pessoa{

}

**Classe Program.cs**
Aluno a1 = new Aluno();

a1.Nome;<br/>
a1.Idade;<br/>
a1.Apresentar();

#### **Mas, como Aluno tem atributos e método sendo que está vazia?**
Porque ela está herdando da classe Pessoa.

### **Polimorfismo**
Consiste em distintas classes derivadas da mesma superclasse chamarem o mesmo método, mas cada subclasse pode apresentar de uma forma diferente, isso é, sobrepondo o método original.

Para permitir que um método seja sobrescrito, é colocando um "virtual" na declaração dele, e um override na sub-classe. Por exemplo: <br/>

public virtual void Apresentar(){
     //Função
}

public class Aluno : Pessoa{

    public override void Apresentar(){
        //Edição
    }

}

### **Classe Abstrata**
Uma classe abstrata tem como objetivo ser exclusivamente herdada, e não pode ser instanciada.<br/>
Assim sendo utilizada como um "molde", um método também deve ser abstrato, assim obrigatoriamente realizando um polimorfismo.

![Preview image](/Arquivos/classeabst.png)
###### Imagem retirada do curso de .Net da DIO, de Leonardo Buta
<br/>

### **Classe Selada**
A classe selada tem como objetivo impedir que outras classes herdem dela, assim
ela poder herdar mas não permite ser herdada

Para selar uma classe é só colocar sealed na classe<br/>

public **sealed** class NomeClasse{

}
<br/><br/>

#### **Método selado**
Também pode ocorrer de um método ser selado, impedindo de ser sobrescrito

public **sealed** void Funcao(){

}

### **Classe Object**
A classe System.Object é a mãe de todas as classes, ela tem como objetivo prover serviços de baixo nível para as suas classes filhas.

### **Interface**
Uma interface tem como objetivo prover um padrão, assim como uma classe abstrata, ela não pode ser instanciada, mas não entra no conceito de herança.<br/>
Uma interface é chamada de implementação, e funciona como um "contrato", uma classe que chama uma interface deve obrigatoriamente implementar tudo o que for da Interface, e, elas também permitem que uma classe chame mais de uma interface.<br/>
De preferência, elas devem receber um nome que inicie com I

## **Banco de dados**
Banco de dados é a alocação das informações de registros de usuários, informações, arquivos, dados e etc...
![Preview image](/Arquivos/bd1.png)
###### Imagem retirada do curso de .Net da DIO, de Leonardo Buta
<br/>
O sistema de banco de dados deve ser robusto, pois ele irá servir diversos sistemas, seja web, api, nuvem...
<br/>

### **Tipos de banco de dados**

<br/>

#### **Banco relacional:**
O tipo mais utilizado atualmente, armazenando dados estruturados em tabelas, colunas e linhas, que se relacionam entre si.

Quando altera o campo, todos os registros são alterados.

#### **Banco não relacional:**
Esse tipo não é organizado por tabela, e sim de maneira não estruturada ou semi-estruturada.

Não precisa editar outros registros caso algo seja alterado no campo de um.

<br/>

#### **DataBase Management System (DBMS)**
É um software utilizado para acessar, manipular e monitorar um sistema de banco de dados.

#### **SQL (Structured Query Language)**
É a linguagem de banco de dados usada para consultas e manipulações de dados.

![Comandos SQL](Arquivos/sqlcmds.png)

<br/>

#### **Database:**
É uma coleção de dados estruturados e agrupados, é composto de tabelas, procedures, views, etc.
Database é a separação dos bancos de dados de cada sistema.

#### **Tipos de dados em Banco de dados**

**1- String**

![Tipos Strings](Arquivos/bdstring.png)

**2- Inteiros**

![Tipos Int](Arquivos/bdint.PNG)

**3- Outros tipos numéricos**

![Outros tipos numéricos](Arquivos/bdtipos.PNG)

**4- Datetime**

![Datetime tipos](Arquivos/bddatetime.PNG)

**Constraints**
![Const](Arquivos/constraint.png)

**Stored Procedures**
São comandos que são armazenados no database

![Exemplo Procedures](Arquivos/procedure.png)

![Executando Procedure](Arquivos/procedureuso.png)

**Functions**
São códigos SQL que você pode salvar diretamente no banco de dados, semelhante a uma procedure, mas com usos específicos e limitações, como por exemplo, devem sempre ter um retorno e aceita apenas parâmetros de entrada.

![Exemplo Function](Arquivos/functionbd.png)

<br/>

# **REFORÇAR**

1. ~~Estrutura projeto C#~~ ``ADICIONADO``
2. ~~Referência de projeto~~ ``ADICIONADO``
3. Versões C#
4. Listas
5. Body Expressions
6. Construtores
7. Propriedade somente Leitura
8. DateTime
9. TryParse
10. Exceções
11. Filas
12. Pilha
13. Dictionary
14. Tuplas
15. Tuplas em métodos
16. Descartes
17. Desconstrutor
18. If ternário
19. Gerenciador de Pacotes Nuget
20. Serialização
21. manipulação de JSON
22. Coleções
23. JSON Viewer
24. Deserialização
25. Deserialização de objeto
26. Tipos especiais
27. tipos anônimos e nulos
28. tipo dinâmico
29. classe genérica
30. método de extensão
31. Stack e Heap
32. Limpeza de memória
33. gerenciamento de memória em C#

## POO

1. Paradigmas
2. Abstração
3. Encapsulamento
4. Herança
5. Polimorfismo
6. Polimorfismo em tempo de execução
7. Classe abstrata
8. Construtor por herança
9. classe selada
10. método selado
11. classe object 
12. interface
13. método padrão na interface

## Banco de dados
1. SQL Server