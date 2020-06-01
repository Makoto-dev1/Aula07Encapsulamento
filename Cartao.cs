using System;

namespace Aula07Encapsulamento
{
    public class Cartao
    {
        public string numero { get; set; }

        public string titular { get; set; }

        public string bandeira { get; set; }

        private string token = "1a2b3c4d5e6f7g8h9";

        protected string cvv { get; set; }

        public void AprovarCompra(){
            Console.WriteLine("Compra Aprovada! ");
        }

        private bool ValidarToken(){
            if(token != null){
                return true;
            }
            return false;
        }

        protected bool ValidarCompra(){
            if(cvv != null){
                return true;
           }
           return false;
        }
    }
}