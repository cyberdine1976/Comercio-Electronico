﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ecommerce.Datos.Modelo
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TiendaLibreConnection : DbContext
    {
        public TiendaLibreConnection()
            : base("name=TiendaLibreConnection")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Articulos> Articulos { get; set; }
        public virtual DbSet<Categoria_de_Articulos> Categoria_de_Articulos { get; set; }
        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<LineasDePedido> LineasDePedido { get; set; }
        public virtual DbSet<Pedido> Pedido { get; set; }
    }
}