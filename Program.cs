using ExemploExplorando.Models;
using System.Globalization;
using Newtonsoft.Json;

//Primeiro tipo de instanciar
Pessoa p1 = new Pessoa(nome: "Gabriel", sobrenome: "Percam");

//Segundo tipo
Pessoa p2 = new Pessoa();
p2.Nome = "Leonardo";
p2.Sobrenome = "Buta";

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();

Console.WriteLine("\nTestando remoção\n");

cursoDeIngles.RemoverAluno(p1);
cursoDeIngles.ListarAlunos();

// p1.Nome = "Gabriel";
// p1.Sobrenome = "Percam";
// p1.Idade = 19;
// p1.Apresentar();

//Alterando a cultura do sistema (e mudando a moéda)
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

decimal valorMonetario = 1582.40m;

Console.WriteLine($"{valorMonetario:C}");
Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")));
Console.WriteLine(valorMonetario.ToString("C8"));
Console.WriteLine(valorMonetario.ToString("N8"));

double porcentagem = .3421;

Console.WriteLine(porcentagem.ToString("P"));

int numeros = 123456;

Console.WriteLine(numeros.ToString("##-##/##"));

DateTime data = DateTime.Now;

Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));
Console.WriteLine(data.ToShortDateString());

DateTime datateste = DateTime.Parse("05/29/2022 19:05:23");

Console.WriteLine(datateste);

String datatestedois = "29/03/2022";

bool sucesso = DateTime.TryParseExact(datatestedois, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime datad);

if(sucesso){
    Console.WriteLine($"Conversão com sucesso {datad.ToString("dd/MM/yyyy")}");
}
else{
    Console.WriteLine($"{datatestedois} não é uma data válida");
}


try
{
    //Leitura de arquivo

    string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

    foreach (string linha in linhas)
    {
        Console.WriteLine(linha);
    }

}catch(FileNotFoundException ex){
    Console.WriteLine($"Ocorreu uma exceção: Arquivo não encontrado. {ex.Message}");
}catch(DirectoryNotFoundException ex){
    Console.WriteLine($"Ocorreu uma exceção: Diretório não encontrado. {ex.Message}");
}
catch(Exception ex){
    //Erro genérico é erro não previstos
    Console.WriteLine($"Ocorreu uma exceção genérica: {ex.Message}");
}finally{
    //Finally é executado independente se ocorre erro ou não
    Console.WriteLine("Chegou até aqui");
}

new ExemploExcecao().Metodo1();

Filasqueues filaq = new Filasqueues();

filaq.fila.Enqueue(2);
filaq.fila.Enqueue(7);
filaq.fila.Enqueue(1);
filaq.fila.Enqueue(99);

foreach(int item in filaq.fila){
    Console.WriteLine("Fila: " + item);
}

Console.WriteLine($"Removendo o elemento {filaq.fila.Dequeue()}\n");

foreach(int item in filaq.fila){
    Console.WriteLine("Fila: " + item);
}

Console.WriteLine("\n");

Pilhastack pilhas = new Pilhastack();

pilhas.pilha.Push(4);
pilhas.pilha.Push(6);
pilhas.pilha.Push(8);
pilhas.pilha.Push(10);

foreach(int itemdnv in pilhas.pilha){
    Console.WriteLine("Pilhas: " + itemdnv);
}

Console.WriteLine($"Removendo o elemento do topo {pilhas.pilha.Pop()}");

foreach(int itemdnv in pilhas.pilha){
    Console.WriteLine("Pilhas: " + itemdnv);
}


//Tudo que for feito no dictionary deve ser considerando a key, ela não pode se repetir
Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("SP", "São Paulo");
estados.Add("BA", "Bahia");
estados.Add("MG", "Minas Gerais");

//O KeyValuePair<string, string> pode ser substituído por var, e ele irá reconhecer os tipos
foreach(KeyValuePair<string, string> item in estados){
    Console.WriteLine($"Chave: {item.Key} valor: {item.Value}");
}

Console.WriteLine("------------------------");

estados.Remove("BA");
estados["SP"] = "São Pauo";

foreach(KeyValuePair<string, string> item in estados){
    Console.WriteLine($"Chave: {item.Key} valor: {item.Value}");
}

Console.WriteLine("Verificando se uma key existe\n");
string Chave = "BA";

if(estados.ContainsKey(Chave)){
    Console.WriteLine("A chave " + Chave + " já existe!");
}
else{
    Console.WriteLine("A chave " + Chave + " está livre.");
}

Console.WriteLine(estados["MG"]);

//Primeira maneira de declarar uma tupla
(int, string, string, decimal) tupla = (19, "Gabriel", "Percam", 1.80m);

//Segunda maneira de declarar uma tupla
ValueTuple<int, string, string, decimal> outroexemplotupla = (19, "Gabriel", "Percam", 1.80m);

//Terceira maneira de declarar uma tupla
var outroexemplotuplacreate = Tuple.Create(19, "Gabriel", "Percam", 1.80m);

Console.WriteLine($"Idade: {tupla.Item1}");
Console.WriteLine($"Nome: {tupla.Item2}");
Console.WriteLine($"Sobrenome: {tupla.Item3}");
Console.WriteLine($"Altura: {tupla.Item4}");

LeituraArquivo arquivolei = new LeituraArquivo();

//O uso do _ serve como descarte de informação
var (sucessos, linhasArquivos, _) = arquivolei.LerArquivo("Arquivos/arquivoLeitura.txt");

if(sucessos){

    //Console.WriteLine("Quantidade de linhas no arquivo: " + quantidadeLinhas);

    foreach(string linha in linhasArquivos){
        Console.WriteLine(linha);
    }
}
else{
    Console.WriteLine("Não foi possível ler o arquivo");
}

Pessoa p4 = new Pessoa("Gabe", "Pece");

//desconstruindo
(string nome, string sobrenome) = p4;

Console.WriteLine($"{nome} e {sobrenome}");



//IF TERNÁRIO

int numbero = 20;

Console.WriteLine("\nIf normal");
if(numbero % 2 == 0){
    Console.WriteLine("O número " + numbero + " é par!");
}
else{
    Console.WriteLine("O número " + numbero + " é impar!");
}

Console.WriteLine("\nIf ternário");
bool epar = false;

epar = numbero % 2 == 0;

Console.WriteLine($"O número {numbero} é " + (epar ? "par" : "impar"));

//Json

DateTime dataAtual = DateTime.Now;

//List<Venda> ListaVenda = new List<Venda>();

// Venda v1 = new Venda(1, "Material de escritorio", 25.00M, dataAtual);
// Venda v2 = new Venda(2, "Licença de Software", 300.00M, dataAtual);

// ListaVenda.Add(v1);
// ListaVenda.Add(v2);


//string serializado = JsonConvert.SerializeObject(ListaVenda, Formatting.Indented);

//File.WriteAllText("Arquivos/vendas.json", serializado);

//Console.WriteLine(serializado);

string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

foreach(Venda venda in listaVenda){
    Console.WriteLine($"\nId: {venda.Id}, Produto: {venda.Produto}, \nPreço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}" +
                      $"{(venda.Desconto.HasValue ? $", Desconto de {venda.Desconto}" : "")}\n");
}

//Tipos especiais

//Variáveis com "?" na frente são os que permitem receber vaores nulos
bool? desejaReceberEmail = null;

if(desejaReceberEmail.HasValue && desejaReceberEmail.Value){
    Console.WriteLine("O usuário optou por receber e-Mail");
}
else{
    Console.WriteLine("o usuário não respondeu, ou optou por não receber e-Mail.");
}

Console.WriteLine("\nTipo anônimo\n");

//Tipo anônimo
var TipoAnonimo = new { NomeTA = "Gabro", Surneim = "Piere", Alturata = 1.80 };

Console.WriteLine(TipoAnonimo.NomeTA);
Console.WriteLine(TipoAnonimo.Surneim);
Console.WriteLine(TipoAnonimo.Alturata);

Console.WriteLine("\nTipo anônimo em coleção\n");

var listaAnonima = listaVenda.Select(x => new { x.Produto, x.Preco });

foreach(var venda in listaAnonima){
    Console.WriteLine("Produto: " + venda.Produto + "// Preço: " + venda.Preco);
}

Console.WriteLine("\nVariável dinâmica\n");

//tipo se altera conforme necessário
dynamic variavelDinamica = 4;

Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()}, Valor {variavelDinamica}");

//Classe genérica

MeuArray<int> arrayinteiro = new MeuArray<int>();

arrayinteiro.AdicionarElementoArray(30);

Console.WriteLine(arrayinteiro[0]);


MeuArray<string> arraystring = new MeuArray<string>();

arraystring.AdicionarElementoArray("Test");

Console.WriteLine(arraystring[0]);

//Método de extensão 
int numburo = 20;

bool par = numburo.Epar();

string mensag = "O número " + numburo + " é " + (par ? "par" : "impar");

Console.WriteLine(mensag);

AlunoHeranca a1 = new AlunoHeranca("Gabo");

a1.Idade = 19;
a1.nota = 8.5;

a1.Apresentar();

AlunoPaisHeranca aph1 = new AlunoPaisHeranca("Nomenilson");

aph1.Apresentar();

ProfessorHeranca prof1 = new ProfessorHeranca("Professildo");

prof1.Idade = 39;
prof1.salario = 1000;

prof1.Apresentar();

Corrente ct = new Corrente();

ct.creditar(500);
ct.ExibirSaldo();