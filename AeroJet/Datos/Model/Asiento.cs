//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Asiento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Asiento()
        {
            this.Boleto = new HashSet<Boleto>();
        }
    
        public int Id_Asiento { get; set; }
        public string Ubicación_Asiento { get; set; }
        public Nullable<int> Fila { get; set; }
        public string Letra { get; set; }
        public int ID_Seccion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Boleto> Boleto { get; set; }
        public virtual Secciones Secciones { get; set; }
    }
}
