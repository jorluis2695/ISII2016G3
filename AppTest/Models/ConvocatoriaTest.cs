//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppTest.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ConvocatoriaTest
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ConvocatoriaTest()
        {
            this.Pruebas = new HashSet<Prueba>();
        }
    
        public int ConvocatoriaTestID { get; set; }
        public Nullable<int> TestID { get; set; }
        public Nullable<int> ConvocatoriaID { get; set; }
    
        public virtual Convocatoria Convocatoria { get; set; }
        public virtual Test Test { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Prueba> Pruebas { get; set; }
    }
}
