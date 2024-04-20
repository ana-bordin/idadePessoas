//2. faça um programa que receba a idade de 10 pessoas e mostre a quantidade de maiores e menores de
//idade;

int idade = 0, maior = 0, menor = 0, quant = 10, aux = 0;

Console.WriteLine("Digite a idade de 10 pessoas e descubra quantos maiores e menores de idade" +
        " esse conjunto possui");
do
{
    maior = 0; 
    menor = 0; 
    quant = 10;

    for (int i = 10; i > 0; i--)
    {
        Console.WriteLine($"Digite a idade da {quant}ª pessoa:");
        idade = int.Parse(Console.ReadLine());
        if (idade >= 0 && idade < 120)
        {
            if (idade < 18)
            {
                menor++;
            }
            else
            {
                maior++;
            }
            quant--;
        }
        else
        {
            Console.WriteLine($"Digite uma idade REAL!");
        }
    }
    Console.WriteLine($"---\nNesse grupo há: \n{maior} pessoas maior de idade;\n{menor} pessoas menor de " +
        $"idade;\n---\nPara continuar digite 0;\nPara parar digite número 1;");
    aux = int.Parse(Console.ReadLine());
}
while (aux == 0);