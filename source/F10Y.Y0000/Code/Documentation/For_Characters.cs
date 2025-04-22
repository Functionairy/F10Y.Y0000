using System;

using F10Y.T0001;


namespace F10Y.Y0000
{
    public static partial class Documentation
    {
        /// <summary>
        /// Contains documentation for the fundamental characters ('A', 'a', '1', '!', etc.).
        /// </summary>
        [DocumentationsMarker] // I think this is required?
        public static partial class For_Characters
        {
            /// <summary>
            /// <description><value>'\n'</value>, <name>new line</name></description>
            /// <para><description>The '"' quotation mark (or quote or double-quotation mark) character.</description></para>
            /// </summary>
            public static readonly object For_NewLine;

            /// <summary>
            /// <para><value>'"'</value>, <name>quotation mark</name></para>
            /// <para><description>The '"' quotation mark (or quote or double-quotation mark) character.</description></para>
            /// </summary>
            public static readonly object For_QuotationMark;
        }
    }
}
