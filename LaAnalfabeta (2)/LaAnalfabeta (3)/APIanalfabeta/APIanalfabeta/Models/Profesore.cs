using System;
using System.Collections.Generic;

namespace APIanalfabeta.Models;

public partial class Profesore
{
    public int ProfesorId { get; set; }

    public string Cedula { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string Correo { get; set; } = null!;

    public int? UsuarioId { get; set; }

    public bool Activo { get; set; }

    public virtual ICollection<Prestamo> Prestamos { get; set; } = new List<Prestamo>();

    public virtual Usuario? Usuario { get; set; }
}
