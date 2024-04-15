using Microsoft.EntityFrameworkCore;

namespace Modelo
{
    public class Contexto : DbContext
    {
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Producto> Productos { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data source=(localdb)\MSSQLLocalDB;initial catalog=CCP_Practica;integrated security = true;").EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuracion de la tabla Clientes.
            modelBuilder.Entity<Proveedor>().ToTable("Proveedores");
            modelBuilder.Entity<Proveedor>().HasKey(p=> p.ProveedorID);
            modelBuilder.Entity<Proveedor>().HasIndex(p => p.Cuit).IsUnique();
            modelBuilder.Entity<Proveedor>().Property(p => p.Nombre).IsRequired();
            modelBuilder.Entity<Proveedor>().Property(p => p.Apellido).IsRequired();

            // Configuracion de la tabla Categorias.
            modelBuilder.Entity<Categoria>().ToTable("Categorias");
            modelBuilder.Entity<Categoria>().HasKey(c => c.CategoriaID);
            modelBuilder.Entity<Categoria>().HasIndex(c => c.Codigo).IsUnique();
            modelBuilder.Entity<Categoria>().Property(c => c.Nombre).IsRequired();
            
            // Configuracion de la tabla Productos.
            modelBuilder.Entity<Producto>().ToTable("Productos");
            modelBuilder.Entity<Producto>().HasKey(p => p.ProductoID);
            modelBuilder.Entity<Producto>().HasIndex(p => p.Codigo).IsUnique();
            modelBuilder.Entity<Producto>().Property(p => p.Nombre).IsRequired();
            modelBuilder.Entity<Producto>().Property(p => p.Talle).IsRequired();

            //Inserto datos en la tabla Proveedores.
            var Proveedor_1 = new Proveedor { ProveedorID = 1, Cuit = "20-42701181-0", Nombre = "Ignacio", Apellido = "Marani" };
            var Proveedor_2 = new Proveedor { ProveedorID = 2, Cuit = "20-12345678-3", Nombre = "Juan", Apellido = "Gomez" };
            modelBuilder.Entity<Proveedor>().HasData(Proveedor_1, Proveedor_2);

            //Inserto datos en la tabla Categorias.
            var Categoria_1 = new Categoria { CategoriaID = 1, Codigo = "ADI", Nombre = "Adidas"};
            var Categoria_2 = new Categoria { CategoriaID = 2, Codigo = "NIK", Nombre = "Nike" };
            modelBuilder.Entity<Categoria>().HasData(Categoria_1, Categoria_2);

            //Inserto datos en la tabla Productos.
            var Producto_1 = new Producto { ProductoID = 1, Codigo = 1, Nombre = "Remera", Talle = "XL", CategoriaID = 1 };
            var Producto_2 = new Producto { ProductoID = 2, Codigo = 2, Nombre = "Zapatillas", Talle = "",CategoriaID = 2 };
            modelBuilder.Entity<Producto>().HasData(Producto_1, Producto_2);
        }
    }
}
