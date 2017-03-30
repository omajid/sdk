// Copyright (c) .NET Foundation and contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.DotNet.Cli.Utils;
using Microsoft.DotNet.PlatformAbstractions;

namespace Microsoft.DotNet.Configurer
{
    public class CLIFallbackFolderPathCalculator
    {
        public string CLIFallbackFolderPath
        {
            get
            {
                string profileDir = Environment.GetEnvironmentVariable(
                    RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? "USERPROFILE" : "HOME");

                return Path.Combine(profileDir, ".dotnet", "NuGetFallbackFolder");
            }
        }
    }
}
