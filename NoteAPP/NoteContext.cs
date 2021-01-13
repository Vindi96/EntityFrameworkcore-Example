using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace NoteAPP
{
    internal class NoteContext:DbContext
    {
        private readonly string connectionString;

        public NoteContext(String connectionString)
        {
            this.connectionString = connectionString;
        }
        public DbSet<Note> Notes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
