using System;
using System.Collections.Generic;

namespace APIanalfabeta.Models;

public partial class Usuario
{
    public int UsuarioId { get; set; }

    public string NombreUsuario { get; set; } = null!;

    public string ContrasenaHash { get; set; } = null!;

    public string Contrasena { get; set; } = null!;

    public string Correo { get; set; } = null!;

    public int RolId { get; set; }

    public bool Activo { get; set; }

    public DateTime FechaRegistro { get; set; }

    public string Rol { get; set; } = null!;

    public virtual ICollection<Estudiante> Estudiantes { get; set; } = new List<Estudiante>();

    public virtual ICollection<Profesore> Profesores { get; set; } = new List<Profesore>();
}
