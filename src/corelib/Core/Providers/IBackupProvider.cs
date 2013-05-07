using System;
using System.Collections.Generic;
using System.IO;
using net.openstack.Core.Domain;
using net.openstack.Core.Exceptions;
using net.openstack.Providers.Rackspace.Exceptions;

namespace net.openstack.Core.Providers
{
    /// <summary>
    /// Provides simple access to the Rackspace Cloud Backup Services.
    /// </summary>
    public interface IBackupProvider
    {
        #region BackupAgent

        /// <summary>
        /// Get Details about a Cloud Backup Agent
        /// </summary>
        /// <param name="id">The cloud backup agent id.</param>
        /// <param name="identity">The users Cloud Identity. <see cref="CloudIdentity"/><remarks>If not specified, the default identity given in the constructor will be used.</remarks> </param>
        /// <returns><see cref="BackupAgent"/></returns>
        IList<BackupAgent> ListAgents(CloudIdentity identity = null);

        /// <summary>
        /// Get Details about a Cloud Backup Agent
        /// </summary>
        /// <param name="id">The cloud backup agent id.</param>
        /// <param name="identity">The users Cloud Identity. <see cref="CloudIdentity"/><remarks>If not specified, the default identity given in the constructor will be used.</remarks> </param>
        /// <returns><see cref="BackupAgent"/></returns>
        BackupAgent GetAgentDetails(int id, CloudIdentity identity = null);

        /// <summary>
        /// Enable/Disable a Cloud Backup Agent
        /// </summary>
        /// <param name="id">The cloud backup agent id.</param>
        /// <param name="disable">true or false.</param>
        /// <param name="identity">The users Cloud Identity. <see cref="CloudIdentity"/> <remarks>If not specified, the default identity given in the constructor will be used.</remarks> </param>
        /// <returns></returns>
        void ToggleAgent(int id, bool disable = false, CloudIdentity identity = null);

        /// <summary>
        /// Delete a Cloud Backup Agent permanently, including its backup vault.
        /// </summary>
        /// <param name="id">The cloud backup agent id.</param>
        /// <param name="identity">The users Cloud Identity. <see cref="CloudIdentity"/> <remarks>If not specified, the default identity given in the constructor will be used.</remarks> </param>
        /// <returns></returns>
        void DeleteAgent(int id, CloudIdentity identity = null);

        /// <summary>
        /// Register a new Cloud Backup Agent
        /// </summary>
        /// <param name="id">The cloud backup agent id.</param>
        /// <param name="identity">The users Cloud Identity. <see cref="CloudIdentity"/> <remarks>If not specified, the default identity given in the constructor will be used.</remarks> </param>
        /// <returns></returns>
        void CreateAgent(int id, CloudIdentity identity = null);

        /// <summary>
        /// Authenticate an existing Cloud Backup Agent
        /// </summary>
        /// <param name="id">The cloud backup agent id.</param>
        /// <param name="identity">The users Cloud Identity. <see cref="CloudIdentity"/> <remarks>If not specified, the default identity given in the constructor will be used.</remarks> </param>
        /// <returns></returns>
        void AuthenticateAgent(int id, CloudIdentity identity = null);


        /// <summary>
        /// Delete a Cloud Backup Agent permanently, including its backup vault.
        /// </summary>
        /// <param name="id">The cloud backup agent id.</param>
        /// <param name="encryptedPassword">Hex string of the password, encrypted using the <see cref="BackupAgent.EncryptionKey"/>.</param>
        /// <param name="identity">The users Cloud Identity. <see cref="CloudIdentity"/> <remarks>If not specified, the default identity given in the constructor will be used.</remarks> </param>
        /// <returns></returns>
        Guid EncryptAgent(int id, string encryptedPassword, CloudIdentity identity = null);

        
        #endregion

        #region Backup Configuration


        /// <summary>
        /// List Backup Configurations
        /// </summary>
        /// <param name="identity">The users Cloud Identity. <see cref="CloudIdentity"/> <remarks>If not specified, the default identity given in the constructor will be used.</remarks> </param>
        /// <returns></returns>
        IList<BackupConfiguration> ListBackupConfigurations(CloudIdentity identity = null);


        /// <summary>
        /// Create a Backup Configuration
        /// </summary>
        /// <param name="backupConfig">The cloud backup configuration to create.</param>
        /// <param name="identity">The users Cloud Identity. <see cref="CloudIdentity"/> <remarks>If not specified, the default identity given in the constructor will be used.</remarks> </param>
        /// <returns></returns>
        BackupConfiguration CreateBackupConfiguration(BackupConfiguration backupConfig, CloudIdentity identity = null);

        /// <summary>
        /// Update a Backup Configuration
        /// </summary>
        /// <param name="backupConfig">The cloud backup configuration to update.</param>
        /// <param name="identity">The users Cloud Identity. <see cref="CloudIdentity"/> <remarks>If not specified, the default identity given in the constructor will be used.</remarks> </param>
        /// <returns></returns>
        BackupConfiguration UpdateBackupConfiguration(BackupConfiguration backupConfig, CloudIdentity identity = null);

        /// <summary>
        /// Get a Backup Configuration
        /// </summary>
        /// <param name="id">The cloud backup configuration to get.</param>
        /// <param name="identity">The users Cloud Identity. <see cref="CloudIdentity"/> <remarks>If not specified, the default identity given in the constructor will be used.</remarks> </param>
        /// <returns></returns>
        BackupConfiguration GetBackupConfiguration(int id, CloudIdentity identity = null);


        /// <summary>
        /// Delete a Backup Configuration
        /// </summary>
        /// <param name="id">The cloud backup configuration to delete.</param>
        /// <param name="identity">The users Cloud Identity. <see cref="CloudIdentity"/> <remarks>If not specified, the default identity given in the constructor will be used.</remarks> </param>
        /// <returns></returns>
        void DeleteBackupConfiguration(int id, CloudIdentity identity = null);


        /// <summary>
        /// Enable/Disable a Backup Configuration
        /// </summary>
        /// <param name="id">The cloud backup configuration to enable/disable.</param>
        /// <param name="enable">enable/disable the configuration.</param>
        /// <param name="identity">The users Cloud Identity. <see cref="CloudIdentity"/> <remarks>If not specified, the default identity given in the constructor will be used.</remarks> </param>
        /// <returns></returns>
        BackupConfiguration ToggleBackupConfiguration(int id, bool enable, CloudIdentity identity = null);


        #endregion

      
    }
}
