﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCExamShop.DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MVCExamOnlineShopEntities : DbContext
    {
        public MVCExamOnlineShopEntities()
            : base("name=MVCExamOnlineShopEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Blog> Blogs { get; set; }
        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Product> Products { get; set; }
    }
}
