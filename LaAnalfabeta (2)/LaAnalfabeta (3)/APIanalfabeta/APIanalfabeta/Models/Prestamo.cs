using System;
using System.Collections.Generic;

namespace APIanalfabeta.Models;

public partial class Prestamo
{
    public int PrestamoId { get; set; }

    public int LibroId { get; set; }

    public int? EstudianteId { get; set; }

    public int? ProfesorId { get; set; }

    public DateTime FechaPrestamo { get; set; }

    public DateTime FechaDevolucionEsperada { get; set; }

    public DateTime? FechaDevolucionReal { get; set; }

    public string Estado { get; set; } = null!;

    public string? Observaciones { get; set; }

    public virtual Estudiante? Estudiante { get; set; }

    public virtual Libro Libro { get; set; } = null!;

    public virtual Profesore? Profesor { get; set; }
}
