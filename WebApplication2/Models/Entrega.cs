﻿using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class Entrega
    {
        public int IdEntrega { get; set; }
        public int? IdFacturaFk { get; set; }
        public int? ClienteIdFk { get; set; }
        public int? CantidadArticulos { get; set; }
        public int? Dia { get; set; }
        public int? Mes { get; set; }
        public int? Año { get; set; }
        public string Estatus { get; set; }

        public Clientes ClienteIdFkNavigation { get; set; }
        public Facturacion IdFacturaFkNavigation { get; set; }
    }
}
