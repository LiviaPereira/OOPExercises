using System;
using System.Globalization;

namespace FixacaoPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo r = new Retangulo();

            Console.WriteLine("Entre com a largura e altura do retângulo:");
            r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = r.Area();
            double perimetro = r.Perimetro();
            double diagonal = r.Diagonal();

            Console.WriteLine("AREA = " + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO = " + perimetro.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + diagonal.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();

            Funcionario f = new Funcionario();

            Console.WriteLine("Nome: ");
            f.Nome = Console.ReadLine();

            Console.WriteLine("Salário Bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Funcionário: " + f);
            Console.WriteLine();

            Console.WriteLine("Digite a porcentagem para aumentar o salário: ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f.AumentarSalario(porcentagem);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + f);
            Console.WriteLine();

            Aluno A = new Aluno();

            Console.WriteLine("Nome do Aluno: ");
            A.Nome = Console.ReadLine();

            Console.WriteLine("Digite as 3 notas do Aluno: ");
            A.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            A.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            A.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double notafinal = A.NotaFinal();
            double diferenca = A.DiferencaNotaFinal();

            Console.WriteLine("Nota Final: " + notafinal.ToString("F2", CultureInfo.InvariantCulture));

            if(notafinal >= 60)
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO, FALTARAM " + diferenca.ToString("F2", CultureInfo.InvariantCulture));
            }
            

        }

    }
}
