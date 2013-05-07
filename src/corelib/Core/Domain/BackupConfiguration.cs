using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace net.openstack.Core.Domain
{
    [DataContract]
    public class BackupConfiguration
    {
        [DataMember(Name = "BackupConfigurationId")]
        public int Id { get; set; }

        [DataMember(Name = "MachineAgentId")]
        public int AgentId { get; set; }

        [DataMember(Name = "MachineName")]
        public string AgentName { get; set; }

        [DataMember(Name = "Flavor")]
        public string AgentFlavor { get; set; }

        [DataMember(Name = "IsEncrypted")]
        public string AgentEncrypted { get; set; }

        [DataMember(Name = "BackupConfigurationName")]
        public string Name { get; set; }

        [DataMember(Name = "IsActive")]
        public bool IsActive { get; set; }

        [DataMember(Name = "IsDeleted")]
        public bool IsDeleted { get; set; }

        [DataMember(Name = "VersionRetention")]
        public int VersionRetention { get; set; }

        [DataMember(Name = "BackupConfigurationScheduleId")]
        public int ScheduleId { get; set; }

        [DataMember(Name = "Frequency")]
        public string Frequency { get; set; }

        [DataMember(Name = "StartTimeHour")]
        public int StartTimeHour { get; set; }

        [DataMember(Name = "StartTimeMinute")]
        public int StartTimeMinute { get; set; }

        [DataMember(Name = "StartTimeAmPm")]
        public string StartTimeAmPm { get; set; }

        [DataMember(Name = "DayOfWeekId")]
        public int DayOfWeekId { get; set; }

        [DataMember(Name = "HourInterval")]
        public int HourInterval { get; set; }

        [DataMember(Name = "NextScheduledRunTime")]
        public DateTime NextScheduledRunTime { get; set; }

        [DataMember(Name = "LastRunTime")]
        public DateTime LastRunTime { get; set; }

        [DataMember(Name = "LastRunBackupReportId")]
        public int LastRunBackupReportId { get; set; }

        [DataMember(Name = "NotifyRecipients")]
        public string NotifyEmail { get; set; }

        [DataMember(Name = "NotifySuccess")]
        public bool NotifySuccess { get; set; }

        [DataMember(Name = "NotifyFailure")]
        public bool NotifyFailure { get; set; }

        [DataMember(Name = "Inclusions")]
        public IList<BackupFileConfiguration> Inclusions { get; set; }

        [DataMember(Name = "Exclusions")]
        public IList<BackupFileConfiguration> Exclusions { get; set; }

    }



    [DataContract]
    public class BackupFileConfiguration
    {
        [DataMember(Name = "FilePath")]
        public string FilePath { get; set; }

        [DataMember(Name = "FileItemType")]
        public string FileItemType { get; set; }

        [DataMember(Name = "FileId")]
        public int FileId { get; set; }

        [DataMember(Name = "ParentId")]
        public int ParentId { get; set; }
    }
}
