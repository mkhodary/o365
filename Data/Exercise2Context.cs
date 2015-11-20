using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using O365Intro.Models;

namespace O365Intro.Data {

  public class O365IntroContext : DbContext {
    public O365IntroContext()
      : base("O365IntroContext") { }

    //public DbSet<Tenant> Tenants { get; set; }
    //public DbSet<User> Users { get; set; }

    public DbSet<PerWebUserCache> PerUserCacheList { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder) {
      modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
    }
  }
}