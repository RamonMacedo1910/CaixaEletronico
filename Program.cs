decimal ValorDividido, ValorSacado;

int nota1, nota2, nota5, nota10, nota20, nota50, nota100, nota200;

Console.WriteLine("-=-Caixa Eletrônico-=-");




Console.Write("Por favor, digite um valor a ser sacado:");

ValorSacado = Convert.ToDecimal(Console.ReadLine());





    if (ValorSacado <= 0)

        {

            Console.WriteLine("Impossível realizar o saque.");

            return;

        }




    if (ValorSacado % 1 > 0)

        {

            Console.WriteLine("Nâo tem moeda.");

            return;

        }




ValorDividido = ValorSacado;




nota200 = (int)(ValorDividido / 200);

ValorDividido = ValorDividido % 200;




nota100 = (int)(ValorDividido / 100);

ValorDividido = ValorDividido % 100;




nota50 = (int)(ValorDividido / 50);

ValorDividido = ValorDividido % 50;




nota20 = (int)(ValorDividido / 20);

ValorDividido = ValorDividido % 20;




nota10 = (int)(ValorDividido / 10);

ValorDividido = ValorDividido % 10;




nota5 = (int)(ValorDividido / 5);

ValorDividido = ValorDividido % 5;




nota2 = (int)(ValorDividido / 2);

ValorDividido = ValorDividido % 2;




nota1 = (int)(ValorDividido / 1);

ValorDividido = ValorDividido % 1;





Console.WriteLine("\n0 o caixa deve entregar:");




if (nota200 > 0) Console.WriteLine($"{nota200} nota(s) de R$200,00");

if (nota100 > 0) Console.WriteLine($"{nota100} nota(s) de R$100,00");

if (nota50 > 0) Console.WriteLine($"{nota50} nota(s) de R$50,00");

if (nota20 > 0) Console.WriteLine($"{nota20} nota(s) de R$20,00");

if (nota10 > 0) Console.WriteLine($"{nota10} nota(s) de R$10,00");

if (nota5 > 0) Console.WriteLine($"{nota5} nota(s) de R$5,00");

if (nota2 > 0) Console.WriteLine($"{nota2} nota(s) de R$2,00");

if (nota1 > 0) Console.WriteLine($"{nota1} nota(s) de R$1,00");






