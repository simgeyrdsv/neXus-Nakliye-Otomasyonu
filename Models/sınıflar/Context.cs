using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace traveltrip.Models.sınıflar
{
    public class Context:DbContext
    {
        [Key]
        public DbSet<Admin> Admins { get; set; }
        public DbSet<BizeUlasin> BizeUlasins { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        //public DbSet<Context> Contexts { get; set; }
        public DbSet<Hakkımızda> Hakkımızdas { get; set; }
        public DbSet<İletisim> İletisims { get; set; }
        public DbSet<Yorumlar> Yorumlars{ get; set; }
        



    }
}