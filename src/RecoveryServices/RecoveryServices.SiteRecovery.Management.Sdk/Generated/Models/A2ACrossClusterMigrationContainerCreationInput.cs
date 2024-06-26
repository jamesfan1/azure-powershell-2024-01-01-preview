// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using System.Linq;

    /// <summary>
    /// A2ACrossClusterMigration cloud creation input.
    /// </summary>
    [Newtonsoft.Json.JsonObject("A2ACrossClusterMigration")]
    public partial class A2ACrossClusterMigrationContainerCreationInput : ReplicationProviderSpecificContainerCreationInput
    {
        /// <summary>
        /// Initializes a new instance of the A2ACrossClusterMigrationContainerCreationInput class.
        /// </summary>
        public A2ACrossClusterMigrationContainerCreationInput()
        {
            CustomInit();
        }


        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

    }
}