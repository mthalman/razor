﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT license. See License.txt in the project root for license information.

using System;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Razor.Workspaces;

namespace Microsoft.AspNetCore.Razor.LanguageServer;

internal sealed class LspWorkspaceProvider(IHostServicesProvider hostServicesProvider) : IWorkspaceProvider, IDisposable
{
    private readonly AdhocWorkspaceProvider _workspaceFactory = new AdhocWorkspaceProvider(hostServicesProvider);

    private bool _disposed;

    void IDisposable.Dispose()
    {
        if (_disposed)
        {
            return;
        }

        _workspaceFactory.Dispose();
        _disposed = true;
    }

    public Workspace GetWorkspace()
    {
        if (_disposed)
        {
            throw new ObjectDisposedException(nameof(LspWorkspaceProvider));
        }

        return _workspaceFactory.GetOrCreate();
    }
}
