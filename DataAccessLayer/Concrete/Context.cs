using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    // Bu class ta bağlantı adresi tanımlanacak
    // DbContext ctrl nokta yapınca using Microsoft.EntityFrameworkCore; bu gelecek

    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Tanımlamış oldugumuz OnConfiguring metodunun içerisinde bağlantı stringimizi tanımlaycağız
            // parametre olarak tanımlamış olduğumuz optionsBuilder isimli parametrenın türü de DbContextOptionsBuilder
            optionsBuilder.UseSqlServer("server=DENIZAKTAS;database=CoreBlogDb; integrated security=true;");
        }
        //Context sınıfına ait db ler tanımlanmış oldu
        public DbSet<About> Abouts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Writer> Writers { get; set; }
        public DbSet<NewsLetter> NewsLetters { get; set; }
    }
}
