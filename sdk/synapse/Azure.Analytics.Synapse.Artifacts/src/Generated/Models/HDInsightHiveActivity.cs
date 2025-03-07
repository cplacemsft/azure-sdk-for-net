// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> HDInsight Hive activity type. </summary>
    public partial class HDInsightHiveActivity : ExecutionActivity
    {
        /// <summary> Initializes a new instance of <see cref="HDInsightHiveActivity"/>. </summary>
        /// <param name="name"> Activity name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public HDInsightHiveActivity(string name) : base(name)
        {
            Argument.AssertNotNull(name, nameof(name));

            StorageLinkedServices = new ChangeTrackingList<LinkedServiceReference>();
            Arguments = new ChangeTrackingList<object>();
            Defines = new ChangeTrackingDictionary<string, object>();
            Variables = new ChangeTrackingList<object>();
            Type = "HDInsightHive";
        }

        /// <summary> Initializes a new instance of <see cref="HDInsightHiveActivity"/>. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="type"> Type of activity. </param>
        /// <param name="description"> Activity description. </param>
        /// <param name="state"> Activity state. This is an optional property and if not provided, the state will be Active by default. </param>
        /// <param name="onInactiveMarkAs"> Status result of the activity when the state is set to Inactive. This is an optional property and if not provided when the activity is inactive, the status will be Succeeded by default. </param>
        /// <param name="dependsOn"> Activity depends on condition. </param>
        /// <param name="userProperties"> Activity user properties. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="policy"> Activity policy. </param>
        /// <param name="storageLinkedServices"> Storage linked service references. </param>
        /// <param name="arguments"> User specified arguments to HDInsightActivity. </param>
        /// <param name="getDebugInfo"> Debug info option. </param>
        /// <param name="scriptPath"> Script path. Type: string (or Expression with resultType string). </param>
        /// <param name="scriptLinkedService"> Script linked service reference. </param>
        /// <param name="defines"> Allows user to specify defines for Hive job request. </param>
        /// <param name="variables"> User specified arguments under hivevar namespace. </param>
        /// <param name="queryTimeout"> Query timeout value (in minutes).  Effective when the HDInsight cluster is with ESP (Enterprise Security Package). </param>
        internal HDInsightHiveActivity(string name, string type, string description, ActivityState? state, ActivityOnInactiveMarkAs? onInactiveMarkAs, IList<ActivityDependency> dependsOn, IList<UserProperty> userProperties, IDictionary<string, object> additionalProperties, LinkedServiceReference linkedServiceName, ActivityPolicy policy, IList<LinkedServiceReference> storageLinkedServices, IList<object> arguments, HDInsightActivityDebugInfoOption? getDebugInfo, object scriptPath, LinkedServiceReference scriptLinkedService, IDictionary<string, object> defines, IList<object> variables, int? queryTimeout) : base(name, type, description, state, onInactiveMarkAs, dependsOn, userProperties, additionalProperties, linkedServiceName, policy)
        {
            StorageLinkedServices = storageLinkedServices;
            Arguments = arguments;
            GetDebugInfo = getDebugInfo;
            ScriptPath = scriptPath;
            ScriptLinkedService = scriptLinkedService;
            Defines = defines;
            Variables = variables;
            QueryTimeout = queryTimeout;
            Type = type ?? "HDInsightHive";
        }

        /// <summary> Storage linked service references. </summary>
        public IList<LinkedServiceReference> StorageLinkedServices { get; }
        /// <summary> User specified arguments to HDInsightActivity. </summary>
        public IList<object> Arguments { get; }
        /// <summary> Debug info option. </summary>
        public HDInsightActivityDebugInfoOption? GetDebugInfo { get; set; }
        /// <summary> Script path. Type: string (or Expression with resultType string). </summary>
        public object ScriptPath { get; set; }
        /// <summary> Script linked service reference. </summary>
        public LinkedServiceReference ScriptLinkedService { get; set; }
        /// <summary> Allows user to specify defines for Hive job request. </summary>
        public IDictionary<string, object> Defines { get; }
        /// <summary> User specified arguments under hivevar namespace. </summary>
        public IList<object> Variables { get; }
        /// <summary> Query timeout value (in minutes).  Effective when the HDInsight cluster is with ESP (Enterprise Security Package). </summary>
        public int? QueryTimeout { get; set; }
    }
}
