using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace SudocuData.Entities
{
    public partial class ContextResult : DbContext
    {
        public ContextResult()
           : base("name=DatabaseEntities")
        {
        }

        public virtual DbSet<NumberResultResponse> NumbersResult { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}