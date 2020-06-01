using System;

namespace Aula07Encapsulamento
{
    public class mastercard : cartão
    {
        public int parcelas { get; set; }
        public void ComprarComDescontoMaster(float desconto){
            cvc = 456;
            Console.WriteLine($"Aplicando desconto de {desconto}%, no total de {parcelas} parcelas. Faça bom uso :)");
        }
    }
}