﻿using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Negocio
{
    public class NRegion
    {
        DRegion datos = new DRegion();
        public List<Region> Listar(string Nombre)
        {
            List<Region> result = new List<Region>();

            result = datos.Listar(Nombre);
            return result;
        }
    }
}
