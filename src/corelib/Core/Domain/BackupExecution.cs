using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace net.openstack.Core.Domain
{
    [DataContract]
    public class BackupExecution
    {
        [DataMember(Name = "BackupId")]
        public int BackupId { get; set; }

        [DataMember(Name = "BackupConfigurationId")]
        public int BackupConfigurationId { get; set; }

        [DataMember(Name = "CurrentState")]
        public string CurrentState { get; set; }

        [DataMember(Name = "BackupConfigurationName")]
        public string BackupConfigurationName { get; set; }

        [DataMember(Name = "MachineAgentId")]
        public int MachineAgentId { get; set; }

        [DataMember(Name = "MachineName")]
        public int MachineName { get; set; }

        [DataMember(Name = "StateChangeTime")]
        public DateTime StateChangeTime { get; set; }

        [DataMember(Name = "IsEncrypted")]
        public bool IsEncrypted { get; set; }

        [DataMember(Name = "EncryptionKey")]
        public net.openstack.Core.Domain.PublicKey EncryptionKey { get; set; }
    }
}
  