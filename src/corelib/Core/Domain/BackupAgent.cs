using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace net.openstack.Core.Domain
{
    [DataContract]
    public class BackupAgent
    {
        [DataMember(Name="AgentVersion")]
        public string Version { get; set; }

        [DataMember]
        public string Architecture { get; set; }

        [DataMember]
        public string Flavor { get; set; }

        [DataMember(Name="BackupVaultSize")]
        public string VaultSize { get; set; }

        [DataMember(Name="Datacenter")]
        public string ServerRegion { get; set; }

        [DataMember(Name="BackupDatacenter")]
        public string StorageRegion { get; set; }

        [DataMember]
        public string IPAddress { get; set; }

        [DataMember]
        public bool IsDisabled { get; set; }

        [DataMember]
        public bool IsEncrypted { get; set; }

        [DataMember(Name="MachineAgentId")]
        public int Id { get; set; }

        [DataMember(Name="MachineAgentName")]
        public string AgentName { get; set; }

        [DataMember]
        public string OperatingSystem { get; set; }

        [DataMember]
        public string OperatingSystemVersion { get; set; }

        [DataMember]
        public string Status { get; set; }

        [DataMember]
        public bool UseServiceNet { get; set; }

        [DataMember(Name="PublicKey")]
        public PublicKey EncryptionKey { get; set; }
    }


    [DataContract]
    public class PublicKey
    {
        [DataMember(Name="ModulusHex")]
        public string Modulus { get; set; }

        [DataMember(Name="ExponentHex")]
        public string Exponent { get; set; }
    }

}
