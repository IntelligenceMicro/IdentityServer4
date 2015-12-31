﻿// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

namespace IdentityServer4.Core.Configuration
{
    /// <summary>
    /// Configures which endpoints are enabled or disabled.
    /// </summary>
    public class EndpointOptions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EndpointOptions"/> class.
        /// </summary>
        public EndpointOptions()
        {
            this.EnableAuthorizeEndpoint = true;
            this.EnableTokenEndpoint = true;
            this.EnableUserInfoEndpoint = true;
            this.EnableDiscoveryEndpoint = true;
            this.EnableAccessTokenValidationEndpoint = true;
            this.EnableIdentityTokenValidationEndpoint = true;
            this.EnableEndSessionEndpoint = true;
            this.EnableClientPermissionsEndpoint = true;
            this.EnableCspReportEndpoint = true;
            this.EnableCheckSessionEndpoint = true;
            this.EnableTokenRevocationEndpoint = true;
            this.EnableIntrospectionEndpoint = true;
        }

        /// <summary>
        /// Gets or sets a value indicating whether the authorize endpoint is enabled.
        /// </summary>
        /// <value>
        /// <c>true</c> if the authorize endpoint is enabled; otherwise, <c>false</c>.
        /// </value>
        public bool EnableAuthorizeEndpoint { get; set; }
        
        /// <summary>
        /// Gets or sets a value indicating whether the token endpoint is enabled.
        /// </summary>
        /// <value>
        /// <c>true</c> if the token endpoint is enabled; otherwise, <c>false</c>.
        /// </value>
        public bool EnableTokenEndpoint { get; set; }
        
        /// <summary>
        /// Gets or sets a value indicating whether the user info endpoint is enabled.
        /// </summary>
        /// <value>
        /// <c>true</c> if the user info endpoint is enabled; otherwise, <c>false</c>.
        /// </value>
        public bool EnableUserInfoEndpoint { get; set; }
        
        /// <summary>
        /// Gets or sets a value indicating whether the discovery document endpoint is enabled.
        /// </summary>
        /// <value>
        /// <c>true</c> if the disdovery document endpoint is enabled; otherwise, <c>false</c>.
        /// </value>
        public bool EnableDiscoveryEndpoint { get; set; }
        
        /// <summary>
        /// Gets or sets a value indicating whether the access token validation endpoint is enabled.
        /// </summary>
        /// <value>
        /// <c>true</c> if the access token validation endpoint is enabled; otherwise, <c>false</c>.
        /// </value>
        public bool EnableAccessTokenValidationEndpoint { get; set; }
        
        /// <summary>
        /// Gets or sets a value indicating whether the identity token validation endpoint is enabled.
        /// </summary>
        /// <value>
        /// <c>true</c> if the identity token validation endpoint is enabled; otherwise, <c>false</c>.
        /// </value>
        public bool EnableIdentityTokenValidationEndpoint { get; set; }
        
        /// <summary>
        /// Gets or sets a value indicating whether the end session endpoint is enabled.
        /// </summary>
        /// <value>
        /// <c>true</c> if the end session endpoint is enabled; otherwise, <c>false</c>.
        /// </value>
        public bool EnableEndSessionEndpoint { get; set; }
        
        /// <summary>
        /// Gets or sets a value indicating whether the client permissions endpoint is enabled.
        /// </summary>
        /// <value>
        /// <c>true</c> if the client permissions endpoint is enabled; otherwise, <c>false</c>.
        /// </value>
        public bool EnableClientPermissionsEndpoint { get; set; }
        
        /// <summary>
        /// Gets or sets a value indicating whether the CSP report endpoint is enabled.
        /// </summary>
        /// <value>
        /// <c>true</c> if the CSP report endpoint is enabled; otherwise, <c>false</c>.
        /// </value>
        public bool EnableCspReportEndpoint { get; set; }
        
        /// <summary>
        /// Gets or sets a value indicating whether the check session endpoint is enabled.
        /// </summary>
        /// <value>
        /// <c>true</c> if the check session endpoint is enabled; otherwise, <c>false</c>.
        /// </value>
        public bool EnableCheckSessionEndpoint { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the token revocation endpoint is enabled.
        /// </summary>
        /// <value>
        /// <c>true</c> if the token revocation endpoint is enabled; otherwise, <c>false</c>.
        /// </value>
        public bool EnableTokenRevocationEndpoint { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the introspection endpoint is enabled.
        /// </summary>
        /// <value>
        /// <c>true</c> if the introspection endpoint is enabled; otherwise, <c>false</c>.
        /// </value>
        public bool EnableIntrospectionEndpoint { get; set; }
    }
}