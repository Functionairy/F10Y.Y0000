using System;
using System.Xml.Linq;

using F10Y.T0001;


namespace F10Y.Y0000
{
    public static partial class Documentation
    {
        /// <summary>
        /// Contains documentation for XML and XML types.
        /// </summary>
        [DocumentationsMarker]
        public static partial class For_Xml
        {
            /// <summary>
            /// Insignificant whitespace is any XText node that contains only whitespace.
            /// See <inheritdoc cref="Links.For_InsignificantWhitespace" path="/summary"/>.
            /// </summary>
            public static readonly object InsignificantWhitespace;

            /// <summary>
            /// Note that only <see cref="XElement"/>, <see cref="XDocument"/> and <see cref="XAttribute"/> have cloning constructors
            /// (<see cref="XObject"/>, <see cref="XNode"/>, and <see cref="XContainer"/> do not).
            /// </summary>
            public static readonly object WhichXObjectsAreCloneable;
        }
    }
}
