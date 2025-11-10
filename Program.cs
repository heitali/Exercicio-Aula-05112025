// See https://aka.ms/new-console-template for more information
Decimal nota1FormatoNumero, nota2FormatoNumero, nota3FormatoNumero, media;
Console.WriteLine("Por favor, informe o nome do aluno.");
string nomeAluno = Console.ReadLine();
Console.WriteLine("Informe a 1ª nota.");
string nota1 = Console.ReadLine();
Console.WriteLine("Informe a 2ª nota.");
string nota2 = Console.ReadLine();
Console.WriteLine("Informe a 3ª nota.");
string nota3 = Console.ReadLine();

try
{
    nota1FormatoNumero = Convert.ToDecimal(nota1);
    nota2FormatoNumero = Convert.ToDecimal(nota2);
    nota3FormatoNumero = Convert.ToDecimal(nota3);
    media = (nota1FormatoNumero + nota2FormatoNumero + nota3FormatoNumero) / 3;
}
catch (FormatException e)
{
    Console.WriteLine("Nota(s) informada(s) com erro");
}
finally
{
    media = 0;
}

Console.WriteLine("A média apurada para " + nomeAluno + " é de " +  media);
