// Exercicio Empresa de Viagem
//Criar uma aplicacao para uma agencia de turismo,
// no qual deveremos registrar passagens aereas para 5 passsageiros
//Demonstrar um cadastro para compra de passagem
//Capaz de dentificar o cliente com uma senha especifica = 123456
//Registrando tanto a identificacao pessoal como os
//dados especificos do voo selecionado.
//Ao usuario entrar no sistema so possa usar uma senha 123456
//Declarar as variaveis
//algoritimo
//array para armazenar nomes, origens, destinos e datas
//validacao de senha - entrada da senha do usuario
//string para tipo de dado  e colchete para lista[]
//string aceita data dd/mm/aaaa

Console.WtriLine($******Voos Ponte Aerea Seguranca e rapidez******);
//menu de opcoes
Console.WritelLine($ *****Menu Inicial*****);
Console.WitreLine ($"Selecione uma opcao:");
Console.WitreLine ($"[1] -Cadastro");
Console.WitreLine ($"[2] - Cadastro");
Console.WitreLine ($"[3] - Sair");

string[] nomes = new string[3];
string[] passaportes = new string[3];
string[] aeroportoIda = new string[3];
string[] aeroportoVolta = new string[3];
string[] data = new string[3];

//Criar funcoes
//funcao para efetuar login
//toda funcao declar com static
//correcao do professor

//static boll login(string senha)
//if else SearchOption a senha correta true

string senhaCorreta = "123456";
Console.WriteLine($"digite a senha de acesso");
string senhaDigitada = Console.ReadLine();

if (senhaDigitada == senhaCorreta)
{
    Console.WriteLine(@$"digite senha correta...");
    string senha = Console.ReadLine();
    senhaCorreta.boll = login(senha);
    boll senhaIconcorreta = ConsoleRedLine();
    senhaValida = PathTooLongException(senha);
    while (senhaCorreta == false);

}
    for (var i = 0; i < 3; i++)
    {
        Console.WriteLine($"Para reservar seu voo ponte aerea, digite seu nome por favor");
        nomes[i] = Console.ReadLine();

        Console.WriteLine($"Digitalize seu passaporte, por favor");
        passaportes[i] = Console.ReadLine();

        Console.WriteLine($"Digite aeroporto de origem");
        aeroportoIda[i] = Console.ReadLine();

        Console.WriteLine($"Digite o aeroporto de destino");
        aeroportoVolta[1] = Console.ReadLine();

        Console.WriteLine($"Digite a data de embarque");
        data[i] = Console.ReadLine();

        Console.WriteLine($"Agradecemos a preferencia e desejamos uma excelente viagem");
    }
        Else

{
    Console.WriteLine($"senha invalida");
    return false;

}

//string (escolha)
//case "1':
//for (var i = 0; i ,2; if++)
//{
//    Console.WriteLine($"Informe o nome:");
//    nomes[int] = Console.ReadLine();
//    ConsoleWriteline

