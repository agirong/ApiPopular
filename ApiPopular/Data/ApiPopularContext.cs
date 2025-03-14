using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApiPopular.Models;

namespace ApiPopular.Data
{
    public class ApiPopularContext : DbContext
    {
        public ApiPopularContext (DbContextOptions<ApiPopularContext> options)
            : base(options)
        {
        }

        public DbSet<Asesores> Asesores { get; set; } = default!;
        public DbSet<Estados> Estados { get; set; } = default!;
        public DbSet<Prestamos> Prestamos { get; set; } = default!;
        public DbSet<Solicitudes> Solicitudes { get; set; } = default!;
    }
}
