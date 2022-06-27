using System;
using System.Collections.Generic;

namespace AskonApi.Api.Models
{
    public partial class OpcMachine
    {
        public int Id { get; set; }
        public string? MachineNo { get; set; }
        public string? MachineName { get; set; }
        public string? MachineIp { get; set; }
        public string? MachineNick { get; set; }
        public string? MachinePath { get; set; }
        public string? MachineComment { get; set; }
        public bool? MachineReadable { get; set; }
        public byte? MachineWorkgroup { get; set; }
        public byte? MachineWtype { get; set; }
        public string? MachineAskonName { get; set; }
        /// <summary>
        /// OPC Uyumlu ve olmayan makinelerin farklı ayrıştırılmaları için hazırlanmış bir alandır.
        /// </summary>
        public int? MachineProjectCode { get; set; }
    }
}
