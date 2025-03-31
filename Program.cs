
Console.WriteLine("Digite seu salário para calcularmos o seu FGTS: ");
    double salario = Convert.ToDouble(Console.ReadLine()!);
Console.WriteLine($"Salário (R$):{salario} ");
    double fgts = 8 * (salario / 100);
Console.WriteLine($"FGTS: {fgts} ");