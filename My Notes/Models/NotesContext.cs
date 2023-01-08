using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace My_Notes.Model
{
    [System.Serializable]
    internal class NotesContext : DbContext
    {
        public DbSet<Note> Notes { get; set; }
  
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=NoteStorage;Trusted_Connection = True;");
        }
    }
}