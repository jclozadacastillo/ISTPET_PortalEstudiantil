﻿using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class titulos
{
    public int idTitulo { get; set; }

    public string? titulo { get; set; }

    public string? titulo_femenino { get; set; }

    public int? nivel_inicial { get; set; }

    public int? nivel_final { get; set; }

    public int? idCarrera { get; set; }

    public sbyte? tiene_practicas { get; set; }

    public int? creditos_practicas { get; set; }

    public sbyte? tiene_titulacion { get; set; }

    public int? creditos_titulacion { get; set; }
}
