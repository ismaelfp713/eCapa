using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace eCapa.Models
{
    [Table("DTwoPictures")]
    public partial class DtwoPictures
    {
        [Key]
        public int PictureId { get; set; }
        public int IdTwo { get; set; }
        [Required]
        [Column("filename")]
        public string Filename { get; set; }

        [ForeignKey(nameof(IdTwo))]
        [InverseProperty(nameof(Dtwo.DtwoPictures))]
        public virtual Dtwo IdTwoNavigation { get; set; }
    }
}
