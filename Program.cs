double altura, conta1, conta2;

string sexo;

Console.Clear();

Console.WriteLine("--- Descubra seu peso ideal ---");

Console.Write("Digite sua altura em m..........:");
    altura = Convert.ToDouble(Console.ReadLine()); 

Console.Write("Sexo [M]asculino / [F]eminino...:");
    sexo = Console.ReadLine().ToUpper();

conta1 = altura * 72.7 - 58;

conta2 = altura * 62.1 - 44.7;

if ( sexo == "M")
{
    Console.WriteLine($"Seu peso ideal é {conta1:N2}Kg");
}
    else if ( sexo == "F")
{
    Console.WriteLine($"Seu peso ideal é {conta2:N2}Kg");
}