using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Compras
{
    public class Articulo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int CantidadEstimada { get; set; }
        public decimal PrecioEstimado { get; set; }
        public bool Encontrado { get; set; }
        public decimal PrecioReal { get; set; }
        public decimal TotalEstimado => CantidadEstimada * PrecioEstimado;
        public decimal TotalReal => Encontrado ? PrecioReal * CantidadEstimada : 0;
    }
}