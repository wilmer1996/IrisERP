﻿using System;

namespace IrisContabilidad.clases
{
    public class compra_vs_pagos
    {
        public int codigo { get; set; }
        public DateTime fecha { get; set; }
        public string detalle { get; set; }
        public int cod_empleado{ get; set; }
        public bool activo { get; set; }
        public int cod_empleado_anular { get; set; }
        
        public bool cuadrado { get; set; }
        public string motivo_anulado { get; set; }
    }
}
