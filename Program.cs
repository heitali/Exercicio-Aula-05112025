// See https://aka.ms/new-console-template for more information
Double nota1FormatoNumero, nota2FormatoNumero, nota3FormatoNumero, media;
Console.WriteLine("Por favor, informe o nome do aluno.");
string nomeAluno = Console.ReadLine();
Console.WriteLine("Informe a 1ª nota.");
string nota1 = Console.ReadLine();
Console.WriteLine("Informe a 2ª nota.");
string nota2 = Console.ReadLine();
Console.WriteLine("Informe a 3ª nota.");
string nota3 = Console.ReadLine();

nota1FormatoNumero = Convert.ToDouble(nota1);
nota2FormatoNumero = Convert.ToDouble(nota2);
nota3FormatoNumero = Convert.ToDouble(nota3);

media = (nota1FormatoNumero + nota2FormatoNumero + nota3FormatoNumero) / 3;
Console.WriteLine("A média apurada para " + nomeAluno + " é de " +  media);
