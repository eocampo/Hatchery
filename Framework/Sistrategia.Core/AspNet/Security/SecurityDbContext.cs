﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Microsoft.AspNet.Identity.EntityFramework;
//using System.Data.Entity.Infrastructure.Annotations;
//using System.ComponentModel.DataAnnotations.Schema;

namespace Sistrategia.AspNet.Security
{
    //public class SecurityDbContext : SecurityDbContext<SecurityUser, SecurityRole>
    //{
    //    public SecurityDbContext()
    //        : base("DefaultDatabase", throwIfV1Schema: false) {
    //    }

    //    public SecurityDbContext(string nameOrConnectionString, bool throwIfV1Schema)
    //        : base(nameOrConnectionString, throwIfV1Schema) {
    //    }
    //}

    //public class SecurityDbContext<TSecurityUser> : SecurityDbContext<TSecurityUser, SecurityRole>
    //    where TSecurityUser : SecurityUser
    //{
    //    public SecurityDbContext()
    //        : base("DefaultDatabase", throwIfV1Schema: false) {
    //    }

    //    public SecurityDbContext(string nameOrConnectionString, bool throwIfV1Schema)
    //        : base(nameOrConnectionString, throwIfV1Schema) {
    //    }
    //}

    //public class SecurityDbContext<TSecurityUser, TRole>
    //    : IdentityDbContext<TSecurityUser, SecurityRole, string, IdentityUserLogin, IdentityUserRole, IdentityUserClaim>
    //    where TSecurityUser : SecurityUser
    //    where TRole : SecurityRole
    //{
    //    public SecurityDbContext()
    //        //: base("DefaultDatabase", throwIfV1Schema: false) {
    //        : base("DefaultDatabase") {
    //    }

    //    public SecurityDbContext(string nameOrConnectionString, bool throwIfV1Schema)
    //        //: base(nameOrConnectionString, throwIfV1Schema) {
    //        : base(nameOrConnectionString) {
    //    }

    //    protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder) {
    //        //  base.OnModelCreating(modelBuilder);

    //        //modelBuilder.Entity<IdentityUser>()
    //        //    .ToTable("security_user", "dbo").Property(p => p.Id).HasColumnName("user_id");

    //        var user = modelBuilder.Entity<TSecurityUser>()
    //            .ToTable("security_user");
    //        user.Property(u => u.Id).HasColumnName("user_id");
    //        user.HasMany(u => u.Roles).WithRequired().HasForeignKey(ur => ur.UserId);
    //        user.HasMany(u => u.Claims).WithRequired().HasForeignKey(uc => uc.UserId);
    //        user.HasMany(u => u.Logins).WithRequired().HasForeignKey(ul => ul.UserId);
    //        user.Property(u => u.UserName)
    //            .HasColumnName("user_name")
    //            .IsRequired()
    //            .HasMaxLength(256)
    //            .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute("user_name_index") { IsUnique = true }));

    //        //modelBuilder.Entity<User>()
    //        //    .ToTable("Users", "dbo").Property(p => p.Id).HasColumnName("User_Id");

    //        //modelBuilder.Entity<IdentityRole>().ToTable("security_roles");
    //        //modelBuilder.Entity<IdentityUserRole>().ToTable("security_user_roles");
    //        //modelBuilder.Entity<IdentityUserLogin>().ToTable("security_user_logins");
    //        //modelBuilder.Entity<IdentityUserClaim>().ToTable("security_user_claims");



    //        // CONSIDER: u.Email is Required if set on options?
    //        user.Property(u => u.Email).HasMaxLength(256);

    //        modelBuilder.Entity<IdentityUserRole>()
    //            .HasKey(r => new { r.UserId, r.RoleId })
    //            .ToTable("security_user_roles");

    //        modelBuilder.Entity<IdentityUserLogin>()
    //             .HasKey(l => new { l.LoginProvider, l.ProviderKey, l.UserId })
    //             .ToTable("security_user_logins");

    //        modelBuilder.Entity<IdentityUserClaim>().ToTable("security_user_claims");

    //        var role = modelBuilder.Entity<TRole>()
    //           .ToTable("security_roles");
    //        role.Property(r => r.Name)
    //            .IsRequired()
    //            .HasMaxLength(256)
    //            .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute("RoleNameIndex") { IsUnique = true }));
    //        role.HasMany(r => r.Users).WithRequired().HasForeignKey(ur => ur.RoleId);



    //        //modelBuilder.Entity<User>()
    //        //    .ToTable("Users", "dbo").Property(p => p.Id).HasColumnName("User_Id");


    //        //if (modelBuilder == null) {
    //        //    throw new ArgumentNullException("modelBuilder");
    //        //}

    //        //// Needed to ensure subclasses share the same table
    //        //var user = modelBuilder.Entity<TUser>()
    //        //    .ToTable("AspNetUsers");
    //        //user.HasMany(u => u.Roles).WithRequired().HasForeignKey(ur => ur.UserId);
    //        //user.HasMany(u => u.Claims).WithRequired().HasForeignKey(uc => uc.UserId);
    //        //user.HasMany(u => u.Logins).WithRequired().HasForeignKey(ul => ul.UserId);
    //        //user.Property(u => u.UserName)
    //        //    .IsRequired()
    //        //    .HasMaxLength(256)
    //        //    .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute("UserNameIndex") { IsUnique = true }));

    //        //// CONSIDER: u.Email is Required if set on options?
    //        //user.Property(u => u.Email).HasMaxLength(256);

    //        //modelBuilder.Entity<TUserRole>()
    //        //    .HasKey(r => new { r.UserId, r.RoleId })
    //        //    .ToTable("AspNetUserRoles");

    //        //modelBuilder.Entity<TUserLogin>()
    //        //    .HasKey(l => new { l.LoginProvider, l.ProviderKey, l.UserId })
    //        //    .ToTable("AspNetUserLogins");

    //        //modelBuilder.Entity<TUserClaim>()
    //        //    .ToTable("AspNetUserClaims");

    //        //var role = modelBuilder.Entity<TRole>()
    //        //    .ToTable("AspNetRoles");
    //        //role.Property(r => r.Name)
    //        //    .IsRequired()
    //        //    .HasMaxLength(256)
    //        //    .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute("RoleNameIndex") { IsUnique = true }));
    //        //role.HasMany(r => r.Users).WithRequired().HasForeignKey(ur => ur.RoleId);

    //    }
    //}
}
