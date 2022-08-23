using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebApiIn10Mins.Models
{
    
    /// <summary>
    /// Scaffold-DbContext "Server=localhost;Port=3306;Database=sakila;Uid=myusername;
    /// Pwd=mypwd;" MySql.Data.EntityFrameworkCore -OutputDir Models
    /// </summary>
    public partial class Apiin10Context : DbContext
    {
        public Apiin10Context()
        {
        }

        public Apiin10Context(DbContextOptions<Apiin10Context> options)
            : base(options)
        {
        }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
                
////#warning
////To protect potentially sensitive information in your connection string, you should move it out of source code.
////See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseMySQL("Server=localhost;Port=3306;Database=Apiin10;Uid=root;Pwd=;");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
