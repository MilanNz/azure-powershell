﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using System;
using System.Linq;
using System.Management.Automation;
using Microsoft.Azure.Commands.NetworkResourceProvider.Models;
using Microsoft.Azure.Commands.NetworkResourceProvider.Properties;
using MNM = Microsoft.Azure.Management.Network.Models;

namespace Microsoft.Azure.Commands.NetworkResourceProvider
{
    [Cmdlet(VerbsCommon.Add, "AzureLoadBalancerProbeConfigCmdlet"), OutputType(typeof(PSLoadBalancingRule))]
    public class AddAzureLoadBalancerProbeConfig : CommonAzureLoadBalancerProbeConfig
    {
        [Parameter(
            Mandatory = true,
            ValueFromPipeline = true,
            HelpMessage = "The load balancer")]
        public PSLoadBalancer LoadBalancer { get; set; }

        public override void ExecuteCmdlet()
        {
            base.ExecuteCmdlet();
            
            var existingProbe = this.LoadBalancer.Properties.Probes.SingleOrDefault(resource => string.Equals(resource.Name, this.Name, System.StringComparison.CurrentCultureIgnoreCase));

            if (existingProbe != null)
            {
                throw new ArgumentException("Probe with the specified name already exists");
            }

            var probe = new PSProbe();
            probe.Name = this.Name;
            probe.Properties = new PSProbeProperties();
            probe.Properties.Port = this.Port;
            probe.Properties.Protocol = this.Protocol;
            probe.Properties.RequestPath = this.RequestPath;
            probe.Properties.IntervalInSeconds = this.IntervalInSeconds;
            probe.Properties.NumberOfProbes = this.ProbeCount;

            probe.Id =
                ChildResourceHelper.GetResourceId(
                    this.NetworkClient.NetworkResourceProviderClient.Credentials.SubscriptionId,
                    this.LoadBalancer.ResourceGroupName,
                    this.LoadBalancer.Name,
                    Resources.LoadBalancerProbeName,
                    this.Name);

            this.LoadBalancer.Properties.Probes.Add(probe);

            WriteObject(this.LoadBalancer);
        }
    }
}
