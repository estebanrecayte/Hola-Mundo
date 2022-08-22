namespace Entrega;
    public class Producto{

        public string nombre{get;set;}="";
        public int precio{get;set;}=0;
                
        List<Review> lista = new List<Review>();
    }
    public void AgregarReview(List<Review>){
        
        }
    public class Review{

        public int calificacion{get;set;}=0;
        public string comentarios{get;set;}="";

    }