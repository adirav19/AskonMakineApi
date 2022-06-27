using System;
using System.Collections.Generic;

namespace AskonApi.Api.Models
{
    public partial class VardiyaC
    {
        public int Id { get; set; }
        public string? Vardiya { get; set; }
        public TimeSpan? Baslangic { get; set; }
        public TimeSpan? Bitis { get; set; }
        public bool? Gundegisimi { get; set; }
        public byte? Grup { get; set; }
        public bool? Gunduz { get; set; }
        public bool? GundegisimiA { get; set; }
    }
}
