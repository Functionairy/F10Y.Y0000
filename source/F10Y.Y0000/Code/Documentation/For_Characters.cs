using System;

using F10Y.T0001;


namespace F10Y.Y0000
{
    public static partial class Documentation
    {
        /// <summary>
        /// Contains documentation for the fundamental characters ('A', 'a', '1', '!', etc.).
        /// </summary>
        [DocumentationsMarker] // I think this is required for nested types to be surveyed?
        public static partial class For_Characters
        {
            /// <summary>
            /// <para><value>'\n'</value>, <name>new line</name></para>
            /// <para><description>The '"' quotation mark (or quote or double-quotation mark) character.</description></para>
            /// </summary>
            public static readonly object For_NewLine;

            /// <summary>
            /// <para><value>'\0'</value>, <name>null</name></para>
            /// <para><description>The '\n' null character .</description></para>
            /// </summary>
            public static readonly object For_Null;

            /// <summary>
            /// <para><value>'"'</value>, <name>quotation mark</name></para>
            /// <para><description>The '"' quotation mark (or quote or double-quotation mark) character.</description></para>
            /// </summary>
            public static readonly object For_QuotationMark;

            /// <summary>
            /// <para><description><value>'\t'</value>, <name>tab</name></description></para>
            /// <para><description>The '\t' tab character .</description></para>
            /// </summary>
            public static readonly object For_Tab;
        }
    }
}
