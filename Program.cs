using System;
using System.Collections.Generic;
using Teste.Entities;
using System.Globalization;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> lista = new List<Funcionario>();   
 
            Console.Write("Entre com o numero de Funcionários: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Funcionário #{i} data: ");
                Console.Write("Terceirizado (y/n)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Horas: ");
                int horas = int.Parse(Console.ReadLine());
                Console.Write("Valor por hora: ");
                double valoPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if(ch == 'y')
                {
                    Console.Write("Carga Adicional: ");
                    double cargaAdiciional = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    lista.Add(new TerceiroFuncionario(nome, horas, valoPorHora, cargaAdiciional));

                }

                else
                {
                    lista.Add(new Funcionario(nome,horas,valoPorHora));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PAGAMENTOS: ");
            foreach(Funcionario funcionario in lista)
            {
                Console.WriteLine(funcionario.Nome + " - $ " + funcionario.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }
            
        }
    }
}