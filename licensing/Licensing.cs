//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace licensing
{
    using System;
    using System.Collections.Generic;
    
    public partial class Licensing
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Licensing()
        {
            this.Players = new HashSet<Players>();
        }
    
        public int Id_license { get; set; }
        public string NumberLicense { get; set; }
        public Nullable<System.DateTime> StartLicense { get; set; }
        public Nullable<System.DateTime> EndLicense { get; set; }
        public byte[] Photo { get; set; }
        public Nullable<int> Id_TypeLicense { get; set; }
    
        public virtual TypeLictnsing TypeLictnsing { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Players> Players { get; set; }
    }
}
