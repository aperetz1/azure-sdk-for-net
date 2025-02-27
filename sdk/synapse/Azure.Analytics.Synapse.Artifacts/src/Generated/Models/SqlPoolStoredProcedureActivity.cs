// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Execute SQL pool stored procedure activity. </summary>
    public partial class SqlPoolStoredProcedureActivity : Activity
    {
        /// <summary> Initializes a new instance of SqlPoolStoredProcedureActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="sqlPool"> SQL pool stored procedure reference. </param>
        /// <param name="storedProcedureName"> Stored procedure name. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="sqlPool"/> or <paramref name="storedProcedureName"/> is null. </exception>
        public SqlPoolStoredProcedureActivity(string name, SqlPoolReference sqlPool, object storedProcedureName) : base(name)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(sqlPool, nameof(sqlPool));
            Argument.AssertNotNull(storedProcedureName, nameof(storedProcedureName));

            SqlPool = sqlPool;
            StoredProcedureName = storedProcedureName;
            Type = "SqlPoolStoredProcedure";
        }

        /// <summary> Initializes a new instance of SqlPoolStoredProcedureActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="type"> Type of activity. </param>
        /// <param name="description"> Activity description. </param>
        /// <param name="state"> Activity state. This is an optional property and if not provided, the state will be Active by default. </param>
        /// <param name="onInactiveMarkAs"> Status result of the activity when the state is set to Inactive. This is an optional property and if not provided when the activity is inactive, the status will be Succeeded by default. </param>
        /// <param name="dependsOn"> Activity depends on condition. </param>
        /// <param name="userProperties"> Activity user properties. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="sqlPool"> SQL pool stored procedure reference. </param>
        /// <param name="storedProcedureName"> Stored procedure name. Type: string (or Expression with resultType string). </param>
        /// <param name="storedProcedureParameters"> Value and type setting for stored procedure parameters. Example: "{Parameter1: {value: "1", type: "int"}}". </param>
        internal SqlPoolStoredProcedureActivity(string name, string type, string description, ActivityState? state, ActivityOnInactiveMarkAs? onInactiveMarkAs, IList<ActivityDependency> dependsOn, IList<UserProperty> userProperties, IDictionary<string, object> additionalProperties, SqlPoolReference sqlPool, object storedProcedureName, object storedProcedureParameters) : base(name, type, description, state, onInactiveMarkAs, dependsOn, userProperties, additionalProperties)
        {
            SqlPool = sqlPool;
            StoredProcedureName = storedProcedureName;
            StoredProcedureParameters = storedProcedureParameters;
            Type = type ?? "SqlPoolStoredProcedure";
        }

        /// <summary> SQL pool stored procedure reference. </summary>
        public SqlPoolReference SqlPool { get; set; }
        /// <summary> Stored procedure name. Type: string (or Expression with resultType string). </summary>
        public object StoredProcedureName { get; set; }
        /// <summary> Value and type setting for stored procedure parameters. Example: "{Parameter1: {value: "1", type: "int"}}". </summary>
        public object StoredProcedureParameters { get; set; }
    }
}
