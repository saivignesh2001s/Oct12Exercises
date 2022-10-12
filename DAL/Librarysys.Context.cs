﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class libraryEntities : DbContext
    {
        public libraryEntities()
            : base("name=libraryEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Book_c> Book_c { get; set; }
        public virtual DbSet<Issue> Issues { get; set; }
        public virtual DbSet<Issue_c> Issue_c { get; set; }
        public virtual DbSet<member> members { get; set; }
        public virtual DbSet<member_c> member_c { get; set; }
        public virtual DbSet<Book101> Book101 { get; set; }
        public virtual DbSet<issu01> issu01 { get; set; }
        public virtual DbSet<member101> member101 { get; set; }
        public virtual DbSet<member8> member8 { get; set; }
        public virtual DbSet<v_issue> v_issue { get; set; }
        public virtual DbSet<v_issue01> v_issue01 { get; set; }
    
        public virtual int count1()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("count1");
        }
    
        public virtual int counts(ObjectParameter param1)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("counts", param1);
        }
    
        public virtual int sp_update(Nullable<int> p_bno, ObjectParameter p_Bookno, ObjectParameter p_Bname, ObjectParameter p_Author, ObjectParameter p_cost, ObjectParameter p_category)
        {
            var p_bnoParameter = p_bno.HasValue ?
                new ObjectParameter("p_bno", p_bno) :
                new ObjectParameter("p_bno", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_update", p_bnoParameter, p_Bookno, p_Bname, p_Author, p_cost, p_category);
        }
    
        public virtual int UpdateBooknum(Nullable<int> param1, Nullable<int> param2)
        {
            var param1Parameter = param1.HasValue ?
                new ObjectParameter("param1", param1) :
                new ObjectParameter("param1", typeof(int));
    
            var param2Parameter = param2.HasValue ?
                new ObjectParameter("param2", param2) :
                new ObjectParameter("param2", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateBooknum", param1Parameter, param2Parameter);
        }
    
        public virtual int UpdateBooksauthor(Nullable<decimal> param1, string param2)
        {
            var param1Parameter = param1.HasValue ?
                new ObjectParameter("param1", param1) :
                new ObjectParameter("param1", typeof(decimal));
    
            var param2Parameter = param2 != null ?
                new ObjectParameter("param2", param2) :
                new ObjectParameter("param2", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateBooksauthor", param1Parameter, param2Parameter);
        }
    
        public virtual int UpdateBookscategory(Nullable<decimal> param1, string param2)
        {
            var param1Parameter = param1.HasValue ?
                new ObjectParameter("param1", param1) :
                new ObjectParameter("param1", typeof(decimal));
    
            var param2Parameter = param2 != null ?
                new ObjectParameter("param2", param2) :
                new ObjectParameter("param2", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateBookscategory", param1Parameter, param2Parameter);
        }
    
        public virtual int UpdateBooksname(Nullable<decimal> param1, string param2)
        {
            var param1Parameter = param1.HasValue ?
                new ObjectParameter("param1", param1) :
                new ObjectParameter("param1", typeof(decimal));
    
            var param2Parameter = param2 != null ?
                new ObjectParameter("param2", param2) :
                new ObjectParameter("param2", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateBooksname", param1Parameter, param2Parameter);
        }
    
        public virtual int UpdateBooksprice(Nullable<decimal> param1, Nullable<decimal> param2)
        {
            var param1Parameter = param1.HasValue ?
                new ObjectParameter("param1", param1) :
                new ObjectParameter("param1", typeof(decimal));
    
            var param2Parameter = param2.HasValue ?
                new ObjectParameter("param2", param2) :
                new ObjectParameter("param2", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateBooksprice", param1Parameter, param2Parameter);
        }
    
        public virtual int Updatestatus(Nullable<int> param1, Nullable<int> param4, Nullable<int> param6, Nullable<System.DateTime> param2, string param3)
        {
            var param1Parameter = param1.HasValue ?
                new ObjectParameter("param1", param1) :
                new ObjectParameter("param1", typeof(int));
    
            var param4Parameter = param4.HasValue ?
                new ObjectParameter("param4", param4) :
                new ObjectParameter("param4", typeof(int));
    
            var param6Parameter = param6.HasValue ?
                new ObjectParameter("param6", param6) :
                new ObjectParameter("param6", typeof(int));
    
            var param2Parameter = param2.HasValue ?
                new ObjectParameter("param2", param2) :
                new ObjectParameter("param2", typeof(System.DateTime));
    
            var param3Parameter = param3 != null ?
                new ObjectParameter("param3", param3) :
                new ObjectParameter("param3", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Updatestatus", param1Parameter, param4Parameter, param6Parameter, param2Parameter, param3Parameter);
        }
    }
}