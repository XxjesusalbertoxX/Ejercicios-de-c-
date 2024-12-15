using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_15_Julio
{
    internal class Importacion
    {
        public string nombrecarro { get; set; }
        public string origen { get; set; }
        public double costo { get; set; }

        // Agregar propiedades para almacenar valores calculados
        public double ImpuestosCalculados { get; set; }
        public double PrecioVentaCalculado { get; set; }

        public double Impuesto()
        {
            double impuestos = (origen == "Alemania" ? 0.20 :
                                origen == "Japon" ? 0.30 :
                                origen == "Italia" ? 0.15 : 0.08);
            ImpuestosCalculados = impuestos * costo; // Guardar impuestos calculados
            return ImpuestosCalculados;
        }

        public double PrecioVenta()
        {
            PrecioVentaCalculado = costo + Impuesto(); // Guardar precio de venta calculado
            return PrecioVentaCalculado;
        }
    }

}
