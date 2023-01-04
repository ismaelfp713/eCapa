using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace eCapa.Models
{
    public partial class Customers
    {
        public Customers()
        {
            GeneralInformation = new HashSet<GeneralInformation>();
            PartNumbers = new HashSet<PartNumbers>();
        }

        [Key]
        public int CustomersId { get; set; }
        [Required]
        [StringLength(50)]
        public string CustomerName { get; set; }
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

        [InverseProperty("Customer")]
        public virtual ICollection<GeneralInformation> GeneralInformation { get; set; }
        [InverseProperty("Customer")]
        public virtual ICollection<PartNumbers> PartNumbers { get; set; }
    }
}
