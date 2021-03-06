﻿//-----------------------------------------------------------------------
// <copyright file="LocalizationTagHelperOptions.cs">
//   Copyright (c) Kim Nordmo. All rights reserved.
//   Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// <author>Kim Nordmo</author>
//-----------------------------------------------------------------------

namespace Localization.AspNetCore.TagHelpers
{
  /// <summary>
  ///   Global optionsto pass to <see cref="GenericLocalizeTagHelper" /> and <see cref="LocalizeTagHelper" />
  /// </summary>
  public class LocalizeTagHelperOptions
  {
    /// <summary>
    /// Gets or sets wether the localize tag helpers should localize its content by default.
    /// (Can be overridden by using <c>html=<see langword="false"/></c> when calling one of the localize tag helpers).
    /// </summary>
    /// <remarks>Defaults to <see langword="true"/></remarks>
    public bool HtmlEncodeByDefault { get; set; } = true;

    /// <summary>
    ///   Gets or sets what new lines should be normalized to, or <see cref="NewLineHandling.None" />
    ///   to use existing line endings.
    /// </summary>
    /// <remarks>Defaults to <see cref="NewLineHandling.Auto" /></remarks>
    public NewLineHandling NewLineHandling { get; set; } = NewLineHandling.Auto;

    /// <summary>
    ///   Gets or sets a value indicating whether beginning and ending whitespace.
    /// </summary>
    /// <value><c>true</c> to trim beginning and ending whitespace; otherwise, <c>false</c>.</value>
    /// <remarks>Defaults to <see langword="true" /></remarks>
    public bool TrimWhitespace { get; set; } = true;
  }
}
