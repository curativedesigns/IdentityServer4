
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using Microsoft.EntityFrameworkCore;
using System;

namespace IdentityServer4.EntityFramework.Options
{
    /// <summary>
    ///     Options for configuring the configuration context.
    /// </summary>
    public class ConfigurationStoreOptions
    {
        /// <summary>
        ///     Callback to configure the EF DbContext.
        /// </summary>
        /// <value>
        ///     The configure database context.
        /// </value>
        public Action<DbContextOptionsBuilder> ConfigureDbContext { get; set; }

        /// <summary>
        ///     Callback in DI resolve the EF DbContextOptions. If set, ConfigureDbContext will not be used.
        /// </summary>
        /// <value>
        ///     The configure database context.
        /// </value>
        public Action<IServiceProvider, DbContextOptionsBuilder> ResolveDbContextOptions { get; set; }

        /// <summary>
        ///     Gets or sets the default schema.
        /// </summary>
        /// <value>
        ///     The default schema.
        /// </value>
        public string DefaultSchema { get; set; } = null;

        /// <summary>
        ///     Gets or sets the identity resource table configuration.
        /// </summary>
        /// <value>
        ///     The identity resource.
        /// </value>
        public TableConfiguration IdentityResource { get; set; } = new("IdentityResources");

        /// <summary>
        ///     Gets or sets the identity claim table configuration.
        /// </summary>
        /// <value>
        ///     The identity claim.
        /// </value>
        public TableConfiguration IdentityResourceClaim { get; set; } = new("IdentityResourceClaims");

        /// <summary>
        ///     Gets or sets the identity resource property table configuration.
        /// </summary>
        /// <value>
        ///     The client property.
        /// </value>
        public TableConfiguration IdentityResourceProperty { get; set; } = new("IdentityResourceProperties");

        /// <summary>
        ///     Gets or sets the API resource table configuration.
        /// </summary>
        /// <value>
        ///     The API resource.
        /// </value>
        public TableConfiguration ApiResource { get; set; } = new("ApiResources");

        /// <summary>
        ///     Gets or sets the API secret table configuration.
        /// </summary>
        /// <value>
        ///     The API secret.
        /// </value>
        public TableConfiguration ApiResourceSecret { get; set; } = new("ApiResourceSecrets");

        /// <summary>
        ///     Gets or sets the API scope table configuration.
        /// </summary>
        /// <value>
        ///     The API scope.
        /// </value>
        public TableConfiguration ApiResourceScope { get; set; } = new("ApiResourceScopes");

        /// <summary>
        ///     Gets or sets the API claim table configuration.
        /// </summary>
        /// <value>
        ///     The API claim.
        /// </value>
        public TableConfiguration ApiResourceClaim { get; set; } = new("ApiResourceClaims");

        /// <summary>
        ///     Gets or sets the API resource property table configuration.
        /// </summary>
        /// <value>
        ///     The client property.
        /// </value>
        public TableConfiguration ApiResourceProperty { get; set; } = new("ApiResourceProperties");

        /// <summary>
        ///     Gets or sets the client table configuration.
        /// </summary>
        /// <value>
        ///     The client.
        /// </value>
        public TableConfiguration Client { get; set; } = new("Clients");

        /// <summary>
        ///     Gets or sets the type of the client grant table configuration.
        /// </summary>
        /// <value>
        ///     The type of the client grant.
        /// </value>
        public TableConfiguration ClientGrantType { get; set; } = new("ClientGrantTypes");

        /// <summary>
        ///     Gets or sets the client redirect URI table configuration.
        /// </summary>
        /// <value>
        ///     The client redirect URI.
        /// </value>
        public TableConfiguration ClientRedirectUri { get; set; } = new("ClientRedirectUris");

        /// <summary>
        ///     Gets or sets the client post logout redirect URI table configuration.
        /// </summary>
        /// <value>
        ///     The client post logout redirect URI.
        /// </value>
        public TableConfiguration ClientPostLogoutRedirectUri { get; set; } = new("ClientPostLogoutRedirectUris");

        /// <summary>
        ///     Gets or sets the client scopes table configuration.
        /// </summary>
        /// <value>
        ///     The client scopes.
        /// </value>
        public TableConfiguration ClientScopes { get; set; } = new("ClientScopes");

        /// <summary>
        ///     Gets or sets the client secret table configuration.
        /// </summary>
        /// <value>
        ///     The client secret.
        /// </value>
        public TableConfiguration ClientSecret { get; set; } = new("ClientSecrets");

        /// <summary>
        ///     Gets or sets the client claim table configuration.
        /// </summary>
        /// <value>
        ///     The client claim.
        /// </value>
        public TableConfiguration ClientClaim { get; set; } = new("ClientClaims");

        /// <summary>
        ///     Gets or sets the client IdP restriction table configuration.
        /// </summary>
        /// <value>
        ///     The client IdP restriction.
        /// </value>
        public TableConfiguration ClientIdPRestriction { get; set; } = new("ClientIdPRestrictions");

        /// <summary>
        ///     Gets or sets the client cors origin table configuration.
        /// </summary>
        /// <value>
        ///     The client cors origin.
        /// </value>
        public TableConfiguration ClientCorsOrigin { get; set; } = new("ClientCorsOrigins");

        /// <summary>
        ///     Gets or sets the client property table configuration.
        /// </summary>
        /// <value>
        ///     The client property.
        /// </value>
        public TableConfiguration ClientProperty { get; set; } = new("ClientProperties");

        /// <summary>
        ///     Gets or sets the scope table configuration.
        /// </summary>
        /// <value>
        ///     The API resource.
        /// </value>
        public TableConfiguration ApiScope { get; set; } = new("ApiScopes");

        /// <summary>
        ///     Gets or sets the scope claim table configuration.
        /// </summary>
        /// <value>
        ///     The API scope claim.
        /// </value>
        public TableConfiguration ApiScopeClaim { get; set; } = new("ApiScopeClaims");

        /// <summary>
        ///     Gets or sets the API resource property table configuration.
        /// </summary>
        /// <value>
        ///     The client property.
        /// </value>
        public TableConfiguration ApiScopeProperty { get; set; } = new("ApiScopeProperties");
    }
}