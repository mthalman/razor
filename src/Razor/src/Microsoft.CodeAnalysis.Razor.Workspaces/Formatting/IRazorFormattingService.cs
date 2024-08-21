﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT license. See License.txt in the project root for license information.

using System.Threading;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.Razor.ProjectSystem;
using Microsoft.CodeAnalysis.Razor.Protocol;
using Microsoft.VisualStudio.LanguageServer.Protocol;

namespace Microsoft.CodeAnalysis.Razor.Formatting;

internal interface IRazorFormattingService
{
    Task<TextEdit[]> GetDocumentFormattingEditsAsync(
       VersionedDocumentContext documentContext,
       Range? range,
       FormattingOptions options,
       CancellationToken cancellationToken);

    Task<TextEdit[]> GetOnTypeFormattingEditsAsync(
      DocumentContext documentContext,
      RazorLanguageKind kind,
      TextEdit[] formattedEdits,
      FormattingOptions options,
      int hostDocumentIndex,
      char triggerCharacter,
      CancellationToken cancellationToken);

    Task<TextEdit[]> GetCSharpCodeActionEditsAsync(
       DocumentContext documentContext,
       TextEdit[] formattedEdits,
       FormattingOptions options,
       CancellationToken cancellationToken);

    Task<TextEdit[]> GetSnippetFormattingEditsAsync(
       DocumentContext documentContext,
       RazorLanguageKind kind,
       TextEdit[] edits,
       FormattingOptions options,
       CancellationToken cancellationToken);
}
