using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace net.openstack.Core.Domain
{
    

    [DataContract]
    public class BackupReport
    {
        [DataMember(Name="BackupId")]
        public int Id { get; set; }

        [DataMember(Name="BackupConfigurationId")]
        public int BackupConfigurationId { get; set; }

        [DataMember(Name="BackupConfigurationName")]
        public string BackupConfigurationName { get; set; }

        [DataMember(Name="BackupConfigurationIsDeleted")]
        public bool BackupConfigurationIsDeleted { get; set; }

        [DataMember(Name="ComputerName")]
        public bool AgentName { get; set; }

        [DataMember(Name="MachineAgentId")]
        public int AgentId { get; set; }

        [DataMember(Name="State")]
        public string State { get; set; }

        [DataMember(Name="CanRestore")]
        public bool CanRestore { get; set; }

        [DataMember(Name="StartTime")]
        public DateTime StartTime { get; set; }

        [DataMember(Name="CompletedTime")]
        public DateTime CompletedTime { get; set; }

        [DataMember(Name="Duration")]
        public string Duration { get; set; }

        [DataMember(Name="FilesSearched")]
        public long FilesSearched { get; set; }

        [DataMember(Name="BytesSearched")]
        public string BytesSearched { get; set; }

        [DataMember(Name="FilesBackedUp")]
        public long FilesBackedUp { get; set; }

        [DataMember(Name="BytesBackedUp")]
        public string BytesBackedUp { get; set; }

        [DataMember(Name="NumErrors")]
        public int NumErrors { get; set; }

        [DataMember(Name="Reason")]
        public string Reason { get; set; }

        [DataMember(Name="ErrorList")]
        public IList<BackupError> ErrorList { get; set; }
    }

    [DataContract]
    public class BackupError
    {
        [DataMember(Name="BackupReportID")]
        public int BackupReportID { get; set; }

        [DataMember(Name="ListIndex")]
        public int ListIndex { get; set; }

        [DataMember(Name="ErrorType")]
        public int ErrorType { get; set; }

        [DataMember(Name="ErrorDesc")]
        public string ErrorDesc { get; set; }

        [DataMember(Name="ExceptionDesc")]
        public string ExceptionDesc { get; set; }

        [DataMember(Name="ExceptionDetails")]
        public string ExceptionDetails { get; set; }

        [DataMember(Name="ExceptionCode")]
        public string ExceptionCode { get; set; }

        [DataMember(Name="Path")]
        public string Path { get; set; }
    }
}
  