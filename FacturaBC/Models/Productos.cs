//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FacturaBC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Productos
    {
        public Productos()
        {
            this.FacturaDetalle = new HashSet<FacturaDetalle>();
        }
    
        public int codigo { get; set; }
        public int codigoProveedor { get; set; }
        public string nombre { get; set; }
        public Nullable<decimal> precioCosto { get; set; }
        public Nullable<decimal> precioVenta { get; set; }
        public Nullable<int> stock { get; set; }
    
        public virtual ICollection<FacturaDetalle> FacturaDetalle { get; set; }
        public virtual Proveedores Proveedores { get; set; }
    }
}
