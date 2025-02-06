Console.WriteLine("Digite seu peso:");
double peso = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("\nDigite sua altura:");
double altura = Convert.ToDouble(Console.ReadLine());

double imc = peso / (altura * altura);


switch (imc)
{
    case (> 40.0):
        Console.WriteLine($"IMC: {imc:F2}\nObesidade grau III");
        break;

    case (>= 35.0 and <= 39.9):
        Console.WriteLine($"IMC: {imc:F2}\nObesidade grau II");
        break;

    case (>= 30.0 and <= 34.9):
        Console.WriteLine($"IMC: {imc:F2}\nObesidade grau I");
        break;

    case (>= 25.0 and <= 39.9):
        Console.WriteLine($"IMC: {imc:F2}\nSobrepreso");
        break;

    case (>= 18.6 and <= 24.9):
        Console.WriteLine($"IMC: {imc:F2}\nNormal");
        break;

    default:
        Console.WriteLine($"IMC: {imc:F2}\nAbaixo do normal");
        break;
}



Console.ReadKey();