﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LicensingEntities1 : DbContext
    {
        public LicensingEntities1()
            : base("name=LicensingEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Amplua> Amplua { get; set; }
        public virtual DbSet<BirthCertificate> BirthCertificate { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Licensing> Licensing { get; set; }
        public virtual DbSet<Passport> Passport { get; set; }
        public virtual DbSet<Players> Players { get; set; }
        public virtual DbSet<Putter> Putter { get; set; }
        public virtual DbSet<Region> Region { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Team> Team { get; set; }
        public virtual DbSet<TypeLictnsing> TypeLictnsing { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Coach> Coach { get; set; }
    }
}
