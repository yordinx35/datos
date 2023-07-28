namespace BD_Escuela.Models
{
    public class Asignaturas
    {
        public int Id { get; set; }
        public string? NombreCompleto { get; set; }
        public int Creditos { get; set; }

        public virtual ICollection<Notas>? Notas { get; set; }
        public virtual ICollection<Profesor>? Profesores { get; set; }
    }
}
