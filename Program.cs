Console.Clear();

Console.WriteLine("--- Combustível para Abastecimento: Etanol ou Gasolina ---");


Console.Write("Registre o preço do Etanol (R$)....: ");
decimal Etanol = Convert.ToDecimal(Console.ReadLine());

Console.Write("Registre o preço da Gasolina (R$)....: ");
decimal Gasolina = Convert.ToDecimal(Console.ReadLine());

string recomendacao;

double razao = RazaoEtanolGasolina(Etanol, Gasolina);

if (AbastecerComGasolina(razao))
{
    recomendacao = "Gasolina";
}
else
{
    recomendacao = "Etanol";
}


Console.WriteLine($"\nO preço do etanol é equivalente a {razao:P1} do preço da gasolina.");
Console.WriteLine($"\nRecomendação: Faça o abastecimento com {recomendacao.ToUpper()}.");

double RazaoEtanolGasolina(decimal valorEtanol, decimal valorGasolina)
{
    return Convert.ToDouble(valorEtanol / valorGasolina);
}
bool AbastecerComGasolina(double razao)
{
    const double MinRazaoUsoGasolina = 0.73;
    return razao >= MinRazaoUsoGasolina;
}
