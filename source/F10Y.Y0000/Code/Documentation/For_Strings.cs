using System;

using F10Y.T0001;


namespace F10Y.Y0000
{
    public static partial class Documentation
    {
        /// <summary>
        /// Contains documentation for the various strings, including fundamental strings ("" (the empty string), "A", "a", "1", "!", etc.) and useful strings ("TRUE", "true", "///", etc.).
        /// </summary>
        [DocumentationsMarker] // I think this is required?
        public static partial class For_Strings
        {
            /// <summary>
            /// <para><value>""</value>, <name>empty string</name></para>
            /// <para><description>The "" empty string.</description></para>
            /// </summary>
            public static readonly object For_Empty;

            /// <summary>
            /// <para><value>"""</value>, <name>quotation mark</name></para>
            /// <para><description>The """ quotation mark (or quote-mark or double-quotation mark) string.</description></para>
            /// </summary>
            public static readonly object For_QuotationMark;
        }
    }
}
