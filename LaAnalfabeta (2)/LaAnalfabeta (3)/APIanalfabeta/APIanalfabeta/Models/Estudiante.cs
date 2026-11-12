using System;
using System.Collections.Generic;

namespace APIanalfabeta.Models;

public partial class Estudiante
{
    public int EstudianteId { get; set; }

    public int Carnet { get; set; }

    public string NombreCompleto { get; set; } = null!;

    public string Correo { get; set; } = null!;

    public string? Curso { get; set; }

    public int? UsuarioId { get; set; }

    public bool Activo { get; set; }

    public virtual ICollection<Prestamo> Prestamos { get; set; } = new List<Prestamo>();

    public virtual Usuario? Usuario { get; set; }
}
