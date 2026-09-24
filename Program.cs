namespace tp_23
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            using var db = new AppDbContext();

            ArbolPokemon miArbol = new ArbolPokemon();

            var Insertar = new NodoPokemon
            {
                
            };

            db.nodopokemon.Add(Insertar);
            db.SaveChanges();
        }
    }
}
