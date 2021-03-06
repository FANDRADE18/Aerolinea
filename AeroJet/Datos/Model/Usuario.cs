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
    
    public partial class Usuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Usuario()
        {
            this.Boleto = new HashSet<Boleto>();
            this.Tarjeta = new HashSet<Tarjeta>();
        }
    
        public int Id_Usuario { get; set; }
        public string Nombre_Usuario { get; set; }
        public string ApellidoPaterno_Usuario { get; set; }
        public string ApellidoMaterno_Usuario { get; set; }
        public string Direccion_Usuario { get; set; }
        public string Pais { get; set; }
        public string Ciudad { get; set; }
        public Nullable<int> CP_Usuario { get; set; }
        public Nullable<int> Telefono_Usuario { get; set; }
        public string Contrasena { get; set; }
        public string E_Mail_Usuario { get; set; }
        public int Id_Perfil { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Boleto> Boleto { get; set; }
        public virtual Perfil Perfil { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tarjeta> Tarjeta { get; set; }
    }
}
