namespace SmsMis.Models.Console.Client
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InstrumentSerialMaster")]
    public partial class InstrumentSerialMaster
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CompanyCode { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BranchCode { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(255)]
        public string AccountCode { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int InstrumentTypeCode { get; set; }

        //[Key]
        //[Column(Order = 4)]
        public double StartingInstrumentNo { get; set; }

        public double EndingInstrumentNo { get; set; }

        public DateTime IssueDate { get; set; }

        public bool Status { get; set; }

        [Required]
        [StringLength(25)]
        public string AddByUserId { get; set; }

        public DateTime AddDateTime { get; set; }

        public virtual ICollection<InstrumentSerialDetail> InstrumentSerialDetail { get; set; }
    }
}
