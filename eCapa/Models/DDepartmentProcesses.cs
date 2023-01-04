using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace eCapa.Models
{
    [Table("dDepartmentProcesses")]
    public partial class DDepartmentProcesses
    {
        [Key]
        public int DepartmentId { get; set; }
        [Key]
        public int ProcessId { get; set; }

        [ForeignKey(nameof(DepartmentId))]
        [InverseProperty(nameof(DDepartment.DDepartmentProcesses))]
        public virtual DDepartment Department { get; set; }
        [ForeignKey(nameof(ProcessId))]
        [InverseProperty(nameof(DProcesses.DDepartmentProcesses))]
        public virtual DProcesses Process { get; set; }
    }
}
