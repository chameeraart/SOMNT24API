using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOMNT24DOMAIN.Models
{
    [Table("ZYUser")]
    public class ZYUser
    {
        [Key]
        [Required]
        [MaxLength(40)]
        public string UserName { get; set; }

        [Required]
        [MaxLength(40)]
        public string UserFullName { get; set; }

        [MaxLength(10)]
        public string? RoleCode { get; set; }

        [MaxLength(10)]
        public string? MenuCode { get; set; }

        public bool? Enabled { get; set; }

        [MaxLength(10)]
        public string? Language { get; set; }

        [MaxLength(30)]
        public string? FontName { get; set; }

        public int? FontSize { get; set; }

        public int? CharacterSet { get; set; }

        public bool? UseTranslateTable { get; set; }

        public bool? CanModify { get; set; }

        [MaxLength(50)]
        public string? Password { get; set; }

        public int? PaperSize { get; set; }

        [Timestamp]
        public byte[] TimeStamp { get; set; }

        [MaxLength(10)]
        public string? UserLevelGroup { get; set; }

        [MaxLength(1)]
        public string? PasswordLocked { get; set; }

        [MaxLength(1)]
        public string? PowerUser { get; set; }

        [MaxLength(20)]
        public string? ActiveFlag { get; set; }

        [MaxLength(10)]
        public string? Theme { get; set; }

        [MaxLength(10)]
        public string? FontColor { get; set; }

        [MaxLength(1)]
        public string? PriceOverWrite { get; set; }

        [MaxLength(1)]
        public string? DiscountOverWrite { get; set; }

        [MaxLength(1)]
        public string? CreditLimitOverWrite { get; set; }

        [Required]
        [MaxLength(8)]
        public string DistributorCode { get; set; }

        [MaxLength(1)]
        public string? LicenseType { get; set; }

        [Required]
        [MaxLength(1)]
        public string RestrictFOCInvoice { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }

        [Required]
        [MaxLength(40)]
        public string CreatedBy { get; set; }

        [Required]
        public DateTime UpdatedOn { get; set; }

        [Required]
        [MaxLength(40)]
        public string UpdatedBy { get; set; }

        [Required]
        [MaxLength(10)]
        public string ExecutiveCode { get; set; }

        [Required]
        [MaxLength(8)]
        public string SupplierCode { get; set; }

        [Required]
        [MaxLength(8)]
        public string CustomerCode { get; set; }

        [Required]
        [MaxLength(1)]
        public string ProPicAvailable { get; set; }

        public byte[]? ProfileImage { get; set; }

        [Required]
        [MaxLength(1)]
        public string AutoUnlock { get; set; }

        [Required]
        [MaxLength(15)]
        public string NicNumber { get; set; }

        [Required]
        [MaxLength(20)]
        public string TelephoneNumber { get; set; }

        [Required]
        [MaxLength(20)]
        public string MobileNumber { get; set; }

        [Required]
        [MaxLength(50)]
        public string EMailAddress { get; set; }

        [Required]
        [MaxLength(50)]
        public string AddressLine1 { get; set; }

        [Required]
        [MaxLength(50)]
        public string AddressLine2 { get; set; }

        [Required]
        [MaxLength(50)]
        public string AddressLine3 { get; set; }

        [Required]
        [MaxLength(50)]
        public string AddressLine4 { get; set; }

        [Required]
        [MaxLength(10)]
        public string PostalCode { get; set; }

        [Required]
        [MaxLength(1)]
        public string PasswordChange { get; set; }

        [Required]
        [MaxLength(1)]
        public string CaptionEditor { get; set; }

        [Required]
        [MaxLength(1)]
        public string POReturnAuthorizationLevel { get; set; }

        [Required]
        [MaxLength(1)]
        public string POReturnAuthorizationUpTo { get; set; }

        [Required]
        [MaxLength(1)]
        public string PUSQQtyEdit { get; set; }
    }
}
