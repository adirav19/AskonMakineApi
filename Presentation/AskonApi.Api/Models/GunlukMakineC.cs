using System;
using System.Collections.Generic;

namespace AskonApi.Api.Models
{
    public partial class GunlukMakineC
    {
        public int Idw { get; set; }
        public string? Vardiyaw { get; set; }
        public TimeSpan? Baslangicw { get; set; }
        public TimeSpan? Bitisw { get; set; }
        public bool? Gundegisimiw { get; set; }
        public byte? Grupw { get; set; }
        public bool? Gunduzw { get; set; }
        public string? Baslangic2 { get; set; }
        public string? Bitis2 { get; set; }
        public string? Mesai { get; set; }
        public int? Seconds { get; set; }
        public string OranKesim { get; set; } = null!;
        public string KesimAktifOran { get; set; } = null!;
        public string OranAktif { get; set; } = null!;
        public int Id { get; set; }
        public string? MachineNick { get; set; }
        public int? Aktif { get; set; }
        public TimeSpan? Aktif2 { get; set; }
        public int? Erişimsiz { get; set; }
        public TimeSpan? Erisimsiz2 { get; set; }
        public int? Kesim { get; set; }
        public TimeSpan? Kesim2 { get; set; }
        public int? Duruş { get; set; }
        public TimeSpan? Duruş2 { get; set; }
        public int? Finiş { get; set; }
        public TimeSpan? Finish2 { get; set; }
    }
}
