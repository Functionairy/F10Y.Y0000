using System;

using F10Y.T0001;


namespace F10Y.Y0000
{
    public static partial class Documentation
    {
        [DocumentationsMarker]
        public static class Links
        {
            /// <summary>
            /// <link><see href="https://learn.microsoft.com/en-us/dotnet/standard/frameworks#supported-target-frameworks"/></link>
            /// </summary>
            public static readonly object For_TargetFrameworks;

            /// <summary>
            /// <see href="https://www.liquid-technologies.com/Reference/Glossary/XML_Whitespace.html"/>
            /// </summary>
            public static readonly object For_InsignificantWhitespace;

            /// <summary>
            /// <see href="https://www.w3.org/TR/xml/"/>, section 2.11 "End-of-Line Handling"
            /// </summary>
            public static readonly object For_XmlStandardEndOfLineHandling;
        }
    }
}
