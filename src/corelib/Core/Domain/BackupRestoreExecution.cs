using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace net.openstack.Core.Domain
{

    [DataContract]
    public class BackupRestoreExecution
    {
        [DataMember(Name = "RestoreId")]
        public int RestoreId { get; set; }

        [DataMember(Name = "BackupId")]
        public int BackupId { get; set; }

        [DataMember(Name = "OverwriteFiles")]
        public bool OverwriteFiles { get; set; }

        [DataMember(Name = "BackupConfigurationId")]
        public int BackupConfigurationId { get; set; }

         [DataMember(Name = "BackupRestorePoint")]
        public DateTime BackupRestorePoint { get; set; }

        [DataMember(Name = "RestoreStateId")]
        public int CurrentState { get; set; }

        [DataMember(Name = "BackupConfigurationName")]
        public string BackupConfigurationName { get; set; }

        [DataMember(Name = "BackupMachineId")]
        public int SourceAgentId { get; set; }

        [DataMember(Name = "BackupMachineName")]
        public string SourceName { get; set; }

        [DataMember(Name = "DestinationMachineId")]
        public int DestinationAgentId { get; set; }

        [DataMember(Name = "DestinationMachineName")]
        public string DestinationName { get; set; }

         [DataMember(Name = "DestinationPath")]
        public string DestinationPath { get; set; }

        [DataMember(Name = "IsEncrypted")]
        public bool IsEncrypted { get; set; }

        [DataMember(Name = "EncryptedPassword")]
        public string EncryptedPassword { get; set; }

        [DataMember(Name = "EncryptionKey")]
        public net.openstack.Core.Domain.PublicKey EncryptionKey { get; set; }

        [DataMember(Name = "BackupFlavor")]
        public string BackupFlavor { get; set; }

        
    }
}
  