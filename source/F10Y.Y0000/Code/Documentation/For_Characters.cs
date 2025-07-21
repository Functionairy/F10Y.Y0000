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
            #region Alphabet - Upper

            /// <summary>
            /// <para><value>'A'</value>, <name>eh</name></para>
            /// <para><description>The uppercase 'A' (eh) character.</description></para>
            /// </summary>
            /// <remarks>
            /// <para>---</para>
            /// <para><self-reference><see cref="For_A"/></self-reference></para>
            /// </remarks>
            public static readonly object For_A;

            #endregion

            #region Alphabet - Lower

            /// <summary>
            /// <para><value>'v'</value>, <name>vee</name></para>
            /// <para><description>The lowercase 'v' (vee) character.</description></para>
            /// </summary>
            /// <remarks>
            /// <para>---</para>
            /// <para><self-reference><see cref="For_v"/></self-reference></para>
            /// </remarks>
            public static readonly object For_v;

            #endregion


            /// <summary>
            /// <para><value>'\'</value>, <name>backslash</name></para>
            /// <para><description>The '\' backslash character.</description></para>
            /// </summary>
            /// <remarks>
            /// <para>---</para>
            /// <para><self-reference><see cref="For_BackSlash"/></self-reference></para>
            /// </remarks>
            public static readonly object For_BackSlash;

            /// <summary>
            /// <para><value>'\r'</value>, <name>carriage-return</name></para>
            /// <para><description>The '\r' carriage-return character.</description></para>
            /// </summary>
            /// <remarks>
            /// <para>---</para>
            /// <para><self-reference><see cref="For_CarriageReturn"/></self-reference></para>
            /// </remarks>
            public static readonly object For_CarriageReturn;

            /// <summary>
            /// <para><value>':'</value>, <name>colon</name></para>
            /// <para><description>The ':' colon character.</description></para>
            /// </summary>
            /// <remarks>
            /// <para>---</para>
            /// <para><self-reference><see cref="For_Colon"/></self-reference></para>
            /// </remarks>
            public static readonly object For_Colon;

            /// <summary>
            /// <para><value>','</value>, <name>comma</name></para>
            /// <para><description>The ',' comma character.</description></para>
            /// </summary>
            /// <remarks>
            /// <para>---</para>
            /// <para><self-reference><see cref="For_Comma"/></self-reference></para>
            /// </remarks>
            public static readonly object For_Comma;

            /// <summary>
            /// <para><value>'='</value>, <name>equals</name></para>
            /// <para><description>The '=' equals character.</description></para>
            /// </summary>
            /// <remarks>
            /// <para>---</para>
            /// <para><self-reference><see cref="For_Equals"/></self-reference></para>
            /// </remarks>
            public static readonly object For_Equals;

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
            /// <para><value>'/'</value>, <name>slash</name></para>
            /// <para><description>The '/' slash character.</description></para>
            /// </summary>
            /// <remarks>
            /// <para>---</para>
            /// <para><self-reference><see cref="For_Slash"/></self-reference></para>
            /// </remarks>
            public static readonly object For_Slash;

            /// <summary>
            /// <para><value>' '</value>, <name>space</name></para>
            /// <para><description>The ' ' space character.</description></para>
            /// </summary>
            /// <remarks>
            /// <para>---</para>
            /// <para><self-reference><see cref="For_Space"/></self-reference></para>
            /// </remarks>
            public static readonly object For_Space;

            /// <summary>
            /// <para><description><value>'\t'</value>, <name>tab</name></description></para>
            /// <para><description>The '\t' tab character .</description></para>
            /// </summary>
            public static readonly object For_Tab;
        }
    }
}
