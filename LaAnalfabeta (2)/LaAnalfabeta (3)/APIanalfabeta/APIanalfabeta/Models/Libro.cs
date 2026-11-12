using System;
using System.Collections.Generic;

namespace APIanalfabeta.Models;

public partial class Libro
{
    public int LibroId { get; set; }

    public string Codigo { get; set; } = null!;

    public string Titulo { get; set; } = null!;

    public string Autor { get; set; } = null!;

    public string? Editorial { get; set; }

    public int? AnioPublicacion { get; set; }

    public string? Categoria { get; set; }

    public string? Isbn { get; set; }

    public string? ImagenRuta { get; set; }

    public int Stock { get; set; }

    public bool Disponible { get; set; }

    public virtual ICollection<Prestamo> Prestamos { get; set; } = new List<Prestamo>();
}
