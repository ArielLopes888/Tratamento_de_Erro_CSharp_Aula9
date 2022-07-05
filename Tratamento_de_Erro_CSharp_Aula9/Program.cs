double somarValor()
{
    
    try
    {
        Console.WriteLine("Digite o primeiro valor: ");
        double valor = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo valor: ");
        double valor2 = double.Parse(Console.ReadLine());
        return valor + valor2;
    }
    catch(Exception ex)
    {
        Console.WriteLine("Você deve digitar um número -> " + ex.Message);
    }
    return somarValor();
}

double subtrairValor()
{
    try
    {
        Console.WriteLine("Digite o primeiro valor: ");
        double valor = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo valor: ");
        double valor2 = double.Parse(Console.ReadLine());
        return valor - valor2;
    }
    catch (Exception ex)
    {
        Console.WriteLine("Você deve digitar um número -> " + ex.Message);
    }
    return subtrairValor();
}

double dividirValor()
{
    try
    {
        Console.WriteLine("Digite o primeiro valor: ");
        double valor = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo valor: ");
        double valor2 = double.Parse(Console.ReadLine());
        if (valor2 == 0)
        {
            throw new DivideByZeroException(message: "Não pode ser zero");
        }
        return valor / valor2;
    }
    catch (Exception ex)
    {
        Console.WriteLine("Você deve digitar um número -> " + ex.Message);
    }
    return dividirValor();
}

double multiplicarValor()
{
    try
    {
        Console.WriteLine("Digite o primeiro valor: ");
        double valor = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo valor: ");
        double valor2 = double.Parse(Console.ReadLine());
        return valor * valor2;
    }
    catch (Exception ex)
    {
        Console.WriteLine("Você deve digitar um número -> " + ex.Message);
    }
    return multiplicarValor();
}

void menuCalculadora()
{
    bool continua = true;
    do
    {
        Console.WriteLine("Menu de opções da calculadora");
        Console.WriteLine("1 - Somar");
        Console.WriteLine("2 - Subtrair");
        Console.WriteLine("3 - Multiplicar");
        Console.WriteLine("4 - Dividir");
        Console.WriteLine("0 - Terminar");
        Console.WriteLine("Sua opção: ");
        string op = Console.ReadLine();
        
        switch (op)
        {
            case "0":
                continua = false;
                Console.WriteLine("Programa encerrado");
                break;
            case "1":
                Console.WriteLine($"O resultado é: {somarValor()}");
                break;
            case "2":
                Console.WriteLine($"O resultado é: {subtrairValor()}");
                break;
            case "3":
                Console.WriteLine($"O resultado é: {multiplicarValor()}");
                break;
            case "4":
                Console.WriteLine($"O resultado é: {dividirValor()}");
                break;
        }
    }while(continua == true);
}

menuCalculadora();