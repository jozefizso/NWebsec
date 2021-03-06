// Copyright (c) Andr� N. Klingsheim. See License.txt in the project root for license information.

using System;
using NWebsec.AspNetCore.Mvc.Helpers;
using NWebsec.AspNetCore.Mvc.HttpHeaders.Csp.Internals;

namespace NWebsec.AspNetCore.Mvc.HttpHeaders.Csp
{
    /// <summary>
    /// When applied to a controller or action method, enables the script-src directive for the CSP header (CSP 1.0). 
    /// </summary>
    public class CspScriptSrcAttribute : CspDirectiveAttributeBase
    {
        /// <summary>
        /// Gets or sets whether the 'unsafe-inline' source is included in the directive. Not setting it will inherit existing configuration.
        /// </summary>
        public bool UnsafeInline { get { throw new NotSupportedException(); } set { DirectiveConfig.UnsafeInline = value; } }
        /// <summary>
        /// Gets or sets whether the 'unsafe-eval' source is included in the directive. Not setting it will inherit existing configuration.
        /// </summary>
        public bool UnsafeEval { get { throw new NotSupportedException(); } set { DirectiveConfig.UnsafeEval = value; } }

        protected override CspDirectives Directive => CspDirectives.ScriptSrc;

        protected override bool ReportOnly => false;
    }
}