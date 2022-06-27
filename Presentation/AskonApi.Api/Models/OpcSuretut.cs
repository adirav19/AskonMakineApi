using System;
using System.Collections.Generic;

namespace AskonApi.Api.Models
{
    public partial class OpcSuretut
    {
        public int Id { get; set; }
        public int? MakId { get; set; }
        public DateTime? Tarih { get; set; }
        public string? Saat { get; set; }
        public int? Aktif { get; set; }
        public int? Erisimsiz { get; set; }
        public int? Kesim { get; set; }
        public int? Durus { get; set; }
        public int? Finish { get; set; }
        public string? Aciklama { get; set; }
        public int? RefSayisal { get; set; }
        public string? RefString { get; set; }
        public DateTime? RecDt { get; set; }
    }
}
