// fazer programa para ler nome e salario de dois Funcionarios.Depois mostrar o salario medio dos  funncionarios

using SalarioMEdio;
using System;
using System.Globalization;
using System.Net.Http.Headers;


namespace MyNamespace {
    class MyClass {
        static void Main(string[] args) {

            Funcionarios f1 = new Funcionarios();
            Funcionarios f2 = new Funcionarios();

            Console.WriteLine("Digite o nome  Primeiro Funcionario: ");
            f1.Nome = (Console.ReadLine());
            Console.WriteLine("Digite o Salario do Primeiro Funcionario:");
            f1.Salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("\n--------------------------\n");
            Console.WriteLine("Digite o nome  Segundo  Funcionario: ");
            f2.Nome = (Console.ReadLine());
            Console.WriteLine("Digite o Salario do Segundo  Funcionario:");
            f2.Salario = double.Parse (Console.ReadLine(),CultureInfo.InvariantCulture);

            double media = (f1.Salario + f2.Salario) / 2;
            Console.WriteLine("A media Salaria dos dois Funcionarios é: " + media.ToString("F3",CultureInfo.InvariantCulture));


        }
    }
}
