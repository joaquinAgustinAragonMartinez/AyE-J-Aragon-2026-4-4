namespace basededatos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var db = new AppDbContext();

            //insertar

            var Insertar = new productos
            {
                nombre = "fideos",
                precio = 1500
            };

            db.datos.Add(Insertar);
            db.SaveChangesAsync();

        }
    }
}
