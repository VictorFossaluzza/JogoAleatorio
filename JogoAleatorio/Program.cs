

Console.WriteLine(@"
░░░░░██╗░█████╗░░██████╗░░█████╗░  ░█████╗░██╗░░░░░███████╗░█████╗░████████╗░█████╗░██████╗░██╗░█████╗░
░░░░░██║██╔══██╗██╔════╝░██╔══██╗  ██╔══██╗██║░░░░░██╔════╝██╔══██╗╚══██╔══╝██╔══██╗██╔══██╗██║██╔══██╗
░░░░░██║██║░░██║██║░░██╗░██║░░██║  ███████║██║░░░░░█████╗░░███████║░░░██║░░░██║░░██║██████╔╝██║██║░░██║
██╗░░██║██║░░██║██║░░╚██╗██║░░██║  ██╔══██║██║░░░░░██╔══╝░░██╔══██║░░░██║░░░██║░░██║██╔══██╗██║██║░░██║
╚█████╔╝╚█████╔╝╚██████╔╝╚█████╔╝  ██║░░██║███████╗███████╗██║░░██║░░░██║░░░╚█████╔╝██║░░██║██║╚█████╔╝
░╚════╝░░╚════╝░░╚═════╝░░╚════╝░  ╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚═╝░░░╚═╝░░░░╚════╝░╚═╝░░╚═╝╚═╝░╚════╝░");

Console.WriteLine("\nTente adivinhar o numero de 1 a 200");

var rand = new Random();

int numeroAleatorio = rand.Next(1, 200);

bool respostaCerta = false;
do
{

    Console.Write("Digite um numero: ");
    int numeroDigitado = Convert.ToInt32(Console.ReadLine());

    if (numeroDigitado == numeroAleatorio)
    {
        respostaCerta = true;
    }
    else if (numeroDigitado > numeroAleatorio)
    {
        Console.WriteLine("O numero aleatorio é menor");
    }
    else if (numeroDigitado < numeroAleatorio)
    {
        Console.WriteLine("O numero aleatorio é maior");
    }



} while (!respostaCerta);

Console.WriteLine("Parabéns voce acertou o numero é "+ numeroAleatorio);


