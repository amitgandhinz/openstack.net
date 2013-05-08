using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using net.openstack.Core.Domain.CloudBackup;

namespace net.openstack.Core.Domain
{
    [DataContract]
    public class BackupAgentConfiguration
    {
        public SystemPreferences SystemPreferences { get; set; }
        public UserPreferences UserPreferences { get; set; }
        public IList<VolumeConfiguration> Volumes { get; set; }
        public IList<BackupConfigurationBlock> BackupConfigurations { get; set; }
    }
}

namespace net.openstack.Core.Domain.CloudBackup
{
    #region SystemPreferences

    [DataContract]
    public class SystemPreferences
    {
        public RateLimit RateLimit { get; set; }
        public AutoUpdate AutoUpdate { get; set; }
        public EnvironmentSettings Environment { get; set; }
        public Logging Logging { get; set; }
        public Rse Rse { get; set; }
    }

    [DataContract]
    public class RateLimit
    {
        public int RX { get; set; }
        public int TX { get; set; }
    }

    [DataContract]
    public class AutoUpdate
    {
        public Boolean Enabled { get; set; }
        public string LatestVersion { get; set; }
    }

    [DataContract]
    public class EnvironmentSettings
    {
        public DiskSpace MinimumDiskSpaceMb { get; set; }
    }


    [DataContract]
    public class DiskSpace
    {
        public int Backup { get; set; }
        public int Restore { get; set; }
        public int Cleanup { get; set; }
    }

    [DataContract]
    public class Logging
    {
        public string Level { get; set; }
    }

    [DataContract]
    public class Rse
    {
        public string Channel { get; set; }
        public string HostName { get; set; }
        public EventPolling Polling { get; set; }
        public Heartbeat Heartbeat { get; set; }
    }




    [DataContract]
    public class EventPolling
    {
        public Interval Interval { get; set; }
        public TimeOut Timeout { get; set; }
    }


    [DataContract]
    public class Interval
    {
        public int Idle { get; set; }
        public int Active { get; set; }
        public int RealTime { get; set; }
    }


    [DataContract]
    public class TimeOut
    {
        public int Idle { get; set; }
        public int Active { get; set; }
        public int RealTime { get; set; }
    }

    [DataContract]
    public class Heartbeat
    {
        public Interval Interval { get; set; }
        public TimeOut Timeout { get; set; }
    }

    #endregion


    #region UserPreferences

    [DataContract]
    public class UserPreferences
    {
        public string CacheDirectory { get; set; }
        public bool ThrottleBandwidth { get; set; }
    }

    #endregion


    #region Volume

    [DataContract]
    public class VolumeConfiguration
    {
        public string DataServicesDomain { get; set; }
        public string Uri { get; set; }
        public string FailoverUri { get; set; }
        public Boolean EncryptionEnabled { get; set; }
        public string Password { get; set; }
        public string NetworkDrives { get; set; } 
        public string BackupVaultId { get; set; }
    }

    #endregion


    #region BackupConfigurationBlock

    /// <summary>
    /// This is the configuration section that gets serialized to the config file
    /// </summary>
    [DataContract]
    public class BackupConfigurationBlock
    {
        public int Id { get; set; }
        public string VolumeUri { get; set; }
        public string VolumeFailoverUri { get; set; }
        public string Name { get; set; }
        public Boolean IsEnabled { get; set; }
        public int DaysToKeepOldFileVersions { get; set; }
        public Boolean KeepOldFileVersionsIndefinitely { get; set; }
        public List<BackupConfigurationAgentScheduleBlock> Schedules { get; set; }
        public IList<FileItem> Inclusions { get; set; }
        public IList<FileItem> Exclusions { get; set; }
    }

    [DataContract]
    public class BackupConfigurationScheduleBlock
    {
        public string Frequency { get; set; }
        public string DayOfWeek { get; set; }
        public string TimeOfDay { get; set; } //UTC Time
        public int HourlyInterval { get; set; }
        public string InitialScheduledTime { get; set; } // UTC Time
        public String TimeZoneId { get; set; }
        public String TimeZoneOffset { get; set; }

    }

    [DataContract]
    public class BackupConfigurationAgentScheduleBlock
    {
        public String Start { get; set; }
        public String End { get; set; }
        public String InitialScheduledTime { get; set; }
        public String Frequency { get; set; }
        public String TimeOfDay { get; set; }
        public String DayOfWeek { get; set; }
        public int HourlyInterval { get; set; }
        public bool IsDST { get; set; }
        public double Offset { get; set; }
    }

    [DataContract]
    public class FileItem
    {
        public string Pattern { get; private set; }
        public string Type { get; private set; }
        public string Module { get; private set; }
        public string Args { get; private set; }
    }

    #endregion

}
