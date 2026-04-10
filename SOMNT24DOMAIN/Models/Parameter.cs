using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOMNT24DOMAIN.Models
{
    [Table("Parameter", Schema = "XA")]
    public class Parameters
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RecordID { get; set; }

        [Required]
        [StringLength(4)]
        public string BusinessUnit { get; set; } = string.Empty;

        [Required]
        [StringLength(8)]
        public string ParameterGroup { get; set; } = string.Empty;

        [Required]
        [StringLength(50)]
        public string ParameterGroupDescription { get; set; } = string.Empty;

        [Required]
        [StringLength(99)]
        public string Parameter { get; set; } = string.Empty;

        [Required]
        [StringLength(200)]
        public string ParameterDescription { get; set; } = string.Empty;

        [Required]
        public short ParameterLimit { get; set; }

        [Required]
        [Column(TypeName = "decimal(11, 0)")]
        public decimal ParameterValue { get; set; }

        [Required]
        [StringLength(1)]
        public string ParameterType { get; set; } = string.Empty;

        [Required]
        [StringLength(8)]
        public string ParentParameterGroup { get; set; } = string.Empty;

        [Required]
        [StringLength(10)]
        public string ParentParameter { get; set; } = string.Empty;

        [Required]
        public int Color { get; set; } = 0;

        [Required]
        [StringLength(1)]
        public string Status { get; set; } = string.Empty;

        [Required]
        public DateTime CreatedOn { get; set; } = DateTime.Now;

        [Required]
        [StringLength(40)]
        public string CreatedBy { get; set; } = string.Empty;

        [Required]
        public DateTime UpdatedOn { get; set; } = DateTime.Now;

        [Required]
        [StringLength(40)]
        public string UpdatedBy { get; set; } = string.Empty;


        [Timestamp]
        public byte[] TimeStamp { get; set; } = Array.Empty<byte>();

        [Required]
        [StringLength(1)]
        public string ASMBudget { get; set; } = string.Empty;

        [Required]
        [StringLength(1)]
        public string InvoiceValue { get; set; } = string.Empty;

        [Column(TypeName = "decimal(15, 4)")]
        public decimal UserDefinedField1 { get; set; } = 0;

        public int UserDefinedField2 { get; set; } = 0;

        public int UserDefinedField3 { get; set; } = 0;

        public int UserDefinedField4 { get; set; } = 0;

        [Column(TypeName = "decimal(15, 4)")]
        public decimal UserDefinedField5 { get; set; } = 0;

        [Column(TypeName = "decimal(15, 4)")]
        public decimal UserDefinedField6 { get; set; } = 0;

        [Required]
        [StringLength(1)]
        public string CaptureImage { get; set; } = "0";

        [Required]
        [StringLength(1)]
        public string UserDefinedField7 { get; set; } = "0";

        [StringLength(30)]
        public string UserDefinedField8 { get; set; } = string.Empty;

        [StringLength(50)]
        public string UserDefinedField9 { get; set; } = string.Empty;

        [StringLength(50)]
        public string UDF1Description { get; set; } = string.Empty;

        [StringLength(50)]
        public string UDF2Description { get; set; } = string.Empty;

        [StringLength(50)]
        public string UDF3Description { get; set; } = string.Empty;

        [StringLength(50)]
        public string UDF4Description { get; set; } = string.Empty;

        [StringLength(50)]
        public string UDF5Description { get; set; } = string.Empty;

        [StringLength(50)]
        public string UDF6Description { get; set; } = string.Empty;

        [StringLength(50)]
        public string UDF7Description { get; set; } = string.Empty;

        [StringLength(50)]
        public string UDF8Description { get; set; } = string.Empty;

        [StringLength(50)]
        public string UDF9Description { get; set; } = string.Empty;
    }
}
