namespace struct_a_base_de_datos
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            using var db = new AppDbContext();

            var Insertar = new Punto2D
            {
                X = 2000,
                Y = 1000
            };

            db.punto2d.Add(Insertar);
            db.SaveChanges();
        }
    }
}
