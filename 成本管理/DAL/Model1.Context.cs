﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace 成本管理.DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<xm_plug_t_materailUnitPrice_main> xm_plug_t_materailUnitPrice_main { get; set; }
        public virtual DbSet<xm_plug_t_materialUnitPice> xm_plug_t_materialUnitPice { get; set; }
        public virtual DbSet<xm_plug_v_historyPriceForFisrtRecord> xm_plug_v_historyPriceForFisrtRecord { get; set; }
    }
}
