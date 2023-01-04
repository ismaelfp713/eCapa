using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace eCapa.Models
{
    [Table("dProcessRoles")]
    public partial class DProcessRoles
    {
        [Key]
        public int ProcessId { get; set; }
        [Key]
        public string UserId { get; set; }
        [Key]
        public int RoleId { get; set; }

        [ForeignKey(nameof(ProcessId))]
        [InverseProperty(nameof(DProcesses.DProcessRoles))]
        public virtual DProcesses Process { get; set; }
        [ForeignKey(nameof(RoleId))]
        [InverseProperty(nameof(DRoles.DProcessRoles))]
        public virtual DRoles Role { get; set; }
        [ForeignKey(nameof(UserId))]
        [InverseProperty(nameof(AspNetUsers.DProcessRoles))]
        public virtual AspNetUsers User { get; set; }
    }
}
