using System;

namespace Lista_Compras
{
    public class Class1
    {
        public Class1()
        {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int CantidadEstimada { get; set; }
        public decimal PrecioEstimado { get; set; }
        public bool Encontrado { get; set; }
        public decimal PrecioReal { get; set; }
        public decimal TotalEstimado => CantidadEstimada * PrecioEstimado;
        public decimal TotalReal => Encontrado ? CantidadEstimada * PrecioReal : 0;
    }
}
}