namespace UpFile.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class UpContext : DbContext
    {
        public UpContext()
            : base("name=UpContext")
        {
        }

        public virtual DbSet<Fileu> Fileus { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
