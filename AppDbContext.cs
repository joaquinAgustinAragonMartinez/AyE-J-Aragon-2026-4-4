using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace basededatos
{
    internal class AppDbContext : DbContext
    {
        public DbSet<productos> Productos => Set<productos>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //asegurarse de que el puerto de sql sea 3306 y si es diferente especificar el puerto en el var serverVersion
            //si hay error usar Port="puerto que esta usando" (ej: Port=3307)
            
            string connectionString = "Server=localhost;Port=3307;Database=mibasededatos;Uid=root;Pwd=;";
            var serverVersion = ServerVersion.AutoDetect(connectionString);
            optionsBuilder.UseMySql(connectionString, serverVersion);
        }
    }
}
