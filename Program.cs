using Entrega;
    class Program{
        public static void Main(){
           Producto prod1 = new Producto{nombre="Coca",precio=60};
           Producto prod2 = new Producto{nombre="Papas fritas",precio=40};

           Review rev1 = new Review{calificacion=4,comentarios="muy buena"};
           Review rev2 = new Review{calificacion=5,comentarios="excelente"};

           prod1.AgregarReview(rev1);
           Console.WriteLine(rev1.lista);
);

           Console.WriteLine(prod1.nombre);
           Console.WriteLine(prod2.nombre);
        }
    }