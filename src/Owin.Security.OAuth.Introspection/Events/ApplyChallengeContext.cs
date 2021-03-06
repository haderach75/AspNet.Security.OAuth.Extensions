﻿/*
 * Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
 * See https://github.com/aspnet-contrib/AspNet.Security.OAuth.Extensions for more information
 * concerning the license and the contributors participating to this project.
 */

using JetBrains.Annotations;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Notifications;

namespace Owin.Security.OAuth.Introspection
{
    /// <summary>
    /// Allows customization of the challenge process.
    /// </summary>
    public class ApplyChallengeContext : BaseNotification<OAuthIntrospectionOptions>
    {
        public ApplyChallengeContext(
            [NotNull] IOwinContext context,
            [NotNull] OAuthIntrospectionOptions options,
            [NotNull] AuthenticationProperties properties)
            : base(context, options)
        {
            Properties = properties;
        }

        /// <summary>
        /// Gets the authentication properties associated with the challenge.
        /// </summary>
        public AuthenticationProperties Properties { get; }

        /// <summary>
        /// Gets or sets the "error" value returned to the caller as part
        /// of the WWW-Authenticate header. This property may be null when
        /// <see cref="OAuthIntrospectionOptions.IncludeErrorDetails"/> is set to <c>false</c>.
        /// </summary>
        public string Error { get; set; }

        /// <summary>
        /// Gets or sets the "error_description" value returned to the caller as part
        /// of the WWW-Authenticate header. This property may be null when
        /// <see cref="OAuthIntrospectionOptions.IncludeErrorDetails"/> is set to <c>false</c>.
        /// </summary>
        public string ErrorDescription { get; set; }

        /// <summary>
        /// Gets or sets the "error_uri" value returned to the caller as part of the
        /// WWW-Authenticate header. This property is always null unless explicitly set.
        /// </summary>
        public string ErrorUri { get; set; }

        /// <summary>
        /// Gets or sets the "realm" value returned to
        /// the caller as part of the WWW-Authenticate header.
        /// </summary>
        public string Realm { get; set; }

        /// <summary>
        /// Gets or sets the "scope" value returned to
        /// the caller as part of the WWW-Authenticate header.
        /// </summary>
        public string Scope { get; set; }
    }
}
