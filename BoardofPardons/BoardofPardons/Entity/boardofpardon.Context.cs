﻿

//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace BoardofPardons.Entity
{

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;


public partial class BoardofPardonsEntities1 : DbContext
{
    public BoardofPardonsEntities1()
        : base("name=BoardofPardonsEntities1")
    {

    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }


    public DbSet<Form> Forms { get; set; }

    public DbSet<IncarceratedStep1> IncarceratedStep1 { get; set; }

    public DbSet<IncarceratedStep2> IncarceratedStep2 { get; set; }

    public DbSet<IncarceratedStep3> IncarceratedStep3 { get; set; }

    public DbSet<IncarceratedStep4> IncarceratedStep4 { get; set; }

    public DbSet<IncarceratedStep5> IncarceratedStep5 { get; set; }

    public DbSet<IncarceratedStep6> IncarceratedStep6 { get; set; }

    public DbSet<IncarceratedStep7> IncarceratedStep7 { get; set; }

    public DbSet<NonIncarceratedStep1> NonIncarceratedStep1 { get; set; }

    public DbSet<NonIncarceratedStep2> NonIncarceratedStep2 { get; set; }

    public DbSet<NonIncarceratedStep3> NonIncarceratedStep3 { get; set; }

    public DbSet<NonIncarceratedStep4> NonIncarceratedStep4 { get; set; }

    public DbSet<NonIncarceratedStep5> NonIncarceratedStep5 { get; set; }

    public DbSet<NonIncarceratedStep6> NonIncarceratedStep6 { get; set; }

    public DbSet<NonIncarceratedStep7> NonIncarceratedStep7 { get; set; }

    public DbSet<Review> Reviews { get; set; }

    public DbSet<User> Users { get; set; }

    public DbSet<webpages_Membership> webpages_Membership { get; set; }

    public DbSet<webpages_OAuthMembership> webpages_OAuthMembership { get; set; }

    public DbSet<webpages_Roles> webpages_Roles { get; set; }

}

}

