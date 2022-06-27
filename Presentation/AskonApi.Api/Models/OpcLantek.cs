using System;
using System.Collections.Generic;

namespace AskonApi.Api.Models
{
    public partial class OpcLantek
    {
        public int Id { get; set; }
        public DateTime? Cdate { get; set; }
        public string? Jobname { get; set; }
        public string? JobRef { get; set; }
        public byte? Sthickness { get; set; }
        public string? Cnc { get; set; }
        public double? Sarea { get; set; }
        public double? Suarea { get; set; }
        public double? Sweight { get; set; }
        public double? Suweight { get; set; }
        public int? Sxmax { get; set; }
        public int? Symax { get; set; }
        public double? Sprofit { get; set; }
        public double? SprofitS { get; set; }
        public int? Quantity { get; set; }
        public int? Slength { get; set; }
        public int? Swidth { get; set; }
        public int? Norder { get; set; }
        public string? ShtRef { get; set; }
        public double? Etime { get; set; }
        public string? ShtRefOrg { get; set; }
        public string? JobOrder { get; set; }
        public string? NstRef { get; set; }
        public string? MatRef { get; set; }
        public string? WrkRef { get; set; }
        public string? MatRef1 { get; set; }
    }
}
