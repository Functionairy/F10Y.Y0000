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
            /// <para><value>"©"</value>, <name>copyright string</name></para>
            /// <para><description>The "©" copyright string.</description></para>
            /// </summary>
            public static readonly object For_Copyright;

            /// <summary>
            /// <para><value>""</value>, <name>empty string</name></para>
            /// <para><description>The "" empty string.</description></para>
            /// </summary>
            public static readonly object For_Empty;

            /// <summary>
            /// <para><value>"\n"</value>, <name>new line</name></para>
            /// <para><description>The "\n" new line string (or line feed LF).</description></para>
            /// </summary>
            public static readonly object For_NewLine;

            /// <summary>
            /// <para><value>"\r\n"</value>, <name>carriage return and new line</name></para>
            /// <para><description>The "\r\n" carriage return and new line string (or carriage return and line feed, CRLF).</description></para>
            /// </summary>
            public static readonly object For_NewLine_Windows;

            /// <summary>
            /// <para><value>"""</value>, <name>quotation mark</name></para>
            /// <para><description>The """ quotation mark (or quote-mark or double-quotation mark) string.</description></para>
            /// </summary>
            public static readonly object For_QuotationMark;

            /// <summary>
            /// <para><value>";"</value>, <name>semicolon</name></para>
            /// <para><description>The ";" semicolon string.</description></para>
            /// </summary>
            public static readonly object For_Semicolon;

            /// <summary>
            /// <para><value>" "</value>, <name>space</name></para>
            /// <para><description>The " " space string.</description></para>
            /// </summary>
            public static readonly object For_Space;


            /// <summary>
            /// <para><value>"false"</value>, <name>false-lowercase</name></para>
            /// <para><description>The "false" string.</description></para>
            /// </summary>
            public static readonly object For_False_Lowercase;

            /// <summary>
            /// <para><value>"true"</value>, <name>true-lowercase</name></para>
            /// <para><description>The "true" string.</description></para>
            /// </summary>
            public static readonly object For_True_Lowercase;
        }
    }
}
