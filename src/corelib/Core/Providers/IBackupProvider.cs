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

        /// <summary>
        /// Get the agent configuration containing what and where to backup
        /// </summary>
        /// <param name="id">The cloud backup agent id.</param>
        /// <param name="identity">The users Cloud Identity. <see cref="CloudIdentity"/> <remarks>If not specified, the default identity given in the constructor will be used.</remarks> </param>
        /// <returns></returns>
        BackupAgentConfiguration GetAgentConfiguration(int id, CloudIdentity identity = null);
        
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


        #region Backups

        /// <summary>
        /// Get a Backup Execution
        /// </summary>
        /// <param name="id">The cloud backup configuration to delete.</param>
        /// <param name="identity">The users Cloud Identity. <see cref="CloudIdentity"/> <remarks>If not specified, the default identity given in the constructor will be used.</remarks> </param>
        /// <returns></returns>
        BackupExecution GetBackupExecution(int id, CloudIdentity identity = null);

        /// <summary>
        /// Start a Backup Execution
        /// </summary>
        /// <param name="backupConfigurationId">The cloud backup configuration to start.</param>
        /// <param name="identity">The users Cloud Identity. <see cref="CloudIdentity"/> <remarks>If not specified, the default identity given in the constructor will be used.</remarks> </param>
        /// <returns></returns>
        int StartBackupExecution(int backupConfigurationId, CloudIdentity identity = null);

        /// <summary>
        /// Stop a Backup Execution
        /// </summary>
        /// <param name="id">The cloud backup execution to stop.</param>
        /// <param name="identity">The users Cloud Identity. <see cref="CloudIdentity"/> <remarks>If not specified, the default identity given in the constructor will be used.</remarks> </param>
        /// <returns></returns>
        void StopBackupExecution(int id, CloudIdentity identity = null);

        /// <summary>
        /// Update a backup execution state
        /// </summary>
        /// <param name="id">The cloud backup execution to stop.</param>
        /// <param name="newState">The state the backup is now in.</param>
        /// <param name="identity">The users Cloud Identity. <see cref="CloudIdentity"/> <remarks>If not specified, the default identity given in the constructor will be used.</remarks> </param>
        /// <returns></returns>
        void UpdateBackupExecution(int id, string newState, CloudIdentity identity = null);

        /// <summary>
        /// Update a backup execution state
        /// </summary>
        /// <param name="id">The cloud backup execution to stop.</param>
        /// <param name="newState">The state the backup is now in.</param>
        /// <param name="identity">The users Cloud Identity. <see cref="CloudIdentity"/> <remarks>If not specified, the default identity given in the constructor will be used.</remarks> </param>
        /// <returns></returns>
        void UpdateBackupExecution(BackupReport report, CloudIdentity identity = null);


        /// <summary>
        /// Get a completed backup report
        /// </summary>
        /// <param name="id">The cloud backup configuration to delete.</param>
        /// <param name="identity">The users Cloud Identity. <see cref="CloudIdentity"/> <remarks>If not specified, the default identity given in the constructor will be used.</remarks> </param>
        /// <returns></returns>
        BackupReport GetBackupReport(int id, CloudIdentity identity = null);

        /// <summary>
        /// Get Backups that completed successfully that can be restored
        /// </summary>
        /// <param name="backupConfigurationId">The cloud backup configuration to list successful backups for.</param>
        /// <param name="identity">The users Cloud Identity. <see cref="CloudIdentity"/> <remarks>If not specified, the default identity given in the constructor will be used.</remarks> </param>
        /// <returns></returns>
        IList<BackupReport> ListSuccessfulBackups(int backupConfigurationId, CloudIdentity identity = null);


        #endregion

        #region Restore


        /// <summary>
        /// Start a new Restore
        /// </summary>
        /// <param name="restore">The restore configuration to start.</param>
        /// <param name="identity">The users Cloud Identity. <see cref="CloudIdentity"/> <remarks>If not specified, the default identity given in the constructor will be used.</remarks> </param>
        /// <returns></returns>
        BackupRestoreConfiguration StartRestore(BackupRestoreConfiguration restore, CloudIdentity identity = null);


        /// <summary>
        /// Start a new Restore
        /// </summary>
        /// <param name="restoreId">The restore execution to stop.</param>
        /// <param name="identity">The users Cloud Identity. <see cref="CloudIdentity"/> <remarks>If not specified, the default identity given in the constructor will be used.</remarks> </param>
        /// <returns></returns>
        void StopRestore(int restoreId, CloudIdentity identity = null);

        /// <summary>
        /// Get a completed restore report
        /// </summary>
        /// <param name="restoreId">The restore execution to report on.</param>
        /// <param name="identity">The users Cloud Identity. <see cref="CloudIdentity"/> <remarks>If not specified, the default identity given in the constructor will be used.</remarks> </param>
        /// <returns></returns>
        BackupRestoreReport GetRestoreReport(int restoreId, CloudIdentity identity = null);


        /// <summary>
        /// Get an executing restore
        /// </summary>
        /// <param name="restoreId">The restore execution to report on.</param>
        /// <param name="identity">The users Cloud Identity. <see cref="CloudIdentity"/> <remarks>If not specified, the default identity given in the constructor will be used.</remarks> </param>
        /// <returns></returns>
        BackupRestoreExecution GetRestoreExecution(int restoreId, CloudIdentity identity = null);

        /// <summary>
        /// Update a restore execution state
        /// </summary>
        /// <param name="id">The restore execution to update.</param>
        /// <param name="newState">The state the backup is now in.</param>
        /// <param name="identity">The users Cloud Identity. <see cref="CloudIdentity"/> <remarks>If not specified, the default identity given in the constructor will be used.</remarks> </param>
        /// <returns></returns>
        void UpdateRestoreExecution(int id, string newState, CloudIdentity identity = null);

        /// <summary>
        /// Update a restore execution state
        /// </summary>
        /// <param name="report">The restore report.</param>
        /// <param name="identity">The users Cloud Identity. <see cref="CloudIdentity"/> <remarks>If not specified, the default identity given in the constructor will be used.</remarks> </param>
        /// <returns></returns>
        void UpdateRestoreExecution(BackupRestoreReport report, CloudIdentity identity = null);

        #endregion

        #region BackupActivity

        /// <summary>
        /// List all backup and restore activity for a user
        /// </summary>
        /// <param name="identity">The users Cloud Identity. <see cref="CloudIdentity"/> <remarks>If not specified, the default identity given in the constructor will be used.</remarks> </param>
        /// <returns></returns>
        IList<BackupActivity> ListUserActivity(CloudIdentity identity = null);


        /// <summary>
        /// List all backup and restore activity for an agent
        /// </summary>
        /// <param name="id">The id of the agent to report activity on.</param>
        /// <param name="identity">The users Cloud Identity. <see cref="CloudIdentity"/> <remarks>If not specified, the default identity given in the constructor will be used.</remarks> </param>
        /// <returns></returns>
        IList<BackupActivity> ListAgentActivity(int id, CloudIdentity identity = null);


        #endregion

        #region Cleanup


        /// <summary>
        /// Start a new clean up
        /// </summary>
        /// <param name="id">The agent id whose vault you want to cleanup.</param>
        /// <param name="password">The encrypted password of the agent you want to cleanup.</param>
        /// <param name="identity">The users Cloud Identity. <see cref="CloudIdentity"/> <remarks>If not specified, the default identity given in the constructor will be used.</remarks> </param>
        /// <returns>Cleanup Id</returns>
        int StartCleanup(int id, string password, CloudIdentity identity = null);


        /// <summary>
        /// Stop an executing clean up
        /// </summary>
        /// <param name="restoreId">The cleanup execution to stop.</param>
        /// <param name="identity">The users Cloud Identity. <see cref="CloudIdentity"/> <remarks>If not specified, the default identity given in the constructor will be used.</remarks> </param>
        /// <returns></returns>
        void StopCleanup(int id, CloudIdentity identity = null);

        /// <summary>
        /// Get a completed cleanup report
        /// </summary>
        /// <param name="id">The cleanup execution to report on.</param>
        /// <param name="identity">The users Cloud Identity. <see cref="CloudIdentity"/> <remarks>If not specified, the default identity given in the constructor will be used.</remarks> </param>
        /// <returns></returns>
        BackupCleanupReport GetCleanupReport(int id, CloudIdentity identity = null);


        /// <summary>
        /// Update a cleanup execution state
        /// </summary>
        /// <param name="id">The cleanup execution to update.</param>
        /// <param name="newState">The state the backup is now in.</param>
        /// <param name="identity">The users Cloud Identity. <see cref="CloudIdentity"/> <remarks>If not specified, the default identity given in the constructor will be used.</remarks> </param>
        /// <returns></returns>
        void UpdateCleanupExecution(int id, string newState, CloudIdentity identity = null);

        /// <summary>
        /// Complete a cleanup execution state with a cleanup report
        /// </summary>
        /// <param name="report">The cleanup report.</param>
        /// <param name="identity">The users Cloud Identity. <see cref="CloudIdentity"/> <remarks>If not specified, the default identity given in the constructor will be used.</remarks> </param>
        /// <returns></returns>
        void UpdateCleanupExecution(BackupCleanupReport report, CloudIdentity identity = null);

        #endregion

    }
}
