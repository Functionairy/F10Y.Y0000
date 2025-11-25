using System;

using F10Y.T0001;


namespace F10Y.Y0000
{
    public static partial class Documentation
    {
        /// <summary>
        /// Contains documentation for the various strings, including fundamental strings ("" (the empty string), "A", "a", "1", "!", etc.) and useful strings ("TRUE", "true", "///", etc.).
        /// </summary>
        [DocumentationsMarker] // I think this is required for nested types to be surveyed?
        public static partial class For_Strings
        {
            /// <summary>
            /// <para><value>"*"</value>, <name>asterix</name></para>
            /// <para><description>The "*" asterix string.</description></para>
            /// </summary>
            /// <remarks>
            /// <para>---</para>
            /// <para><self-reference><see cref="For_Asterix"/></self-reference></para>
            /// </remarks>
            public static readonly object For_Asterix;

            /// <summary>
            /// <para><value>"\"</value>, <name>backslash</name></para>
            /// <para><description>The "\" backslash string.</description></para>
            /// </summary>
            /// <remarks>
            /// <para>---</para>
            /// <para><self-reference><see cref="For_BackSlash"/></self-reference></para>
            /// </remarks>
            public static readonly object For_BackSlash;

            /// <summary>
            /// <para><value>"©"</value>, <name>copyright string</name></para>
            /// <para><description>The "©" copyright string.</description></para>
            /// </summary>
            public static readonly object For_Copyright;

            /// <summary>
            /// <para><value>"--"</value>, <name>double-dash</name></para>
            /// <para><description>The "--" double-dash string.</description></para>
            /// </summary>
            /// <remarks>
            /// <para>---</para>
            /// <para><self-reference><see cref="For_DoubleDash"/></self-reference></para>
            /// </remarks>
            public static readonly object For_DoubleDash;

            /// <summary>
            /// <para><value>""</value>, <name>empty string</name></para>
            /// <para><description>The "" empty string.</description></para>
            /// </summary>
            public static readonly object For_Empty;

            /// <summary>
            /// <para><value>"-"</value>, <name>hyphen</name></para>
            /// <para><description>The "-" hyphen string.</description></para>
            /// </summary>
            /// <remarks>
            /// <para>---</para>
            /// <para><self-reference><see cref="For_Hyphen"/></self-reference></para>
            /// </remarks>
            public static readonly object For_Hyphen;

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
            /// <para><value></value>, <name>null string</name></para>
            /// <para><description>The null string.</description></para>
            /// </summary>
            public static readonly object For_Null;

            /// <summary>
            /// <para><value>"."</value>, <name>period</name></para>
            /// <para><description>The "." period string.</description></para>
            /// </summary>
            /// <remarks>
            /// <para>---</para>
            /// <para><self-reference><see cref="For_Period"/></self-reference></para>
            /// </remarks>
            public static readonly object For_Period;

            /// <summary>
            /// <para><value>"|"</value>, <name>pipe</name></para>
            /// <para><description>The "|" pipe string.</description></para>
            /// </summary>
            /// <remarks>
            /// <para>---</para>
            /// <para><self-reference><see cref="For_Pipe"/></self-reference></para>
            /// </remarks>
            public static readonly object For_Pipe;

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
            /// <para><value>"/"</value>, <name>slash</name></para>
            /// <para><description>The "/" slash string.</description></para>
            /// </summary>
            /// <remarks>
            /// <para>---</para>
            /// <para><self-reference><see cref="For_Slash"/></self-reference></para>
            /// </remarks>
            public static readonly object For_Slash;

            /// <summary>
            /// <para><value>" "</value>, <name>space</name></para>
            /// <para><description>The " " space string.</description></para>
            /// </summary>
            /// <remarks>
            /// <para>---</para>
            /// <para><self-reference><see cref="For_Space"/></self-reference></para>
            /// </remarks>
            public static readonly object For_Space;

            /// <summary>
            /// <para><value>"\t"</value>, <name>tab</name></para>
            /// <para><description>The "\t" tab string.</description></para>
            /// </summary>
            /// <remarks>
            /// <para>---</para>
            /// <para><self-reference><see cref="For_Tab"/></self-reference></para>
            /// </remarks>
            public static readonly object For_Tab;


            /// <summary>
            /// <para><value>"False"</value>, <name>False</name></para>
            /// <para><description>The "False" string.</description></para>
            /// </summary>
            public static readonly object For_False;

            /// <summary>
            /// <para><value>"false"</value>, <name>false-lowercase</name></para>
            /// <para><description>The "false" string.</description></para>
            /// </summary>
            public static readonly object For_False_Lowercase;

            /// <summary>
            /// <para><value>"FALSE"</value>, <name>false-uppercase</name></para>
            /// <para><description>The "FALSE" string.</description></para>
            /// </summary>
            public static readonly object For_False_Uppercase;

            /// <summary>
            /// <para><value>"True"</value>, <name>true</name></para>
            /// <para><description>The "True" string.</description></para>
            /// </summary>
            public static readonly object For_True;

            /// <summary>
            /// <para><value>"true"</value>, <name>true-lowercase</name></para>
            /// <para><description>The "true" string.</description></para>
            /// </summary>
            public static readonly object For_True_Lowercase;

            /// <summary>
            /// <para><value>"TRUE"</value>, <name>true-uppercase</name></para>
            /// <para><description>The "TRUE" string.</description></para>
            /// </summary>
            public static readonly object For_True_Uppercase;


            #region Alphabet - Uppercase

            /// <summary>
            /// <para><value>"A"</value>, <name>capital letter A</name></para>
            /// <para><description>The "A" capital letter string.</description></para>
            /// </summary>
            public static readonly object For_A;

            /// <summary>
            /// <para><value>"B"</value>, <name>capital letter B</name></para>
            /// <para><description>The "B" capital letter string.</description></para>
            /// </summary>
            public static readonly object For_B;

            /// <summary>
            /// <para><value>"C"</value>, <name>capital letter C</name></para>
            /// <para><description>The "C" capital letter string.</description></para>
            /// </summary>
            public static readonly object For_C;

            /// <summary>
            /// <para><value>"D"</value>, <name>capital letter D</name></para>
            /// <para><description>The "D" capital letter string.</description></para>
            /// </summary>
            public static readonly object For_D;

            /// <summary>
            /// <para><value>"E"</value>, <name>capital letter E</name></para>
            /// <para><description>The "E" capital letter string.</description></para>
            /// </summary>
            public static readonly object For_E;

            #endregion

            #region Alphabet - Lowercase



            #endregion
        }
    }
}
