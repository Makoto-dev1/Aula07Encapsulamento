using System;

namespace Aula07Encapsulamento
{
    public class MasterCard : Cartao
    {
        public int parcelas { get; set; }

        public void ComprarComDescontoMasterCard(float desconto){
            // Utilizando encapsulamento com assinatura "protected" 
            cvv = "123";

            Console.WriteLine($"Compra Realizada Com {parcelas} Parcelas e R${desconto} De Desconto ");
        }
    }
}