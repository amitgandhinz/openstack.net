using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace net.openstack.Core.Domain
{
              

    [DataContract]
    public class BackupCleanupReport
    {
        [DataMember(Name="CleanupReportId")]
        public int Id { get; set; }

        [DataMember(Name="CleanUpStateID")]
        public int CleanUpStateID { get; set; }

        [DataMember(Name="FileBytesBefore")]
        public long FileBytesBefore { get; set; }

        [DataMember(Name="FileBytesAfter")]
        public long FileBytesAfter { get; set; }

        [DataMember(Name="ProtectedBytes")]
        public long ProtectedBytes { get; set; }

        [DataMember(Name="Reason")]
        public string Reason { get; set; }

        [DataMember(Name="StartedTime")]
        public DateTime StartedTime { get; set; }

        [DataMember(Name="EndedTime")]
        public DateTime EndedTime { get; set; }

        [DataMember(Name="StartTime")]
        public DateTime StartTime { get; set; }

        [DataMember(Name="PurgedSnapshotIds")]
        public int[] PurgedSnapshotIds { get; set; }

        [DataMember(Name="List")]
        public IList<BackupCleanupError> ErrorList { get; set; }
    }

    [DataContract]
    public class BackupCleanupError
    {
        [DataMember(Name="ErrorType")]
        public int ErrorType { get; set; }

        [DataMember(Name="Exception")]
        public BackupCleanupException Exception { get; set; }

        [DataMember(Name="Index")]
        public int Index { get; set; }

        [DataMember(Name="Path")]
        public string Path { get; set; }
    }

    [DataContract]
    public class BackupCleanupException
    {
        [DataMember(Name="Description")]
        public string Description { get; set; }

        [DataMember(Name="Details")]
        public string Details { get; set; }

        [DataMember(Name="ExCode")]
        public int ExCode { get; set; }
    }
}