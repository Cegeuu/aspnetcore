// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;

namespace Microsoft.AspNetCore.Session
{
    /// <inheritdoc />
    public class SessionFeature : ISessionFeature
    {
        /// <inheritdoc />
        public ISession Session { get; set; }
    }
}