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
    
    public partial class Ruta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ruta()
        {
            this.Vuelo = new HashSet<Vuelo>();
        }
    
        public int ID_Ruta { get; set; }
        public string Nombre_Ruta { get; set; }
        public Nullable<double> Kilometros { get; set; }
        public Nullable<System.TimeSpan> Tiempo { get; set; }
        public int Id_Aeropuerto { get; set; }
    
        public virtual Aeropuerto Aeropuerto { get; set; }
        public virtual Aeropuerto Aeropuerto1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vuelo> Vuelo { get; set; }
    }
}