using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WinFormsApp1
{
    class MyContext : DbContext
    {
        public DbSet<Usuario> usuario { get; set; }
        public DbSet<CajaAhorro> cajaAhorro { get; set; }
        public DbSet<Movimiento> movimiento { get; set; }
        public DbSet<Pago> pago { get; set; }
        public DbSet<PlazoFijo> plazoFiijo { get; set; }
        public DbSet<TarjetaCredito> tarjetaCredito { get; set; }

        public MyContext() { } //está vacío porque el ConnectionString lo estamos guardando en el archivo Resources

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Properties.Resources.ConnectionStr);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //nombre de las tablas
            modelBuilder.Entity<Usuario>() //los paréntesis vacíos indican que lo de abajo, modelBuilder, se aplica a toda la entidad "<Usuario>"
                .ToTable("Usuario") //nombre de la tabla "Usuario"
                .HasKey(u => u.id_usr); //el HasKey se necesita para definir el "id" y lo definimos como "id_usr"
            //propiedades de cada uno de los datos
            modelBuilder.Entity<Usuario>(
                usr =>
                {
                    usr.Property(u => u.dni).HasColumnType("int");
                    usr.Property(u => u.dni).IsRequired(true); //es redundate xq los "int" no haceptan nulos, pero tampoco interfiere el tenerlo
                    usr.Property(u => u.nombre).HasColumnType("varchar(50)");
                    usr.Property(u => u.mail).HasColumnType("varchar(50)"); //Obs: si no especificamos, el varchar lo configura como varchar(512)
                    usr.Property(u => u.pass).HasColumnType("varchar(50)");
                    usr.Property(u => u.pass).IsRequired(true);
                    usr.Property(u => u.intentosFallidos).HasColumnType("int");
                    usr.Property(u => u.intentosFallidos).IsRequired(true);
                    usr.Property(u => u.bloqueado).HasColumnType("bit");
                    usr.Property(u => u.bloqueado).IsRequired(true);
                    usr.Property(u => u.borrado).HasColumnType("bit");
                    usr.Property(u => u.borrado).IsRequired(true);
                });

            modelBuilder.Entity<CajaAhorro>()
                .ToTable("CajaAhorro")
                .HasKey(c => c.id_caja);

            modelBuilder.Entity<CajaAhorro>(
                caj =>
                {
                    caj.Property(c => c.cbu).HasColumnType("varchar(50)");
                    caj.Property(c => c.cbu).IsRequired(true);
                    caj.Property(c => c.saldo).HasColumnType("float");
                    caj.Property(c => c.saldo).IsRequired(true);
                    caj.Property(c => c.borrado).HasColumnType("bit");
                    caj.Property(c => c.borrado).IsRequired(true);
                });

            modelBuilder.Entity<Movimiento>()
                .ToTable("Movimiento")
                .HasKey(m => m.id_movimiento);

            modelBuilder.Entity<Movimiento>(
                mov =>
                {
                    mov.Property(m => m.detalle).HasColumnType("int");
                    mov.Property(m => m.detalle).IsRequired(true);
                    mov.Property(m => m.monto).HasColumnType("float");
                    mov.Property(m => m.monto).IsRequired(true);
                    mov.Property(m => m.fecha).HasColumnType("date");
                    mov.Property(m => m.fecha).IsRequired(true);
                    mov.Property(m => m.idCajaAhorro).HasColumnType("int");
                    mov.Property(m => m.idCajaAhorro).IsRequired(true);
                });

            



            //Ignore: no agregaremos estas clases a la base de datos
            modelBuilder.Ignore<AccesoBD>();
            modelBuilder.Ignore<Banco>();
            modelBuilder.Ignore<MyContext>();
           //modelBuilder.Ignore<Program>(); //Chicos, no me deja hacerlo con Program xq es de tipo estático
            
        }


    }
}
