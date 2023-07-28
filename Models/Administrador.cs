namespace BD_Escuela.Models
{
    public class Administrador
    {
        public int id { get; set; }

        public string? NombreCompleto { get; set; }
        public string? Correo { get; set; }
        public string? Contraseña { get; set; }

        public virtual ICollection<Usuario>? UsuariosAsignados { get; set; }

    }

}



