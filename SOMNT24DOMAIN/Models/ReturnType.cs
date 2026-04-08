using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

[Table("ReturnType", Schema = "Rd")]
public class ReturnType
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int RecID { get; set; }

    [DataMember]
    [Column(TypeName = "char(4)")]
    public string BusinessUnit { get; set; }

    [DataMember]
    [Column(TypeName = "char(2)")]
    public string ModuleCode { get; set; }

    [DataMember]
    [NotMapped]
    public string? ModuleCodeDesc { get; set; }

    [DataMember]
    [Column("ReturnType", TypeName = "char(2)")]
    public string RetnType { get; set; }

    [DataMember]
    [Column(TypeName = "varchar(40)")]
    public string Description { get; set; }

    [DataMember]
    [Column(TypeName = "char(2)")]
    public string ReturnCategory { get; set; }

    [DataMember]
    [NotMapped]
    public string? ReturnCategoryDesc { get; set; }

    [DataMember]
    [Column(TypeName = "char(1)")]
    public string ProcessingRequired { get; set; }

    [DataMember]
    [Column(TypeName = "char(1)")]
    public string Status { get; set; }

    [DataMember]
    [Column(TypeName = "varchar(40)")]
    public string LastUpdatedBy { get; set; }

    [DataMember]
    public DateTime LastUpdatedOn { get; set; }

    [Timestamp]
    [NotMapped]
    public byte[]? TimeStamp { get; set; }

    [DataMember]
    public DateTime CreatedOn { get; set; }

    [DataMember]
    [Column(TypeName = "varchar(40)")]
    public string CreatedBy { get; set; }

    [DataMember]
    [Column(TypeName = "char(1)")]
    public string ReturnDeductionType { get; set; }

    [DataMember]
    [Column(TypeName = "char(1)")]
    public string ValidateReturnValue { get; set; }
}