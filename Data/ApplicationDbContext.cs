using System;
using Microsoft.EntityFrameworkCore;
using Proyecto_Empleado.Models;

namespace Proyecto_Empleado.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        //Creando nuestro DbSet
        public DbSet<Empleado> Empleado { get; set; }
    }
}
