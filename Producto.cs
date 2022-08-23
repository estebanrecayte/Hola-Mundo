namespace Entrega;
    public class Producto{

        public string nombre{get;set;}="";
        public int precio{get;set;}=0;
                
        List<Review> lista = new List<Review>();
    
    public void AgregarReview(Review review){
        this.lista.Add(review);
    }
        }

