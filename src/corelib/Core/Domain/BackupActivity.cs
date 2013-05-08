using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace net.openstack.Core.Domain
{
    [DataContract]
    public class BackupActivity
    {
        [DataMember(Name="ID")]
        public int Id { get; set; }

        [DataMember(Name="Type")]
        public int Type { get; set; }

        [DataMember(Name="ParentId")]
        public int ParentId { get; set; }

        [DataMember(Name="DisplayName")]
        public string DisplayName { get; set; }

        [DataMember(Name="IsBackupConfigurationDeleted")]
        public bool DeletedConfiguration { get; set; }

        [DataMember(Name="SourceMachineAgentId")]
        public int SourceAgentId { get; set; }

        [DataMember(Name="SourceMachineName")]
        public string SourceName { get; set; }

        [DataMember(Name="DestinationMachineAgentId")]
        public int DestinationAgentId { get; set; }

        [DataMember(Name="DestinationMachineName")]
        public string DestinationName { get; set; }

        [DataMember(Name="CurrentState")]
        public string CurrentState { get; set; }

        [DataMember(Name="TimeOfActivity")]
        public DateTime TimeOfActivity { get; set; }
       
    }



}
