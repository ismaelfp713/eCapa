using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace eCapa.Models
{
    public partial class AspNetUsers
    {
        public AspNetUsers()
        {
            AspNetUserClaims = new HashSet<AspNetUserClaims>();
            AspNetUserLogins = new HashSet<AspNetUserLogins>();
            AspNetUserRoles = new HashSet<AspNetUserRoles>();
            AspNetUserTokens = new HashSet<AspNetUserTokens>();
            DCapaExtraMembers = new HashSet<DCapaExtraMembers>();
            DProcessRoles = new HashSet<DProcessRoles>();
            DfiveActions = new HashSet<DfiveActions>();
            DocumentHistory = new HashSet<DocumentHistory>();
            Dseven = new HashSet<Dseven>();
            DthreeCreatedByNavigation = new HashSet<Dthree>();
            DthreeResponsibleNavigation = new HashSet<Dthree>();
            GeneralInformationCreatedByNavigation = new HashSet<GeneralInformation>();
            GeneralInformationOwnerNavigation = new HashSet<GeneralInformation>();
            RoutesUsers = new HashSet<RoutesUsers>();
        }

        [Key]
        public string Id { get; set; }
        [StringLength(256)]
        public string UserName { get; set; }
        [StringLength(256)]
        public string NormalizedUserName { get; set; }
        [StringLength(256)]
        public string Email { get; set; }
        [StringLength(256)]
        public string NormalizedEmail { get; set; }
        public bool EmailConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string ConcurrencyStamp { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public DateTimeOffset? LockoutEnd { get; set; }
        public bool LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }

        [InverseProperty("User")]
        public virtual ICollection<AspNetUserClaims> AspNetUserClaims { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<AspNetUserLogins> AspNetUserLogins { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<AspNetUserRoles> AspNetUserRoles { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<AspNetUserTokens> AspNetUserTokens { get; set; }
        [InverseProperty("IdUserNavigation")]
        public virtual ICollection<DCapaExtraMembers> DCapaExtraMembers { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<DProcessRoles> DProcessRoles { get; set; }
        [InverseProperty("OwnerNavigation")]
        public virtual ICollection<DfiveActions> DfiveActions { get; set; }
        [InverseProperty("CreatedByNavigation")]
        public virtual ICollection<DocumentHistory> DocumentHistory { get; set; }
        [InverseProperty("OwnerNavigation")]
        public virtual ICollection<Dseven> Dseven { get; set; }
        [InverseProperty(nameof(Dthree.CreatedByNavigation))]
        public virtual ICollection<Dthree> DthreeCreatedByNavigation { get; set; }
        [InverseProperty(nameof(Dthree.ResponsibleNavigation))]
        public virtual ICollection<Dthree> DthreeResponsibleNavigation { get; set; }
        [InverseProperty(nameof(GeneralInformation.CreatedByNavigation))]
        public virtual ICollection<GeneralInformation> GeneralInformationCreatedByNavigation { get; set; }
        [InverseProperty(nameof(GeneralInformation.OwnerNavigation))]
        public virtual ICollection<GeneralInformation> GeneralInformationOwnerNavigation { get; set; }
        [InverseProperty("IduserNavigation")]
        public virtual ICollection<RoutesUsers> RoutesUsers { get; set; }
    }
}
