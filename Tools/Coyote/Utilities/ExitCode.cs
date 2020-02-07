﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

namespace Microsoft.Coyote.TestingServices
{
    /// <summary>
    /// The exit code returned by the tester.
    /// </summary>
    internal enum ExitCode
    {
        /// <summary>
        /// Indicates that no bugs were found.
        /// </summary>
        Success = 0,

        /// <summary>
        /// Indicates that a bug was found.
        /// </summary>
        BugFound = 1,

        /// <summary>
        /// Indicates that an internal exception was thrown.
        /// </summary>
        InternalError = 2
    }
}
