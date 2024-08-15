//int numero = 10;
//double pi = 3.1414;
//char letra = 'A';
//bool isTrue = true;
//string mensagem = "Olá, mundo!";
//
//var numero3 = 10;
//
//double outroNumero = numero;
//
//int terraDeAreia = (int) pi;
//
//Console.WriteLine(pi);
//Console.WriteLine(terraDeAreia);
//
//int numero2 = 5;
//
//string texto = Convert.ToString(numero2);
//
//
//int x;
//Console.WriteLine("Digitar o valor de X:");
//x = Convert.ToInt32(Console.ReadLine());
//// Usando concatenação
//Console.WriteLine("O usuário digitou: " + x + "parabéns");
////Interpoçação de strings
//Console.WriteLine($"O usuário digitou {x} parabéns!");
////Usando Placeholders
//Console.WriteLine("O usuário digitou {0} parabéns!", x);
//



int primeiroNumero, segundoNumero;
int soma;
int subtracao;
int multiplicacao;
double divisao;

Console.WriteLine("Digite o valor do primeiro número:");
primeiroNumero = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o valor do segundo número");
segundoNumero = Convert.ToInt32(Console.ReadLine());

divisao = (double) primeiroNumero / segundoNumero;
Console.WriteLine($"O valor da divisão entre {primeiroNumero} e {segundoNumero} é igual a  {divisao}");
Console.WriteLine("O valor da divisão entre: " + primeiroNumero + " e " + segundoNumero + " é igual a: " + divisao);
Console.WriteLine("O valor da divisão entre {0} e {1} é igual a: {2}", primeiroNumero, segundoNumero , divisao);

soma = primeiroNumero + segundoNumero;
Console.WriteLine($"O valor da Soma entre {primeiroNumero} e {segundoNumero} é igual a {soma}");
Console.WriteLine("O valor da Soma entre: " + primeiroNumero + " e " + segundoNumero + " é igual a: " + soma);
Console.WriteLine("O valor da Soma entre {0} e {1} é igual a: {2}", primeiroNumero, segundoNumero , soma);


subtracao = primeiroNumero - segundoNumero;
Console.WriteLine($"O valor da Subtração entre {primeiroNumero} e {segundoNumero} é igual a {subtracao}");
Console.WriteLine("O valor da Subtração entre: " + primeiroNumero + " e " + segundoNumero + " é igual a: " + subtracao);
Console.WriteLine("O valor da Subtração entre {0} e {1} é igual a: {2}", primeiroNumero, segundoNumero , subtracao);

multiplicacao = primeiroNumero * segundoNumero;
Console.WriteLine($"O valor da Multiplicação entre {primeiroNumero} e {segundoNumero} é igual a {multiplicacao}");
Console.WriteLine("O valor da Multiplicação entre: " + primeiroNumero + " e " + segundoNumero + " é igual a: " + multiplicacao);
Console.WriteLine("O valor da Multiplicacao entre {0} e {1} é igual a: {2}", primeiroNumero, segundoNumero , multiplicacao);
