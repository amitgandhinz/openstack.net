using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace net.openstack.Core.Domain
{
    [DataContract]
    public class BackupRestoreConfiguration
    {
        [DataMember(Name = "BackupId")]
        public int BackupId { get; set; }

        [DataMember(Name = "BackupMachineId")]
        public int SourceAgentId { get; set; }

        [DataMember(Name = "DestinationMachineId")]
        public int DestinationAgentId { get; set; }

        [DataMember(Name = "DestinationPath")]
        public string DestinationPath { get; set; }

        [DataMember(Name = "OverwriteFiles")]
        public bool OverwriteFiles { get; set; }

        [DataMember(Name = "EncryptedPassword")]
        public string EncryptedPassword { get; set; }

        [DataMember(Name = "Inclusions")]
        public IList<BackupFileConfiguration> Inclusions { get; set; }

        [DataMember(Name = "Exclusions")]
        public IList<BackupFileConfiguration> Exclusions { get; set; }

    }


}
