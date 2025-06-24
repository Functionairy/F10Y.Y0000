using System;

using F10Y.T0001;


namespace F10Y.Y0000
{
    public static partial class Glossary
    {
        /// <summary>
        /// Contains documentation for character classes (digit, etc.)
        /// </summary>
        [DocumentationsMarker] // I think this is required for nested types to be surveyed?
        public static partial class For_CharacterClasses
        {
            /// <summary>
            /// <inheritdoc cref="Digit" path="/definition"/>
            /// </summary>
            /// <definition>The Digit class contains the numerical digits 0-9.</definition>
            /// <name><i>digit</i></name>
            public static readonly object Digit;

            /// <summary>
            /// <inheritdoc cref="Whitespace" path="/definition"/>
            /// </summary>
            /// <definition>The Whitespace class contains the whitespace characters tab through non-breaking-space.</definition>
            /// <name><i>whitespace</i></name>
            public static readonly object Whitespace;
        }
    }
}
