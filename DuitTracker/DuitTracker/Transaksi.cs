namespace DuitTracker
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Transaksi")]
    public partial class Transaksi
    {
        public int Id { get; set; }

        public int Nominal { get; set; }

        public int Tipe { get; set; }

        [Required]
        [StringLength(30)]
        public string Subtipe { get; set; }

        [StringLength(200)]
        public string Keterangan { get; set; }

        [Column(TypeName = "date")]
        public DateTime Tanggal { get; set; }
    }
}
