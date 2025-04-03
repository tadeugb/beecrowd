using System;

namespace beecrowd
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        public static void Menu()
        {
            System.Console.Write("Digite o número do exercício da atividade da Beecrowd (de 1000 a 3486): ");
            int op = int.Parse(Console.ReadLine() ?? "0");

            switch (op)
            {
                case 1:
                    Ex_1000();
                    break;
                default:
                    break;
            }
        }
        public static void Ex_1000()
        {
            System.Console.WriteLine("Hello World!");
            Menu();
        }
        public static void Ex_1001()
        {
            int a = int.Parse(Console.ReadLine() ?? "0");
            int b = int.Parse(Console.ReadLine() ?? "0");

            int soma = a + b;

            System.Console.WriteLine($"X = {soma}");
            Menu();
        }
        public static void Ex_1002()
        {
            double raio = double.Parse(Console.ReadLine() ?? "0");

            double area = 3.14159 * (raio * raio);

            System.Console.WriteLine($"A={area.ToString("F4")}");

            Menu();
        }
        public static void Ex_1003()
        {
            int numero_A = int.Parse(Console.ReadLine() ?? "0");
            int numero_B = int.Parse(Console.ReadLine() ?? "0");

            int soma = numero_A + numero_B;
            System.Console.WriteLine($"SOMA = {soma}");

            Menu();
        }
        public static void Ex_1004()
        {
            int numero_A = int.Parse(Console.ReadLine() ?? "0");
            int numero_B = int.Parse(Console.ReadLine() ?? "0");

            int soma = numero_A * numero_B;
            System.Console.WriteLine($"PROD = {soma}");

            Menu();
        }
        public static void Ex_1005()
        {
            double numero_A = double.Parse(Console.ReadLine() ?? "0");
            double numero_B = double.Parse(Console.ReadLine() ?? "0");

            double soma = ((numero_A * 3.5) + (numero_B * 7.5)) / 11;
            System.Console.WriteLine($"MEDIA = {soma.ToString("F5")}");

            Menu();
        }
        public static void Ex_1006()
        {
            double numero_A = double.Parse(Console.ReadLine() ?? "0");
            double numero_B = double.Parse(Console.ReadLine() ?? "0");
            double numero_C = double.Parse(Console.ReadLine() ?? "0");

            double soma = ((numero_A * 2) + (numero_B * 3) + (numero_C * 5)) / 10;
            System.Console.WriteLine($"MEDIA = {soma.ToString("F1")}");

            Menu();
        }
        public static void Ex_1007()
        {
            int numero_A = int.Parse(Console.ReadLine() ?? "0");
            int numero_B = int.Parse(Console.ReadLine() ?? "0");
            int numero_C = int.Parse(Console.ReadLine() ?? "0");
            int numero_D = int.Parse(Console.ReadLine() ?? "0");

            int diferenca = (numero_A * numero_B) - (numero_C * numero_D);
            System.Console.WriteLine($"DIFERENCA = {diferenca}");

            Menu();
        }
        public static void Ex_1008()
        {
            double fucionario = double.Parse(Console.ReadLine() ?? "0");
            double horas = double.Parse(Console.ReadLine() ?? "0");
            double salrio = double.Parse(Console.ReadLine() ?? "0");

            double valorDoSalrioFinal = horas * salrio;

            System.Console.WriteLine($"NUMBER = {fucionario}");
            System.Console.WriteLine($"SALARY = U$ {valorDoSalrioFinal.ToString("F2")}");

            Menu();
        }
        public static void Ex_1009()
        {
            string nome = Console.ReadLine() ?? "Desconhecido";
            double salrioFixo = double.Parse(Console.ReadLine() ?? "0");
            double totalDeVendasMes = double.Parse(Console.ReadLine() ?? "0");

            double valorTotalVendas = ((totalDeVendasMes * 15) / 100) + salrioFixo; // Se tiver duvidas como faz a questao de porcentagem coloque o valor que precisa * numero da porcetagem e depois divide por 100

            System.Console.WriteLine($"TOTAL = R$ {valorTotalVendas.ToString("F2")}");

            Menu();
        }

        public static void Ex_1010()
        {
            string[] input; //Declara um vetor de strings chamado input. Ele será usado para armazenar os dados digitados pelo usuário.

            input = (Console.ReadLine() ?? "").Split(' '); //Lê uma linha digitada no console e divide ela em partes com base nos espaços (Split(' ')). Exemplo de entrada: 12 1 5.30
            int cod1 = int.Parse(input[0]);
            int n1 = int.Parse(input[1]);
            double valor1 = double.Parse(input[2]);

            input = (Console.ReadLine() ?? "").Split(' '); //Lê uma linha digitada no console e divide ela em partes com base nos espaços (Split(' ')). Exemplo de entrada: 12 1 5.30
            int cod2 = int.Parse(input[0]);
            int n2 = int.Parse(input[1]);
            double valor2 = double.Parse(input[2]);

            double total = (n1 * valor1) + (n2 * valor2);
            System.Console.WriteLine("VALOR A PAGAR: R$ {0:F2}", total);

            Menu();
        }
        public static void Ex_1011()
        {
            double raio = double.Parse(Console.ReadLine() ?? "");

            double volume = (4.0 / 3) * 3.14159 * (raio * raio * raio);

            System.Console.WriteLine($"VOLUME = {volume.ToString("F3")}");

            Menu();
        }
        public static void Ex_1012()
        {
            string[] input;

            input = (Console.ReadLine() ?? "").Split(' ');
            double pontoFlutuanteA = double.Parse(input[0]);
            double pontoFlutuanteB = double.Parse(input[1]);
            double pontoFlutuanteC = double.Parse(input[2]);

            double triangulo = (pontoFlutuanteA * pontoFlutuanteC) / 2;
            double circulo = 3.14159 * (pontoFlutuanteC * pontoFlutuanteC);
            double trapezio = ((pontoFlutuanteA + pontoFlutuanteB) * pontoFlutuanteC) / 2;
            double quadrado = pontoFlutuanteB * pontoFlutuanteB;
            double retangulo = pontoFlutuanteA * pontoFlutuanteB;

            System.Console.WriteLine($"TRIANGULO: {triangulo.ToString("F3")}");
            System.Console.WriteLine($"CIRCULO: {circulo.ToString("F3")}");
            System.Console.WriteLine($"TRAPEZIO: {trapezio.ToString("F3")}");
            System.Console.WriteLine($"QUADRADO: {quadrado.ToString("F3")}");
            System.Console.WriteLine($"RETANGULO: {retangulo.ToString("F3")}");

            Menu();
        }
    }
}