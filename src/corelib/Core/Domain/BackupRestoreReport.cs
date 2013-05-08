using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace net.openstack.Core.Domain
{
    
    [DataContract]
    public class BackupRestoreReport
    {
        [DataMember(Name="RestoreId")]
        public int RestoreId { get; set; }

        [DataMember(Name="StartedTime")]
        public DateTime StartedTime { get; set; }

        [DataMember(Name="EndedTime")]
        public DateTime EndedTime { get; set; }

        [DataMember(Name="TotalFilesRestored")]
        public long FilesRestored { get; set; }

        [DataMember(Name="TotalBytesRestored")]
        public string BytesRestored { get; set; }

        [DataMember(Name="Errors")]
        public IList<BackupRestoreError> Errors { get; set; }

    }

    [DataContract]
    public class BackupRestoreError
    {
        [DataMember(Name="Count")]
        public int Count { get; set; }

        [DataMember(Name="ReasonCode")]
        public string ReasonCode { get; set; }

        [DataMember(Name="Diagnostics")]
        public string Diagnostics { get; set; }

        [DataMember(Name="List")]
        public IList<BackupRestoreException> ErrorList { get; set; }
    }

    [DataContract]
    public class BackupRestoreException
    {
        [DataMember(Name="Description")]
        public string Description { get; set; }

        [DataMember(Name="Details")]
        public string Details { get; set; }

        [DataMember(Name="ExCode")]
        public int ExCode { get; set; }
    }
}
  