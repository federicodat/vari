using LINQ_le03_raggruppamenti.Nuova_cartella.Models;

namespace LINQ_le03_raggruppamenti
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //    List<Libro> elenco = new List<Libro>() {
            //    new Libro("Libro A", "Autore 1", "Fantasy"),
            //    new Libro("Libro B", "Autore 2", "Sci-Fi"),
            //    new Libro("Libro C", "Autore 1", "Horror"),
            //    new Libro("Libro D", "Autore 3", "Fantasy"),
            //    new Libro("Libro E", "Autore 2", "Horror")
            //};
            //var risultato = from libro in elenco
            //                select libro;
            //var risultato = from libro in elenco
            //               where libro.Autore.Equals( "Autore 1" )
            //               select libro;
            ////var risultato = from libro in elenco
            ////                select libro.Categoria is not null && libro.Categoria.Equals("Fantasy") ? libro.Titolo + "è un libro fantasy" : "non mi interessa";
            //foreach (var l in risultato) {


            //List<Libro> elenco = new List<Libro>() {
            //    new Libro(1,"Libro A", "Autore 1", "Fantasy"),
            //    new Libro(2,"Libro B", "Autore 2", "Sci-Fi"),
            //    new Libro(3,"Libro C", "Autore 1", "Horror"),
            //    new Libro(4,"Libro D", "Autore 3", "Fantasy"),
            //    new Libro(5,"Libro E", "Autore 2", "Horror")
            //};
            //var risultato = from libro in elenco
            //                where libro.Categoria is not null && libro.Categoria.Equals("Fantasy")
            //                select new { libro.Titolo, libro.Autore, prova="ciao"};
            //                //select libro;
            //foreach (var l in risultato) {
            //    //Console.WriteLine(l);   
            //Console.WriteLine($"titolo : {l.Titolo} autore: {l.Autore}" );



                List<Libro> elenco = new List<Libro>() {
                new Libro(1,"Libro A", "Autore 1", "Fantasy"),
                new Libro(2,"Libro B", "Autore 2", "Sci-Fi"),
                new Libro(3,"Libro C", "Autore 1", "Horror"),
                new Libro(4,"Libro D", "Autore 3", "Fantasy"),
                new Libro(5,"Libro E", "Autore 2", "Horror")
            };
            var risultato = from libro in elenco
                            group libro by libro.Categoria into contenitoriCategoria
                            select contenitoriCategoria;
             
                //select libro;
                foreach (var cat in risultato)
                {
                   //Console.WriteLine(cat);   
                 //   Console.WriteLine($"Categoria : {cat.Key}");
                
                    foreach (var lib  in cat)
                    {
                        Console.WriteLine(lib);
                    }
                }
        }
    }
}
