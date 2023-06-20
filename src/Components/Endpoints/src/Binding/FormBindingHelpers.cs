// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Microsoft.AspNetCore.Components.Endpoints.Binding;

internal static class FormBindingHelpers
{
    public const string RequiresUnreferencedCodeMessage = "Form binding is not compatible with trimming, as it requires dynamic access to code that is not referenced statically.";
    public const string RequiresDynamicCodeMessage = "Form binding may require dynamic code generation.";
}
