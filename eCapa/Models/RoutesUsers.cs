using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace eCapa.Models
{
    public partial class RoutesUsers
    {
        [Key]
        [Column("idrouteuser")]
        public int Idrouteuser { get; set; }
        [Column("idroute")]
        public int Idroute { get; set; }
        [Required]
        [Column("iduser")]
        [StringLength(450)]
        public string Iduser { get; set; }
        public bool IsActive { get; set; }

        [ForeignKey(nameof(Idroute))]
        [InverseProperty(nameof(TRoutes.RoutesUsers))]
        public virtual TRoutes IdrouteNavigation { get; set; }
        [ForeignKey(nameof(Iduser))]
        [InverseProperty(nameof(AspNetUsers.RoutesUsers))]
        public virtual AspNetUsers IduserNavigation { get; set; }
    }
}
