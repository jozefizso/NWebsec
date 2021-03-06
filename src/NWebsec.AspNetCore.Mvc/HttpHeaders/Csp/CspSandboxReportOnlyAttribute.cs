// Copyright (c) Andr� N. Klingsheim. See License.txt in the project root for license information.

using NWebsec.AspNetCore.Mvc.HttpHeaders.Csp.Internals;

namespace NWebsec.AspNetCore.Mvc.HttpHeaders.Csp
{
    /// <summary>
    /// When applied to a controller or action method, enables the sandbox directive for the CSP header (CSP 1.0). 
    /// </summary>
    public class CspSandboxReportOnlyAttribute : CspSandboxAttributeBase
    {
        protected override bool ReportOnly => true;
    }
}