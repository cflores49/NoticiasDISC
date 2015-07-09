using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NoticiasDISC.Models;

namespace NoticiasDISC.Contexto
{
    public class NoticiasContext : DbContext
    {

        public DbSet<Noticia> Noticias { get; set; }
        public DbSet<Autor> Autores { get; set; }
        public DbSet<CustomUser> CustomUsers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);  
              
            //No usar la convencion que dice que hay que pluralizar el nombre de las tablas      
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>(); 
        }
    }
}
