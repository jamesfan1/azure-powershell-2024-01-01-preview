// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using Microsoft.Azure;
using Microsoft.Azure.Commands.Compute.Automation.Models;
using Microsoft.Azure.Management.Compute;
using Microsoft.Azure.Management.Compute.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;

namespace Microsoft.Azure.Commands.Compute.Automation
{
    [Cmdlet(VerbsCommon.New, "AzureComputeParameterObject", DefaultParameterSetName = "CreateParameterObjectByFullName")]
    [OutputType(typeof(object))]
    public partial class NewAzureComputeParameterObjectCmdlet : ComputeAutomationBaseCmdlet
    {
        [Parameter(ParameterSetName = "CreateParameterObjectByFriendlyName", Mandatory = true, Position = 0)]
        [ValidateSet(
            "VirtualMachineScaleSetsAdditionalUnattendContent",
            "VirtualMachineScaleSetsAdditionalUnattendContentList",
            "VirtualMachineScaleSetsImageReference",
            "VirtualMachineScaleSetsLinuxConfiguration",
            "VirtualMachineScaleSetsSku",
            "VirtualMachineScaleSetsSshConfiguration",
            "VirtualMachineScaleSetsSshPublicKey",
            "VirtualMachineScaleSetsSshPublicKeyList",
            "VirtualMachineScaleSetstorageProfile",
            "VirtualMachineScaleSetsUpgradePolicy",
            "VirtualMachineScaleSetsVaultSecretGroup",
            "VirtualMachineScaleSetsVaultSecretGroupList",
            "VirtualMachineScaleSetsVirtualHardDisk",
            "VirtualMachineScaleSetsVirtualMachineScaleSet",
            "VirtualMachineScaleSetsVirtualMachineScaleSetExtension",
            "VirtualMachineScaleSetsVirtualMachineScaleSetExtensionList",
            "VirtualMachineScaleSetsVirtualMachineScaleSetExtensionProfile",
            "VirtualMachineScaleSetsVirtualMachineScaleSetNetworkConfiguration",
            "VirtualMachineScaleSetsVirtualMachineScaleSetNetworkConfigurationList",
            "VirtualMachineScaleSetsVirtualMachineScaleSetNetworkProfile",
            "VirtualMachineScaleSetsVirtualMachineScaleSetOSDisk",
            "VirtualMachineScaleSetsVirtualMachineScaleSetOSProfile",
            "VirtualMachineScaleSetsVirtualMachineScaleSetVMProfile",
            "VirtualMachineScaleSetsWindowsConfiguration",
            "VirtualMachineScaleSetsWinRMConfiguration",
            "VirtualMachineScaleSetsWinRMListener",
            "VirtualMachineScaleSetsWinRMListenerList"
        )]
        public string FriendlyName { get; set; }

        [Parameter(ParameterSetName = "CreateParameterObjectByFullName", Mandatory = true, Position = 0)]
        [ValidateSet(
            "Microsoft.Azure.Management.Compute.Models.AdditionalUnattendContent",
            "Microsoft.Azure.Management.Compute.Models.ImageReference",
            "Microsoft.Azure.Management.Compute.Models.LinuxConfiguration",
            "Microsoft.Azure.Management.Compute.Models.Sku",
            "Microsoft.Azure.Management.Compute.Models.SshConfiguration",
            "Microsoft.Azure.Management.Compute.Models.SshPublicKey",
            "Microsoft.Azure.Management.Compute.Models.UpgradePolicy",
            "Microsoft.Azure.Management.Compute.Models.VaultSecretGroup",
            "Microsoft.Azure.Management.Compute.Models.VirtualHardDisk",
            "Microsoft.Azure.Management.Compute.Models.VirtualMachineScaleSet",
            "Microsoft.Azure.Management.Compute.Models.VirtualMachineScaleSetExtension",
            "Microsoft.Azure.Management.Compute.Models.VirtualMachineScaleSetExtensionProfile",
            "Microsoft.Azure.Management.Compute.Models.VirtualMachineScaleSetNetworkConfiguration",
            "Microsoft.Azure.Management.Compute.Models.VirtualMachineScaleSetNetworkProfile",
            "Microsoft.Azure.Management.Compute.Models.VirtualMachineScaleSetOSDisk",
            "Microsoft.Azure.Management.Compute.Models.VirtualMachineScaleSetOSProfile",
            "Microsoft.Azure.Management.Compute.Models.VirtualMachineScaleSetStorageProfile",
            "Microsoft.Azure.Management.Compute.Models.VirtualMachineScaleSetVMProfile",
            "Microsoft.Azure.Management.Compute.Models.WindowsConfiguration",
            "Microsoft.Azure.Management.Compute.Models.WinRMConfiguration",
            "Microsoft.Azure.Management.Compute.Models.WinRMListener",
            "System.Collections.Generic.List<AdditionalUnattendContent>",
            "System.Collections.Generic.List<SshPublicKey>",
            "System.Collections.Generic.List<VaultSecretGroup>",
            "System.Collections.Generic.List<VirtualMachineScaleSetExtension>",
            "System.Collections.Generic.List<VirtualMachineScaleSetNetworkConfiguration>",
            "System.Collections.Generic.List<WinRMListener>"
        )]
        public string FullName { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            ExecuteClientAction(() =>
            {
                if (ParameterSetName == "CreateParameterObjectByFriendlyName")
                {
                    switch (FriendlyName)
                    {
                        case "VirtualMachineScaleSetsAdditionalUnattendContent" : WriteObject(new AdditionalUnattendContent()); break;
                        case "VirtualMachineScaleSetsAdditionalUnattendContentList" : WriteObject(new List<AdditionalUnattendContent>()); break;
                        case "VirtualMachineScaleSetsImageReference" : WriteObject(new ImageReference()); break;
                        case "VirtualMachineScaleSetsLinuxConfiguration" : WriteObject(new LinuxConfiguration()); break;
                        case "VirtualMachineScaleSetsSku" : WriteObject(new Sku()); break;
                        case "VirtualMachineScaleSetsSshConfiguration" : WriteObject(new SshConfiguration()); break;
                        case "VirtualMachineScaleSetsSshPublicKey" : WriteObject(new SshPublicKey()); break;
                        case "VirtualMachineScaleSetsSshPublicKeyList" : WriteObject(new List<SshPublicKey>()); break;
                        case "VirtualMachineScaleSetstorageProfile" : WriteObject(new VirtualMachineScaleSetStorageProfile()); break;
                        case "VirtualMachineScaleSetsUpgradePolicy" : WriteObject(new UpgradePolicy()); break;
                        case "VirtualMachineScaleSetsVaultSecretGroup" : WriteObject(new VaultSecretGroup()); break;
                        case "VirtualMachineScaleSetsVaultSecretGroupList" : WriteObject(new List<VaultSecretGroup>()); break;
                        case "VirtualMachineScaleSetsVirtualHardDisk" : WriteObject(new VirtualHardDisk()); break;
                        case "VirtualMachineScaleSetsVirtualMachineScaleSet" : WriteObject(new VirtualMachineScaleSet()); break;
                        case "VirtualMachineScaleSetsVirtualMachineScaleSetExtension" : WriteObject(new VirtualMachineScaleSetExtension()); break;
                        case "VirtualMachineScaleSetsVirtualMachineScaleSetExtensionList" : WriteObject(new List<VirtualMachineScaleSetExtension>()); break;
                        case "VirtualMachineScaleSetsVirtualMachineScaleSetExtensionProfile" : WriteObject(new VirtualMachineScaleSetExtensionProfile()); break;
                        case "VirtualMachineScaleSetsVirtualMachineScaleSetNetworkConfiguration" : WriteObject(new VirtualMachineScaleSetNetworkConfiguration()); break;
                        case "VirtualMachineScaleSetsVirtualMachineScaleSetNetworkConfigurationList" : WriteObject(new List<VirtualMachineScaleSetNetworkConfiguration>()); break;
                        case "VirtualMachineScaleSetsVirtualMachineScaleSetNetworkProfile" : WriteObject(new VirtualMachineScaleSetNetworkProfile()); break;
                        case "VirtualMachineScaleSetsVirtualMachineScaleSetOSDisk" : WriteObject(new VirtualMachineScaleSetOSDisk()); break;
                        case "VirtualMachineScaleSetsVirtualMachineScaleSetOSProfile" : WriteObject(new VirtualMachineScaleSetOSProfile()); break;
                        case "VirtualMachineScaleSetsVirtualMachineScaleSetVMProfile" : WriteObject(new VirtualMachineScaleSetVMProfile()); break;
                        case "VirtualMachineScaleSetsWindowsConfiguration" : WriteObject(new WindowsConfiguration()); break;
                        case "VirtualMachineScaleSetsWinRMConfiguration" : WriteObject(new WinRMConfiguration()); break;
                        case "VirtualMachineScaleSetsWinRMListener" : WriteObject(new WinRMListener()); break;
                        case "VirtualMachineScaleSetsWinRMListenerList" : WriteObject(new List<WinRMListener>()); break;
                        default : WriteWarning("Cannot find the type by FriendlyName = '" + FriendlyName + "'."); break;
                    }
                }
                else if (ParameterSetName == "CreateParameterObjectByFullName")
                {
                    switch (FullName)
                    {
                        case "Microsoft.Azure.Management.Compute.Models.AdditionalUnattendContent" : WriteObject(new AdditionalUnattendContent()); break;
                        case "Microsoft.Azure.Management.Compute.Models.ImageReference" : WriteObject(new ImageReference()); break;
                        case "Microsoft.Azure.Management.Compute.Models.LinuxConfiguration" : WriteObject(new LinuxConfiguration()); break;
                        case "Microsoft.Azure.Management.Compute.Models.Sku" : WriteObject(new Sku()); break;
                        case "Microsoft.Azure.Management.Compute.Models.SshConfiguration" : WriteObject(new SshConfiguration()); break;
                        case "Microsoft.Azure.Management.Compute.Models.SshPublicKey" : WriteObject(new SshPublicKey()); break;
                        case "Microsoft.Azure.Management.Compute.Models.UpgradePolicy" : WriteObject(new UpgradePolicy()); break;
                        case "Microsoft.Azure.Management.Compute.Models.VaultSecretGroup" : WriteObject(new VaultSecretGroup()); break;
                        case "Microsoft.Azure.Management.Compute.Models.VirtualHardDisk" : WriteObject(new VirtualHardDisk()); break;
                        case "Microsoft.Azure.Management.Compute.Models.VirtualMachineScaleSet" : WriteObject(new VirtualMachineScaleSet()); break;
                        case "Microsoft.Azure.Management.Compute.Models.VirtualMachineScaleSetExtension" : WriteObject(new VirtualMachineScaleSetExtension()); break;
                        case "Microsoft.Azure.Management.Compute.Models.VirtualMachineScaleSetExtensionProfile" : WriteObject(new VirtualMachineScaleSetExtensionProfile()); break;
                        case "Microsoft.Azure.Management.Compute.Models.VirtualMachineScaleSetNetworkConfiguration" : WriteObject(new VirtualMachineScaleSetNetworkConfiguration()); break;
                        case "Microsoft.Azure.Management.Compute.Models.VirtualMachineScaleSetNetworkProfile" : WriteObject(new VirtualMachineScaleSetNetworkProfile()); break;
                        case "Microsoft.Azure.Management.Compute.Models.VirtualMachineScaleSetOSDisk" : WriteObject(new VirtualMachineScaleSetOSDisk()); break;
                        case "Microsoft.Azure.Management.Compute.Models.VirtualMachineScaleSetOSProfile" : WriteObject(new VirtualMachineScaleSetOSProfile()); break;
                        case "Microsoft.Azure.Management.Compute.Models.VirtualMachineScaleSetStorageProfile" : WriteObject(new VirtualMachineScaleSetStorageProfile()); break;
                        case "Microsoft.Azure.Management.Compute.Models.VirtualMachineScaleSetVMProfile" : WriteObject(new VirtualMachineScaleSetVMProfile()); break;
                        case "Microsoft.Azure.Management.Compute.Models.WindowsConfiguration" : WriteObject(new WindowsConfiguration()); break;
                        case "Microsoft.Azure.Management.Compute.Models.WinRMConfiguration" : WriteObject(new WinRMConfiguration()); break;
                        case "Microsoft.Azure.Management.Compute.Models.WinRMListener" : WriteObject(new WinRMListener()); break;
                        case "System.Collections.Generic.List<AdditionalUnattendContent>" : WriteObject(new List<AdditionalUnattendContent>()); break;
                        case "System.Collections.Generic.List<SshPublicKey>" : WriteObject(new List<SshPublicKey>()); break;
                        case "System.Collections.Generic.List<VaultSecretGroup>" : WriteObject(new List<VaultSecretGroup>()); break;
                        case "System.Collections.Generic.List<VirtualMachineScaleSetExtension>" : WriteObject(new List<VirtualMachineScaleSetExtension>()); break;
                        case "System.Collections.Generic.List<VirtualMachineScaleSetNetworkConfiguration>" : WriteObject(new List<VirtualMachineScaleSetNetworkConfiguration>()); break;
                        case "System.Collections.Generic.List<WinRMListener>" : WriteObject(new List<WinRMListener>()); break;
                        default : WriteWarning("Cannot find the type by FullName = '" + FullName + "'."); break;
                    }
                }
            });
        }

    }
}
