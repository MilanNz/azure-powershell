// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Extensions;

    public partial class WebSiteInstanceStatus :
        Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IWebSiteInstanceStatus,
        Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IWebSiteInstanceStatusInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResource __proxyOnlyResource = new Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.ProxyOnlyResource();

        /// <summary>Link to the console to web app instance</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Origin(Microsoft.Azure.PowerShell.Cmdlets.Websites.PropertyOrigin.Inlined)]
        public string ConsoleUrl { get => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IWebSiteInstanceStatusPropertiesInternal)Property).ConsoleUrl; set => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IWebSiteInstanceStatusPropertiesInternal)Property).ConsoleUrl = value ?? null; }

        /// <summary>Dictionary of <ContainerInfo></summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Origin(Microsoft.Azure.PowerShell.Cmdlets.Websites.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IWebSiteInstanceStatusPropertiesContainers Container { get => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IWebSiteInstanceStatusPropertiesInternal)Property).Container; set => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IWebSiteInstanceStatusPropertiesInternal)Property).Container = value ?? null /* model class */; }

        /// <summary>Link to the Diagnose and Solve Portal</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Origin(Microsoft.Azure.PowerShell.Cmdlets.Websites.PropertyOrigin.Inlined)]
        public string DetectorUrl { get => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IWebSiteInstanceStatusPropertiesInternal)Property).DetectorUrl; set => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IWebSiteInstanceStatusPropertiesInternal)Property).DetectorUrl = value ?? null; }

        /// <summary>Link to the console to web app instance</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Origin(Microsoft.Azure.PowerShell.Cmdlets.Websites.PropertyOrigin.Inlined)]
        public string HealthCheckUrl { get => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IWebSiteInstanceStatusPropertiesInternal)Property).HealthCheckUrl; set => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IWebSiteInstanceStatusPropertiesInternal)Property).HealthCheckUrl = value ?? null; }

        /// <summary>Resource Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Origin(Microsoft.Azure.PowerShell.Cmdlets.Websites.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)__proxyOnlyResource).Id; }

        /// <summary>Kind of resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Origin(Microsoft.Azure.PowerShell.Cmdlets.Websites.PropertyOrigin.Inherited)]
        public string Kind { get => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)__proxyOnlyResource).Kind; set => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)__proxyOnlyResource).Kind = value ?? null; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)__proxyOnlyResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)__proxyOnlyResource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)__proxyOnlyResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)__proxyOnlyResource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)__proxyOnlyResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)__proxyOnlyResource).Type = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IWebSiteInstanceStatusProperties Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IWebSiteInstanceStatusInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.WebSiteInstanceStatusProperties()); set { {_property = value;} } }

        /// <summary>Resource Name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Origin(Microsoft.Azure.PowerShell.Cmdlets.Websites.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)__proxyOnlyResource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IWebSiteInstanceStatusProperties _property;

        /// <summary>WebSiteInstanceStatus resource specific properties</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Origin(Microsoft.Azure.PowerShell.Cmdlets.Websites.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IWebSiteInstanceStatusProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.WebSiteInstanceStatusProperties()); set => this._property = value; }

        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Origin(Microsoft.Azure.PowerShell.Cmdlets.Websites.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.SiteRuntimeState? State { get => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IWebSiteInstanceStatusPropertiesInternal)Property).State; set => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IWebSiteInstanceStatusPropertiesInternal)Property).State = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.SiteRuntimeState)""); }

        /// <summary>Link to the GetStatusApi in Kudu</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Origin(Microsoft.Azure.PowerShell.Cmdlets.Websites.PropertyOrigin.Inlined)]
        public string StatusUrl { get => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IWebSiteInstanceStatusPropertiesInternal)Property).StatusUrl; set => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IWebSiteInstanceStatusPropertiesInternal)Property).StatusUrl = value ?? null; }

        /// <summary>Resource type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Origin(Microsoft.Azure.PowerShell.Cmdlets.Websites.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)__proxyOnlyResource).Type; }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__proxyOnlyResource), __proxyOnlyResource);
            await eventListener.AssertObjectIsValid(nameof(__proxyOnlyResource), __proxyOnlyResource);
        }

        /// <summary>Creates an new <see cref="WebSiteInstanceStatus" /> instance.</summary>
        public WebSiteInstanceStatus()
        {

        }
    }
    public partial interface IWebSiteInstanceStatus :
        Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResource
    {
        /// <summary>Link to the console to web app instance</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Link to the console to web app instance",
        SerializedName = @"consoleUrl",
        PossibleTypes = new [] { typeof(string) })]
        string ConsoleUrl { get; set; }
        /// <summary>Dictionary of <ContainerInfo></summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Dictionary of <ContainerInfo>",
        SerializedName = @"containers",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IWebSiteInstanceStatusPropertiesContainers) })]
        Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IWebSiteInstanceStatusPropertiesContainers Container { get; set; }
        /// <summary>Link to the Diagnose and Solve Portal</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Link to the Diagnose and Solve Portal",
        SerializedName = @"detectorUrl",
        PossibleTypes = new [] { typeof(string) })]
        string DetectorUrl { get; set; }
        /// <summary>Link to the console to web app instance</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Link to the console to web app instance",
        SerializedName = @"healthCheckUrl",
        PossibleTypes = new [] { typeof(string) })]
        string HealthCheckUrl { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.SiteRuntimeState) })]
        Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.SiteRuntimeState? State { get; set; }
        /// <summary>Link to the GetStatusApi in Kudu</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Link to the GetStatusApi in Kudu",
        SerializedName = @"statusUrl",
        PossibleTypes = new [] { typeof(string) })]
        string StatusUrl { get; set; }

    }
    internal partial interface IWebSiteInstanceStatusInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal
    {
        /// <summary>Link to the console to web app instance</summary>
        string ConsoleUrl { get; set; }
        /// <summary>Dictionary of <ContainerInfo></summary>
        Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IWebSiteInstanceStatusPropertiesContainers Container { get; set; }
        /// <summary>Link to the Diagnose and Solve Portal</summary>
        string DetectorUrl { get; set; }
        /// <summary>Link to the console to web app instance</summary>
        string HealthCheckUrl { get; set; }
        /// <summary>WebSiteInstanceStatus resource specific properties</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IWebSiteInstanceStatusProperties Property { get; set; }

        Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.SiteRuntimeState? State { get; set; }
        /// <summary>Link to the GetStatusApi in Kudu</summary>
        string StatusUrl { get; set; }

    }
}