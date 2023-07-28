using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BD_Escuela.Models;

namespace BD_Escuela.Data
{
    public class BD_EscuelaContext : DbContext
    {
        public BD_EscuelaContext (DbContextOptions<BD_EscuelaContext> options)
            : base(options)
        {
        }

        public DbSet<BD_Escuela.Models.Administrador> Administrador { get; set; } = default!;

        public DbSet<BD_Escuela.Models.Usuario>? Usuario { get; set; }

        public DbSet<BD_Escuela.Models.Profesor>? Profesor { get; set; }

        public DbSet<BD_Escuela.Models.Cursos>? Cursos { get; set; }

        public DbSet<BD_Escuela.Models.Estudiantes>? Estudiantes { get; set; }

        public DbSet<BD_Escuela.Models.Notas>? Notas { get; set; }

        public DbSet<BD_Escuela.Models.Asignaturas>? Asignaturas { get; set; }
    }
}
