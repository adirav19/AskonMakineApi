using System;
using System.Collections.Generic;

namespace AskonApi.Api.Models
{
    public partial class OpcLiveWorkcode
    {
        public int Id { get; set; }
        public int? MacId { get; set; }
        public string? JobNo { get; set; }
        public DateTime? RecDt { get; set; }
        public DateTime? Tarih { get; set; }
        public string? Saat { get; set; }
    }
}
