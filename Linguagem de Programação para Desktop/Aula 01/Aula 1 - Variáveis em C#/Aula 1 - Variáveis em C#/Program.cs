// See https://aka.ms/new-console-template for more information

Console.Title = "Jarvis Baiano APP C#";
Console.WriteLine("Hello, info07M");

String Nome;
String Sobrenome;
Int32 AnoNascimento;
Int32 AnoAtual;

Console.Write("Digite o seu nome: ");
Nome = Console.ReadLine();

Console.Write("Digite o seu sobrenome: ");
Sobrenome = Console.ReadLine();

Console.WriteLine("Olá como está ? " + Nome + " " + Sobrenome);

Console.Write("Digite o ano de nascimento: ");
AnoNascimento = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o ano atual: ");
AnoAtual = Convert.ToInt32(Console.ReadLine());

Int32 IdadeCalculada = AnoAtual - AnoNascimento;

Console.WriteLine("Nossa esta com essa idade! " + IdadeCalculada + "Anos");
Console.Beep();

Console.ReadKey();

Decimal ValorHora = 0;
Decimal HorasTrabalhadas = 0;
Decimal ValorReceber = 0;

Console.Write("Informe seu valor/hora: ");
ValorHora = Convert.ToDecimal(Console.ReadLine());

Console.Write("Informe a quantidade de horas trabalhadas: ");
HorasTrabalhadas = Convert.ToDecimal(Console.ReadLine());

ValorReceber = HorasTrabalhadas * ValorHora;

Console.WriteLine(Nome + ", Valor a Receber: R$ " + ValorReceber);
Console.Beep();

Console.ReadKey();
