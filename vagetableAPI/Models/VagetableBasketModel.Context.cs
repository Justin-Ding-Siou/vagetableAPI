﻿

//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------


namespace vagetableAPI.Models
{

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;


public partial class dbVagetableBasketEntities : DbContext
{
    public dbVagetableBasketEntities()
        : base("name=dbVagetableBasketEntities")
    {

    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }


    public virtual DbSet<Food> Food { get; set; }

    public virtual DbSet<Fridge> Fridge { get; set; }

    public virtual DbSet<Ingredient> Ingredient { get; set; }

    public virtual DbSet<Log> Log { get; set; }

    public virtual DbSet<Member> Member { get; set; }

    public virtual DbSet<Message> Message { get; set; }

    public virtual DbSet<Own_Fridge> Own_Fridge { get; set; }

        
        public virtual DbSet<Recipe> Recipe { get; set; }

    public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

}

}

