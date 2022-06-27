using System;
using System.Collections.Generic;

namespace AskonApi.Api.Models
{
    public partial class OpcDataLive
    {
        public int Id { get; set; }
        public int? MachineId { get; set; }
        public DateTime? ReadTime { get; set; }
        public bool? MachineStart { get; set; }
        public bool? MachineStop { get; set; }
        public bool? MachineFinish { get; set; }
        public string? SStartTime { get; set; }
        public string? SFinishTime { get; set; }
        public string? SGasType { get; set; }
        public long? NEstimatedTime { get; set; }
        public string? SltdProgramName { get; set; }
        public string? SltdProgramNameShort { get; set; }
        public string? AAlarms { get; set; }
        public double? FTotalGasO2cm3 { get; set; }
        public double? FTotalGasN2cm3 { get; set; }
        public double? FTotalGasAircm3 { get; set; }
        public byte? DataType { get; set; }
        public long? ReadNo { get; set; }
    }
}
