namespace SudocuData.Entities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class NumberContext : DbContext
    {
        public NumberContext()
            : base("name=DatabaseEntities")
        {
        }

        public virtual DbSet<NumberResponse> Numbers { get; set; }
       
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
