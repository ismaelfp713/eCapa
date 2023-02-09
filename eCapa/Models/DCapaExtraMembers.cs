using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace eCapa.Models
{
    [Table("dCapaExtraMembers")]
    public partial class DCapaExtraMembers
    {
        [Key]
        public int IdCapaMember { get; set; }
        public int IdCapa { get; set; }
        [Required]
        [StringLength(450)]
        public string IdUser { get; set; }
        public int IdRole { get; set; }

        [ForeignKey(nameof(IdCapa))]
        [InverseProperty(nameof(GeneralInformation.DCapaExtraMembers))]
        public virtual GeneralInformation IdCapaNavigation { get; set; }
        [ForeignKey(nameof(IdRole))]
        [InverseProperty(nameof(DRoles.DCapaExtraMembers))]
        public virtual DRoles IdRoleNavigation { get; set; }
        [ForeignKey(nameof(IdUser))]
        [InverseProperty(nameof(AspNetUsers.DCapaExtraMembers))]
        public virtual AspNetUsers IdUserNavigation { get; set; }
    }
}
