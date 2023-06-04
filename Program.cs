Console.Clear();
decimal etanol, gasolina;

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("--- Etanol ou Gasolina? ---\n");
Console.Write("Digite o preço do etanol (R$).....: ");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Red;
etanol = Convert.ToDecimal(Console.ReadLine());
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Green;
Console.Write("Digite o preço da gasolina (R$)...: ");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Red;
gasolina = Convert.ToDecimal(Console.ReadLine());
Console.ResetColor();


string recomendacao;

if (AbastecerGasolina(etanol, gasolina))
{
    recomendacao = "Gasolina";
}
else
{
    recomendacao = "Etanol";
}

double razao = RazaoEtanolGasolina(etanol, gasolina) * 100;

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine($"\nO preço do etanol corresponde a {razao:N1}% do preço da gasolina");
Console.WriteLine($"Recomendação: Abasteça com {recomendacao.ToUpper()}.");
Console.ResetColor();

double RazaoEtanolGasolina(decimal precoEtanol, decimal precoGasolina)
{
    return Convert.ToDouble(precoEtanol / precoGasolina);
}

bool AbastecerGasolina(decimal precoEtanol, decimal precoGasolina)
{
    const double RazaoGasolina = 0.73;
    return RazaoEtanolGasolina(precoEtanol, precoGasolina) >= RazaoGasolina;
}
