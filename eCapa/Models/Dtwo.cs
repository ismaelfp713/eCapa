using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace eCapa.Models
{
    [Table("DTwo")]
    public partial class Dtwo
    {
        public Dtwo()
        {
            DtwoPictures = new HashSet<DtwoPictures>();
        }

        [Key]
        public int IdDtwo { get; set; }
        public int GeneralInformartionId { get; set; }
        [Column(TypeName = "text")]
        public string ProblemStatement { get; set; }
        [Column(TypeName = "text")]
        public string ProblemDefinition { get; set; }
        [Required]
        [StringLength(450)]
        public string CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Created { get; set; }
        public bool IsDeleted { get; set; }
        [StringLength(450)]
        public string DeletedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DeletedOn { get; set; }
        [StringLength(450)]
        public string LastModifiedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastModifiedOn { get; set; }

        [ForeignKey(nameof(GeneralInformartionId))]
        [InverseProperty(nameof(GeneralInformation.Dtwo))]
        public virtual GeneralInformation GeneralInformartion { get; set; }
        [InverseProperty("IdTwoNavigation")]
        public virtual ICollection<DtwoPictures> DtwoPictures { get; set; }
    }
}
