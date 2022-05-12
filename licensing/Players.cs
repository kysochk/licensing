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
    
    public partial class Players
    {
        public int Id_Player { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public System.DateTime Birthday { get; set; }
        public Nullable<double> GameNumber { get; set; }
        public Nullable<int> Id_Coach { get; set; }
        public Nullable<int> Id_Amplua { get; set; }
        public Nullable<int> Id_Putter { get; set; }
        public Nullable<int> Id_Team { get; set; }
        public string Image { get; set; }
        public Nullable<int> Id_Passport { get; set; }
        public Nullable<int> Id_BS { get; set; }
        public Nullable<int> Id_Region { get; set; }
        public Nullable<int> Id_License { get; set; }
        public Nullable<int> Id_TypeLicense { get; set; }
        public Nullable<int> Id_City { get; set; }
    
        public virtual Amplua Amplua { get; set; }
        public virtual BirthCertificate BirthCertificate { get; set; }
        public virtual City City { get; set; }
        public virtual Coach Coach { get; set; }
        public virtual Licensing Licensing { get; set; }
        public virtual Passport Passport { get; set; }
        public virtual Putter Putter { get; set; }
        public virtual Region Region { get; set; }
        public virtual Team Team { get; set; }
        public virtual TypeLictnsing TypeLictnsing { get; set; }
    }
}
