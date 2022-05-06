﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT license. See License.txt in the project root for license information.

using System;
using System.ComponentModel.Composition;
using Microsoft.CodeAnalysis.Razor.Workspaces;

namespace Microsoft.VisualStudio.Editor.Razor
{
    [Export(typeof(VSLanguageServerFeatureOptions))]
    internal class VSLanguageServerFeatureOptions : LanguageServerFeatureOptions
    {
        private readonly LSPEditorFeatureDetector _lspEditorFeatureDetector;

        [ImportingConstructor]
        public VSLanguageServerFeatureOptions(LSPEditorFeatureDetector lspEditorFeatureDetector)
        {
            if (lspEditorFeatureDetector is null)
            {
                throw new ArgumentNullException(nameof(lspEditorFeatureDetector));
            }

            _lspEditorFeatureDetector = lspEditorFeatureDetector;
        }

        // We don't currently support file creation operations on VS Codespaces or VS Liveshare
        public override bool SupportsFileManipulation => !IsCodespacesOrLiveshare;

        // In VS we override the project configuration file name because we don't want our serialized state to clash with other platforms (VSCode)
        public override string ProjectConfigurationFileName => "project.razor.vs.json";

        public override string CSharpVirtualDocumentSuffix => ".g.cs";

        public override string HtmlVirtualDocumentSuffix => "__virtual.html";

        private bool IsCodespacesOrLiveshare => _lspEditorFeatureDetector.IsRemoteClient() || _lspEditorFeatureDetector.IsLiveShareHost();

    }
}
