namespace SudocuData.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tsudocu")]
    public partial class NumberResponse
    {
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "Level")]
        public int Level { get; set; }

        [Required]
        [Display(Name = "Num1")]
        public int? Num1 { get; set; }

        [Required]
        [Display(Name = "Num2")]
        public Nullable<int> Num2 { get; set; }

        [Required]
        [Display(Name = "Num3")]
        public int? Num3 { get; set; }

        [Required]
        [Display(Name = "Num4")]
        public int? Num4 { get; set; }

        [Required]
        [Display(Name = "Num5")]
        public int? Num5 { get; set; }

        [Required]
        [Display(Name = "Num6")]
        public int? Num6 { get; set; }

        [Required]
        [Display(Name = "Num7")]
        public int? Num7 { get; set; }

        [Required]
        [Display(Name = "Num8")]
        public int? Num8 { get; set; }

        [Required]
        [Display(Name = "Num9")]
        public int? Num9 { get; set; }
    }
}
