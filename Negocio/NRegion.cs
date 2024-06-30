using Datos;
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


        public void Actualizar(int RegionId,string RegionName)
        {

            datos.Actualizar(RegionId,RegionName);
        }
        public void Insertar(string Nombre)
        {
            
            datos.Insertar(Nombre);
        }

        public List<Region> Listar(string Nombre)
        {
            List<Region> result = new List<Region>();

            result = datos.Listar(Nombre);
            return result;
        }

        public void Eliminar(int RegionId)
        {

            datos.Eliminar(RegionId);
        }
    }
}
