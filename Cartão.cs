namespace Aula07Encapsulamento
{
    public class cartão
    {
        public string numero { get; set; }
        public string bandeira { get; set; }
        private string token { get; set; }
        protected int cvc { get; set; }


        public string AprovarCompra(){
            return"Sua compra foi aprovada";
        }
        private bool ValidarToken(string token){
            if(token != null && token !=""){
                return true;
            }
            return false;
        }
        protected bool ValidarCompra(){
            return true;
        }
    }
}