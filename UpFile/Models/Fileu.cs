namespace UpFile.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Fileu
    {
        [Key][Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int imageid { get; set; }

        public byte[] image { get; set; }
    }
}
