namespace ModelEF.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietHoaDon")]
    public partial class ChiTietHoaDon
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string HoaDon_Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string SanPham_Id { get; set; }

        public int? SoLuong { get; set; }

        public decimal? Gia { get; set; }

        public virtual HoaDon HoaDon { get; set; }

        public virtual SanPham SanPham { get; set; }
    }
}
