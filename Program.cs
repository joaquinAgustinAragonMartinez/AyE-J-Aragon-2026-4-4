namespace basededatos
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            using var db = new AppDbContext();

            //insertar
            var Insertar = new productos
            {
                //Se inserta datos creados en SQL (Menos el id porque es clave primaria y auto_incremet)
                //EJ:
                nombre = "empanadas",
                precio = 1000
            };

            db.Productos.Add(Insertar);
            db.SaveChanges();

            //Consultar
            var todos = await db.Productos.ToListAsync();


            //Ejecutar una linea SQL
            string SQL = "SELECT * FROM productos where id = 1";
            var lista = await db.Productos.FromSqlRaw(SQL).ToListAsync();
            foreach (var d in lista)
            {
                Console.WriteLine(d.nombre);
            }

            //Buscar usuario en especifico
            int id = 1;
            var DatoBuscado = Insertar;
            DatoBuscado = await db.Productos.FindAsync(id);

            // para que no nos tire error por si no existe un dato
            if (DatoBuscado != null)
            {
                Console.WriteLine(DatoBuscado.nombre);
            }
            else
            {
                Console.WriteLine("Dato no encontrado con ese ID");
            }

            if (DatoBuscado != null)
            {
                DatoBuscado.nombre = "papa";
                DatoBuscado.precio = 10000;
                await db.SaveChangesAsync();
            }

            //Borrar datos
            if (DatoBuscado != null)
            {
                db.Remove(DatoBuscado);
                await db.SaveChangesAsync();
            }
        }
    }
}
