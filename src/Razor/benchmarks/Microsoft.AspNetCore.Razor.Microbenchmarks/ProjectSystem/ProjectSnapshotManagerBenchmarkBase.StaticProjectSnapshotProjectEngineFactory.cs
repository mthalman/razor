﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT license. See License.txt in the project root for license information.

using System;
using Microsoft.AspNetCore.Mvc.Razor.Extensions;
using Microsoft.AspNetCore.Razor.Language;
using Microsoft.AspNetCore.Razor.ProjectEngineHost;
using Microsoft.CodeAnalysis.Razor;
using Microsoft.CodeAnalysis.Razor.ProjectSystem;

namespace Microsoft.AspNetCore.Razor.Microbenchmarks;

public abstract partial class ProjectSnapshotManagerBenchmarkBase
{
    private class StaticProjectSnapshotProjectEngineFactory : IProjectSnapshotProjectEngineFactory
    {
        public IProjectEngineFactory? FindFactory(IProjectSnapshot project)
            => throw new NotImplementedException();

        public IProjectEngineFactory? FindSerializableFactory(IProjectSnapshot project)
            => throw new NotImplementedException();

        public RazorProjectEngine Create(
            RazorConfiguration configuration,
            RazorProjectFileSystem fileSystem,
            Action<RazorProjectEngineBuilder>? configure)
            => RazorProjectEngine.Create(configuration, fileSystem, RazorExtensions.Register);
    }
}
