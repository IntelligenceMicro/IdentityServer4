﻿// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System.Linq;

namespace IdentityServer4.Core.Models
{
    /// <summary>
    /// Models the user's response to the consent screen.
    /// </summary>
    public class UserConsent
    {
        /// <summary>
        /// Gets if consent was granted.
        /// </summary>
        /// <value>
        ///   <c>true</c> if consent was granted; otherwise, <c>false</c>.
        /// </value>
        public bool Granted
        {
            get
            {
                return ScopesConsented != null && ScopesConsented.Any();
            }
        }

        /// <summary>
        /// Gets or sets the scopes consented to.
        /// </summary>
        /// <value>
        /// The scopes.
        /// </value>
        public string[] ScopesConsented { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the user wishes the consent to be remembered.
        /// </summary>
        /// <value>
        ///   <c>true</c> if consent is to be remembered; otherwise, <c>false</c>.
        /// </value>
        public bool RememberConsent { get; set; }
    }
}
