using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace eCapa.Models
{
    [Table("dProcesses")]
    public partial class DProcesses
    {
        public DProcesses()
        {
            DDepartmentProcesses = new HashSet<DDepartmentProcesses>();
            DProcessRoles = new HashSet<DProcessRoles>();
            GeneralInformation = new HashSet<GeneralInformation>();
        }

        [Key]
        public int ProcessId { get; set; }
        [Required]
        [StringLength(50)]
        public string ProcessName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Created { get; set; }
        [Required]
        [StringLength(450)]
        public string CreatedBy { get; set; }
        public bool IsDeleted { get; set; }
        [StringLength(450)]
        public string DeletedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DeletedOn { get; set; }
        [StringLength(450)]
        public string LastModifiedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastModifiedOn { get; set; }

        [InverseProperty("Process")]
        public virtual ICollection<DDepartmentProcesses> DDepartmentProcesses { get; set; }
        [InverseProperty("Process")]
        public virtual ICollection<DProcessRoles> DProcessRoles { get; set; }
        [InverseProperty("Process")]
        public virtual ICollection<GeneralInformation> GeneralInformation { get; set; }
    }
}
