using System;

namespace precodagasolina
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Atividade 2");

            Console.WriteLine("Qual o tipo de combustivel G - Gasolina/A - Alcool");
            string tipo = Console.ReadLine();

            Console.WriteLine("Digite a quantidade de litros que deseja abastecer: ");
            float litros = float.Parse(Console.ReadLine());

            //Declaraçao de variaveis
                float percentualDesconto;
                float ValorApagar;
                float ValorBruto;
                float TotalDesconto;
                float precodagasolina=5.3f;
                float precodoalcool=4.9f;

            

            switch (tipo.ToLower())
            {
                

                case "a":
                    if (litros<=20)
                    {
                        percentualDesconto=0.03f;
                    }else{
                        percentualDesconto=0.05f;
                    }
                    TotalDesconto = (litros * precodoalcool)*percentualDesconto;
                    ValorBruto = litros * precodoalcool;
                    ValorApagar = ValorBruto-TotalDesconto;
                    Console.WriteLine($"Valor a ser pago é de {ValorApagar}");
                break;

                case "g":
                    if (litros<=20)
                    {
                        percentualDesconto=0.04f;
                    }else{
                        percentualDesconto=0.06f;
                    }
                    TotalDesconto = (litros * precodagasolina)*percentualDesconto;
                    ValorBruto = litros * precodagasolina;
                    ValorApagar = ValorBruto-TotalDesconto;
                    Console.WriteLine($"Valor a ser pago é de {ValorApagar}");
                break;

                default:
                    Console.WriteLine("Opção Inválida");
                break;
            }
        }
    }
}
